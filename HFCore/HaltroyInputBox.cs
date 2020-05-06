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
using System.Drawing;
using System.Windows.Forms;

namespace HTAlt
{
    /// <summary>
    /// Customizable Input Box.
    /// </summary>
    public partial class HTInputBox : Form
    {
        /// <summary>
        /// Background color of HaltroyMsgBox. Foreground color is auto-selected to White or Black.
        /// </summary>
        public Color BackgroundColor;
        /// <summary>
        /// Text to display on "OK" button.
        /// </summary>
        public string OK = "OK";
        /// <summary>
        /// Text to display on "Cancel" button.
        /// </summary>
        public string Cancel = "Cancel";
        /// <summary>
        /// Text to display on "Set to default" button.
        /// </summary>
        public string SetToDefault = "Set to default";
        private string defaultString = "";

        private static int LinesCountIndexOf(string s)
        {
            int count = 0;
            int position = 0;
            while ((position = s.IndexOf('\n', position)) != -1)
            {
                count++;
                position++;
            }
            return count;
        }
        /// <summary>
        /// Creates a new Input Box.
        /// </summary>
        /// <param name="title">Title of the input box.</param>
        /// <param name="description">Description of the input box.</param>
        /// <param name="defaultValue">Default value of the input box.</param>
        public HTInputBox(string title,
                               string description,
                               string defaultValue = "")
        {
            Startup start = new Startup();
            InitializeComponent();
            defaultString = defaultValue;
            Text = title;
            label1.Text = description;
            Height = (15 * LinesCountIndexOf(description)) + 95;
            MaximumSize = new Size(Screen.FromHandle(Handle).WorkingArea.Width, Screen.FromHandle(Handle).WorkingArea.Height);
            textBox1.Text = defaultString;
            BackgroundColor = Color.White;
            button1.Text = OK;
            button2.Text = Cancel;
        }
        /// <summary>
        /// Value inside the textbox in this input box.
        /// </summary>
        public string TextValue => textBox1.Text;
        #region "MathBox"
        private static int Brightness(Color c)
        {
            return (int)Math.Sqrt(
               c.R * c.R * .241 +
               c.G * c.G * .691 +
               c.B * c.B * .068);
        }
        private static bool isBright(Color c)
        {
            return Brightness(c) > 130;
        }
        private static int GerekiyorsaAzalt(int defaultint, int azaltma)
        {
            return defaultint > azaltma ? defaultint - azaltma : defaultint;
        }
        private static int GerekiyorsaArttır(int defaultint, int arttırma, int sınır)
        {
            return defaultint + arttırma > sınır ? defaultint : defaultint + arttırma;
        }
        private static Color ShiftBrightnessIfNeeded(Color baseColor, int value, bool shiftAlpha)
        {
            if (isBright(baseColor))
            {
                return Color.FromArgb(shiftAlpha ? GerekiyorsaAzalt(baseColor.A, value) : baseColor.A,
                                      GerekiyorsaAzalt(baseColor.R, value),
                                      GerekiyorsaAzalt(baseColor.G, value),
                                      GerekiyorsaAzalt(baseColor.B, value));
            }
            else
            {
                return Color.FromArgb(shiftAlpha ? GerekiyorsaArttır(baseColor.A, value, 255) : baseColor.A,
                      GerekiyorsaArttır(baseColor.R, value, 255),
                      GerekiyorsaArttır(baseColor.G, value, 255),
                      GerekiyorsaArttır(baseColor.B, value, 255));
            }
        }
        #endregion

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Text = OK;
            button2.Text = Cancel;
            haltroyButton1.Text = SetToDefault;
            ForeColor = isBright(BackgroundColor) ? Color.Black : Color.White;
            BackColor = BackgroundColor;
            button1.ForeColor = isBright(BackgroundColor) ? Color.Black : Color.White;
            button1.BackColor = ShiftBrightnessIfNeeded(BackgroundColor, 20, false);
            button2.BackColor = ShiftBrightnessIfNeeded(BackgroundColor, 20, false);
            haltroyButton1.BackColor = ShiftBrightnessIfNeeded(BackgroundColor, 20, false);
            button2.ForeColor = isBright(BackgroundColor) ? Color.Black : Color.White;
            haltroyButton1.ForeColor = isBright(BackgroundColor) ? Color.Black : Color.White;
            textBox1.ForeColor = isBright(BackgroundColor) ? Color.Black : Color.White;
            textBox1.BackColor = ShiftBrightnessIfNeeded(BackgroundColor, 20, false);
        }

        private void haltroyButton1_Click(object sender, EventArgs e)
        {
            textBox1.Text = defaultString;
        }
    }
}
