﻿//MIT License
//
//Copyright (c) 2020 Eren "Haltroy" Kanat
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace HaltroyFramework
{
    [DefaultValue("Checked"), DefaultEvent("CheckedChanged"), ToolboxBitmap(typeof(CheckBox))]
    public class HaltroySwitch : Control
    {
        #region Delegate and Event declarations

        public delegate void CheckedChangedDelegate(object sender, EventArgs e);
        [Description("Raised when the HaltroySwitch has changed state")]
        public event CheckedChangedDelegate CheckedChanged;

        #endregion Delegate and Event declarations

        #region Private Members

        private readonly Timer _animationTimer = new Timer();
        private HaltroySwitchRendererBase _renderer;
        private bool _checked = false;
        private bool _moving = false;
        private bool _animating = false;
        private bool _animationResult = false;
        private int _animationTarget = 0;
        private bool _useAnimation = true;
        private int _animationInterval = 1;
        private int _animationStep = 10;
        private bool _allowUserChange = true;

        private bool _isLeftFieldHovered = false;
        private bool _isButtonHovered = false;
        private bool _isRightFieldHovered = false;
        private bool _isLeftFieldPressed = false;
        private bool _isButtonPressed = false;
        private bool _isRightFieldPressed = false;

        private int _buttonValue = 0;
        private int _savedButtonValue = 0;
        private int _xOffset = 0;
        private int _xValue = 0;
        private int _thresholdPercentage = 50;
        private bool _grayWhenDisabled = true;
        private bool _toggleOnButtonClick = true;
        private bool _toggleOnSideClick = true;

        private MouseEventArgs _lastMouseEventArgs = null;

        private bool _buttonScaleImage;
        private Color _overlayColor = Color.DodgerBlue;
        private Color _borderColor = Color.LightGray;
        private Color _backColor = Color.White;
        private Color _buttonColor = Color.FromArgb(255, 235, 235, 235);
        private Color _buttonHoverColor = Color.FromArgb(255, 215, 215, 215);
        private Color _buttonPressedColor = Color.FromArgb(255, 195, 195, 195);

        #endregion Private Members

        #region Constructor Etc.

        public HaltroySwitch()
        {
            Startup startup = new Startup();
            SetStyle(ControlStyles.ResizeRedraw |
                        ControlStyles.SupportsTransparentBackColor |
                        ControlStyles.AllPaintingInWmPaint |
                        ControlStyles.UserPaint |
                        ControlStyles.OptimizedDoubleBuffer |
                        ControlStyles.DoubleBuffer, true);

            SetRenderer(new HaltroySwitchRenderer());

            _animationTimer.Enabled = false;
            _animationTimer.Interval = _animationInterval;
            _animationTimer.Tick += AnimationTimer_Tick;
        }

        public void SetRenderer(HaltroySwitchRendererBase renderer)
        {
            renderer.SetHaltroySwitch(this);
            _renderer = renderer;

            if (_renderer != null)
            {
                Refresh();
            }
        }

        #endregion Constructor Etc.

        #region Public Properties



        [Bindable(true)]
        [DefaultValue(false)]
        [Category("Data")]
        [Description("Gets or sets the Checked value of the HaltroySwitch")]
        public bool Checked
        {
            get => _checked;
            set
            {
                if (value != _checked)
                {
                    while (_animating)
                    {
                        Application.DoEvents();
                    }

                    if (value == true)
                    {
                        int buttonWidth = _renderer.GetButtonWidth();
                        _animationTarget = Width - buttonWidth;
                        BeginAnimation(true);
                    }
                    else
                    {
                        _animationTarget = 0;
                        BeginAnimation(false);
                    }
                }
            }
        }

        [Bindable(true)]
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("Gets or sets whether the user can change the value of the button or not")]
        public bool AllowUserChange
        {
            get => _allowUserChange;
            set => _allowUserChange = value;
        }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Rectangle ButtonRectangle => _renderer.GetButtonRectangle();

        [Bindable(false)]
        [DefaultValue(true)]
        [Category("Appearance")]
        [Description("Gets or sets if the HaltroySwitch should be grayed out when disabled")]
        public bool GrayWhenDisabled
        {
            get => _grayWhenDisabled;
            set
            {
                if (value != _grayWhenDisabled)
                {
                    _grayWhenDisabled = value;

                    if (!Enabled)
                    {
                        Refresh();
                    }
                }
            }
        }

        [Bindable(false)]
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("Gets or sets if the HaltroySwitch should toggle when the button is clicked")]
        public bool ToggleOnButtonClick
        {
            get => _toggleOnButtonClick;
            set => _toggleOnButtonClick = value;
        }

        [Bindable(false)]
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("Gets or sets if the HaltroySwitch should toggle when the track besides the button is clicked")]
        public bool ToggleOnSideClick
        {
            get => _toggleOnSideClick;
            set => _toggleOnSideClick = value;
        }

        [Bindable(false)]
        [DefaultValue(50)]
        [Category("Behavior")]
        [Description("Gets or sets how much the button need to be on the other side (in peercept) before it snaps")]
        public int ThresholdPercentage
        {
            get => _thresholdPercentage;
            set => _thresholdPercentage = value;
        }
        [Bindable(false)]
        [DefaultValue(typeof(Color), "DodgerBlue")]
        [Category("Appearance")]
        [Description("Gets or sets the back color when Checked = true")]
        public Color OverlayColor
        {
            get => _overlayColor;
            set
            {
                if (value != _overlayColor)
                {
                    _overlayColor = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(typeof(Color), "White")]
        [Category("Appearance")]
        [Description("Gets or sets the back color when Checked = false")]
        public override Color BackColor
        {
            get => _backColor;
            set
            {
                if (value != _backColor)
                {
                    _backColor = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(typeof(Color), "LightGray")]
        [Category("Appearance")]
        [Description("Gets or sets the back color when Checked = false")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (value != _borderColor)
                {
                    _borderColor = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(typeof(Color), "255, 235, 235, 235")]
        [Category("Appearance")]
        [Description("Gets or sets the back color of button.")]
        public Color ButtonColor
        {
            get => _buttonColor;
            set
            {
                if (value != _buttonColor)
                {
                    _buttonColor = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(typeof(Color), "255, 215, 215, 215")]
        [Category("Appearance")]
        [Description("Gets or sets the back color of button when hovered.")]
        public Color ButtonHoverColor
        {
            get => _buttonHoverColor;
            set
            {
                if (value != _buttonHoverColor)
                {
                    _buttonHoverColor = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(typeof(Color), "255, 195, 195, 195")]
        [Category("Appearance")]
        [Description("Gets or sets the back color of button when pressed.")]
        public Color ButtonPressedColor
        {
            get => _buttonPressedColor;
            set
            {
                if (value != _buttonPressedColor)
                {
                    _buttonPressedColor = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(false)]
        [Category("Behavior")]
        [Description("Gets or sets whether the button image should be scaled to fit")]
        public bool ButtonScaleImageToFit
        {
            get => _buttonScaleImage;
            set
            {
                if (value != _buttonScaleImage)
                {
                    _buttonScaleImage = value;
                    Refresh();
                }
            }
        }
        [Bindable(false)]
        [DefaultValue(true)]
        [Category("Behavior")]
        [Description("Gets or sets whether the toggle change should be animated or not")]
        public bool UseAnimation
        {
            get => _useAnimation;
            set => _useAnimation = value;
        }

        [Bindable(false)]
        [DefaultValue(1)]
        [Category("Behavior")]
        [Description("Gets or sets the interval in ms between animation frames")]
        public int AnimationInterval
        {
            get => _animationInterval;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("AnimationInterval must larger than zero!");
                }

                _animationInterval = value;
            }
        }

        [Bindable(false)]
        [DefaultValue(10)]
        [Category("Behavior")]
        [Description("Gets or sets the step in pixes the button shouldbe moved between each animation interval")]
        public int AnimationStep
        {
            get => _animationStep;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("AnimationStep must larger than zero!");
                }

                _animationStep = value;
            }
        }

        #region Hidden Base Properties

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new string Text
        {
            get => "";
            set => base.Text = "";
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Color ForeColor
        {
            get => Color.Black;
            set => base.ForeColor = Color.Black;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Font Font
        {
            get => base.Font;
            set => base.Font = new Font(base.Font, FontStyle.Regular);
        }

        #endregion Hidden Base Properties

        #endregion Public Properties

        #region Internal Properties

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsButtonHovered => _isButtonHovered && !_isButtonPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsButtonPressed => _isButtonPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsLeftSideHovered => _isLeftFieldHovered && !_isLeftFieldPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsLeftSidePressed => _isLeftFieldPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsRightSideHovered => _isRightFieldHovered && !_isRightFieldPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsRightSidePressed => _isRightFieldPressed;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal int ButtonValue
        {
            get
            {
                if (_animating || _moving)
                {
                    return _buttonValue;
                }
                else if (_checked)
                {
                    return Width - _renderer.GetButtonWidth();
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (value != _buttonValue)
                {
                    _buttonValue = value;
                    Refresh();
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsButtonOnLeftSide => (ButtonValue <= 0);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsButtonOnRightSide => (ButtonValue >= (Width - _renderer.GetButtonWidth()));

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsButtonMovingLeft => (_animating && !IsButtonOnLeftSide && _animationResult == false);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool IsButtonMovingRight => (_animating && !IsButtonOnRightSide && _animationResult == true);

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        internal bool AnimationResult => _animationResult;

        #endregion Private Properties

        #region Overridden Control Methods

        protected override Size DefaultSize => new Size(50, 19);

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            pevent.Graphics.ResetClip();

            base.OnPaintBackground(pevent);

            if (_renderer != null)
            {
                _renderer.RenderBackground(pevent);
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.ResetClip();

            base.OnPaint(e);

            if (_renderer != null)
            {
                _renderer.RenderControl(e);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            _lastMouseEventArgs = e;

            int buttonWidth = _renderer.GetButtonWidth();
            Rectangle buttonRectangle = _renderer.GetButtonRectangle(buttonWidth);

            if (_moving)
            {
                int val = _xValue + (e.Location.X - _xOffset);

                if (val < 0)
                {
                    val = 0;
                }

                if (val > Width - buttonWidth)
                {
                    val = Width - buttonWidth;
                }

                ButtonValue = val;
                Refresh();
                return;
            }

            if (buttonRectangle.Contains(e.Location))
            {
                _isButtonHovered = true;
                _isLeftFieldHovered = false;
                _isRightFieldHovered = false;
            }
            else
            {
                if (e.Location.X > buttonRectangle.X + buttonRectangle.Width)
                {
                    _isButtonHovered = false;
                    _isLeftFieldHovered = false;
                    _isRightFieldHovered = true;
                }
                else if (e.Location.X < buttonRectangle.X)
                {
                    _isButtonHovered = false;
                    _isLeftFieldHovered = true;
                    _isRightFieldHovered = false;
                }
            }

            Refresh();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (_animating || !AllowUserChange)
            {
                return;
            }

            int buttonWidth = _renderer.GetButtonWidth();
            Rectangle buttonRectangle = _renderer.GetButtonRectangle(buttonWidth);

            _savedButtonValue = ButtonValue;

            if (buttonRectangle.Contains(e.Location))
            {
                _isButtonPressed = true;
                _isLeftFieldPressed = false;
                _isRightFieldPressed = false;

                _moving = true;
                _xOffset = e.Location.X;
                _buttonValue = buttonRectangle.X;
                _xValue = ButtonValue;
            }
            else
            {
                if (e.Location.X > buttonRectangle.X + buttonRectangle.Width)
                {
                    _isButtonPressed = false;
                    _isLeftFieldPressed = false;
                    _isRightFieldPressed = true;
                }
                else if (e.Location.X < buttonRectangle.X)
                {
                    _isButtonPressed = false;
                    _isLeftFieldPressed = true;
                    _isRightFieldPressed = false;
                }
            }

            Refresh();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (_animating || !AllowUserChange)
            {
                return;
            }

            int buttonWidth = _renderer.GetButtonWidth();

            bool wasLeftSidePressed = IsLeftSidePressed;
            bool wasRightSidePressed = IsRightSidePressed;

            _isButtonPressed = false;
            _isLeftFieldPressed = false;
            _isRightFieldPressed = false;

            if (_moving)
            {
                int percentage = (int)((100 * (double)ButtonValue) / (Width - (double)buttonWidth));

                if (_checked)
                {
                    if (percentage <= (100 - _thresholdPercentage))
                    {
                        _animationTarget = 0;
                        BeginAnimation(false);
                    }
                    else if (ToggleOnButtonClick && _savedButtonValue == ButtonValue)
                    {
                        _animationTarget = 0;
                        BeginAnimation(false);
                    }
                    else
                    {
                        _animationTarget = Width - buttonWidth;
                        BeginAnimation(true);
                    }
                }
                else
                {
                    if (percentage >= _thresholdPercentage)
                    {
                        _animationTarget = Width - buttonWidth;
                        BeginAnimation(true);
                    }
                    else if (ToggleOnButtonClick && _savedButtonValue == ButtonValue)
                    {
                        _animationTarget = Width - buttonWidth;
                        BeginAnimation(true);
                    }
                    else
                    {
                        _animationTarget = 0;
                        BeginAnimation(false);
                    }
                }

                _moving = false;
                return;
            }

            if (IsButtonOnRightSide)
            {
                _buttonValue = Width - buttonWidth;
                _animationTarget = 0;
            }
            else
            {
                _buttonValue = 0;
                _animationTarget = Width - buttonWidth;
            }

            if (wasLeftSidePressed && ToggleOnSideClick)
            {
                SetValueInternal(false);
            }
            else if (wasRightSidePressed && ToggleOnSideClick)
            {
                SetValueInternal(true);
            }

            Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _isButtonHovered = false;
            _isLeftFieldHovered = false;
            _isRightFieldHovered = false;
            _isButtonPressed = false;
            _isLeftFieldPressed = false;
            _isRightFieldPressed = false;

            Refresh();
        }

        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            Refresh();
        }

        protected override void OnRegionChanged(EventArgs e)
        {
            base.OnRegionChanged(e);
            Refresh();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (_animationTarget > 0)
            {
                int buttonWidth = _renderer.GetButtonWidth();
                _animationTarget = Width - buttonWidth;
            }

            base.OnSizeChanged(e);
        }

        #endregion Overridden Control Methods

        #region Private Methods

        private void SetValueInternal(bool checkedValue)
        {
            if (checkedValue == _checked)
            {
                return;
            }

            while (_animating)
            {
                Application.DoEvents();
            }

            BeginAnimation(checkedValue);
        }

        private void BeginAnimation(bool checkedValue)
        {
            _animating = true;
            _animationResult = checkedValue;

            if (_animationTimer != null && _useAnimation)
            {
                _animationTimer.Interval = _animationInterval;
                _animationTimer.Enabled = true;
            }
            else
            {
                AnimationComplete();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            _animationTimer.Enabled = false;

            bool animationDone = false;
            int newButtonValue;

            if (IsButtonMovingRight)
            {
                newButtonValue = ButtonValue + _animationStep;

                if (newButtonValue > _animationTarget)
                {
                    newButtonValue = _animationTarget;
                }

                ButtonValue = newButtonValue;

                animationDone = ButtonValue >= _animationTarget;
            }
            else
            {
                newButtonValue = ButtonValue - _animationStep;

                if (newButtonValue < _animationTarget)
                {
                    newButtonValue = _animationTarget;
                }

                ButtonValue = newButtonValue;

                animationDone = ButtonValue <= _animationTarget;
            }

            if (animationDone)
            {
                AnimationComplete();
            }
            else
            {
                _animationTimer.Enabled = true;
            }
        }

        private void AnimationComplete()
        {
            _animating = false;
            _moving = false;
            _checked = _animationResult;

            _isButtonHovered = false;
            _isButtonPressed = false;
            _isLeftFieldHovered = false;
            _isLeftFieldPressed = false;
            _isRightFieldHovered = false;
            _isRightFieldPressed = false;

            Refresh();

            if (CheckedChanged != null)
            {
                CheckedChanged(this, new EventArgs());
            }

            if (_lastMouseEventArgs != null)
            {
                OnMouseMove(_lastMouseEventArgs);
            }

            _lastMouseEventArgs = null;
        }

        #endregion Private Methods
    }
}