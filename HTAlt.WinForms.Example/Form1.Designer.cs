﻿using HTAlt.WinForms;
using System.Drawing;

namespace HTAlt.WinForms.Example
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Test");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HTTabControl1 = new HTAlt.WinForms.HTTabControl();
            this.tpBoxes = new System.Windows.Forms.TabPage();
            this.nudBorder = new System.Windows.Forms.NumericUpDown();
            this.nudVal = new System.Windows.Forms.NumericUpDown();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lbBorder = new System.Windows.Forms.Label();
            this.lbVal = new System.Windows.Forms.Label();
            this.lbMax = new System.Windows.Forms.Label();
            this.lbMin = new System.Windows.Forms.Label();
            this.hsForeColor = new HTAlt.WinForms.HTSwitch();
            this.hsBorder = new HTAlt.WinForms.HTSwitch();
            this.hsPBar = new HTAlt.WinForms.HTSwitch();
            this.label27 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsRetry = new HTAlt.WinForms.HTSwitch();
            this.hsCancel = new HTAlt.WinForms.HTSwitch();
            this.hsOK = new HTAlt.WinForms.HTSwitch();
            this.hsNo = new HTAlt.WinForms.HTSwitch();
            this.hsYes = new HTAlt.WinForms.HTSwitch();
            this.hsIgnore = new HTAlt.WinForms.HTSwitch();
            this.hsDefault = new HTAlt.WinForms.HTSwitch();
            this.hsAbort = new HTAlt.WinForms.HTSwitch();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ibResult = new System.Windows.Forms.Label();
            this.ibResultTitle = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.ibDefault = new System.Windows.Forms.TextBox();
            this.ibSetToDefault = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pbOverlayColor = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pbForeColor = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pbBackColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.tbIcon = new System.Windows.Forms.TextBox();
            this.tbCancel = new System.Windows.Forms.TextBox();
            this.tbOK = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbIgnore = new System.Windows.Forms.TextBox();
            this.tbAbort = new System.Windows.Forms.TextBox();
            this.tbRetry = new System.Windows.Forms.TextBox();
            this.tbYes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tpControl1 = new System.Windows.Forms.TabPage();
            this.htButton1 = new HTAlt.WinForms.HTButton();
            this.htProgressBar5 = new HTAlt.WinForms.HTProgressBar();
            this.HTListView2 = new HTAlt.WinForms.HTListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sliderValue = new System.Windows.Forms.Label();
            this.HTSwitch1 = new HTAlt.WinForms.HTSwitch();
            this.HTSlider1 = new HTAlt.WinForms.HTSlider();
            this.tpTools = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pbValidUrl = new System.Windows.Forms.PictureBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.hbRandom = new HTAlt.WinForms.HTButton();
            this.lbRandom = new System.Windows.Forms.Label();
            this.nudRandom = new System.Windows.Forms.NumericUpDown();
            this.HTTabControl1.SuspendLayout();
            this.tpBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlayColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            this.tpControl1.SuspendLayout();
            this.tpTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidUrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // HTTabControl1
            // 
            this.HTTabControl1.AllowDrop = true;
            this.HTTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.HTTabControl1.BorderTabLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HTTabControl1.Controls.Add(this.tpBoxes);
            this.HTTabControl1.Controls.Add(this.tpControl1);
            this.HTTabControl1.Controls.Add(this.tpTools);
            this.HTTabControl1.DisableClose = false;
            this.HTTabControl1.DisableDragging = false;
            this.HTTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HTTabControl1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HTTabControl1.HoverTabButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(176)))), ((int)(((byte)(239)))));
            this.HTTabControl1.HoverTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.HTTabControl1.HoverUnselectedTabButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.HTTabControl1.ItemSize = new System.Drawing.Size(240, 16);
            this.HTTabControl1.Location = new System.Drawing.Point(0, 0);
            this.HTTabControl1.Name = "HTTabControl1";
            this.HTTabControl1.Padding = new System.Drawing.Point(14, 4);
            this.HTTabControl1.SelectedIndex = 0;
            this.HTTabControl1.SelectedTabButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(151)))), ((int)(((byte)(234)))));
            this.HTTabControl1.SelectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HTTabControl1.Size = new System.Drawing.Size(800, 450);
            this.HTTabControl1.TabIndex = 0;
            this.HTTabControl1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.HTTabControl1.UnderBorderTabLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(67)))), ((int)(((byte)(70)))));
            this.HTTabControl1.UnselectedBorderTabLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.HTTabControl1.UnselectedTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.HTTabControl1.UpDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.HTTabControl1.UpDownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(112)))));
            // 
            // tpBoxes
            // 
            this.tpBoxes.Controls.Add(this.nudBorder);
            this.tpBoxes.Controls.Add(this.nudVal);
            this.tpBoxes.Controls.Add(this.nudMax);
            this.tpBoxes.Controls.Add(this.nudMin);
            this.tpBoxes.Controls.Add(this.lbBorder);
            this.tpBoxes.Controls.Add(this.lbVal);
            this.tpBoxes.Controls.Add(this.lbMax);
            this.tpBoxes.Controls.Add(this.lbMin);
            this.tpBoxes.Controls.Add(this.hsForeColor);
            this.tpBoxes.Controls.Add(this.hsBorder);
            this.tpBoxes.Controls.Add(this.hsPBar);
            this.tpBoxes.Controls.Add(this.label27);
            this.tpBoxes.Controls.Add(this.label15);
            this.tpBoxes.Controls.Add(this.label3);
            this.tpBoxes.Controls.Add(this.hsRetry);
            this.tpBoxes.Controls.Add(this.hsCancel);
            this.tpBoxes.Controls.Add(this.hsOK);
            this.tpBoxes.Controls.Add(this.hsNo);
            this.tpBoxes.Controls.Add(this.hsYes);
            this.tpBoxes.Controls.Add(this.hsIgnore);
            this.tpBoxes.Controls.Add(this.hsDefault);
            this.tpBoxes.Controls.Add(this.hsAbort);
            this.tpBoxes.Controls.Add(this.label16);
            this.tpBoxes.Controls.Add(this.label20);
            this.tpBoxes.Controls.Add(this.label19);
            this.tpBoxes.Controls.Add(this.ibResult);
            this.tpBoxes.Controls.Add(this.ibResultTitle);
            this.tpBoxes.Controls.Add(this.button8);
            this.tpBoxes.Controls.Add(this.button4);
            this.tpBoxes.Controls.Add(this.button6);
            this.tpBoxes.Controls.Add(this.ibDefault);
            this.tpBoxes.Controls.Add(this.ibSetToDefault);
            this.tpBoxes.Controls.Add(this.label22);
            this.tpBoxes.Controls.Add(this.label12);
            this.tpBoxes.Controls.Add(this.lResult);
            this.tpBoxes.Controls.Add(this.label10);
            this.tpBoxes.Controls.Add(this.pbOverlayColor);
            this.tpBoxes.Controls.Add(this.label17);
            this.tpBoxes.Controls.Add(this.pbForeColor);
            this.tpBoxes.Controls.Add(this.label21);
            this.tpBoxes.Controls.Add(this.pbBackColor);
            this.tpBoxes.Controls.Add(this.label5);
            this.tpBoxes.Controls.Add(this.label24);
            this.tpBoxes.Controls.Add(this.label4);
            this.tpBoxes.Controls.Add(this.tbImage);
            this.tpBoxes.Controls.Add(this.tbMessage);
            this.tpBoxes.Controls.Add(this.tbIcon);
            this.tpBoxes.Controls.Add(this.tbCancel);
            this.tpBoxes.Controls.Add(this.tbOK);
            this.tpBoxes.Controls.Add(this.tbNo);
            this.tpBoxes.Controls.Add(this.label9);
            this.tpBoxes.Controls.Add(this.tbIgnore);
            this.tpBoxes.Controls.Add(this.tbAbort);
            this.tpBoxes.Controls.Add(this.tbRetry);
            this.tpBoxes.Controls.Add(this.tbYes);
            this.tpBoxes.Controls.Add(this.label8);
            this.tpBoxes.Controls.Add(this.tbTitle);
            this.tpBoxes.Controls.Add(this.label7);
            this.tpBoxes.Controls.Add(this.label2);
            this.tpBoxes.Controls.Add(this.label14);
            this.tpBoxes.Controls.Add(this.label13);
            this.tpBoxes.Controls.Add(this.label11);
            this.tpBoxes.Controls.Add(this.label6);
            this.tpBoxes.Controls.Add(this.label1);
            this.tpBoxes.Controls.Add(this.button5);
            this.tpBoxes.Controls.Add(this.button2);
            this.tpBoxes.Controls.Add(this.button3);
            this.tpBoxes.Controls.Add(this.button1);
            this.tpBoxes.Location = new System.Drawing.Point(4, 20);
            this.tpBoxes.Name = "tpBoxes";
            this.tpBoxes.Padding = new System.Windows.Forms.Padding(3);
            this.tpBoxes.Size = new System.Drawing.Size(792, 426);
            this.tpBoxes.TabIndex = 0;
            this.tpBoxes.Text = "Dialog Boxes";
            this.tpBoxes.UseVisualStyleBackColor = true;
            // 
            // nudBorder
            // 
            this.nudBorder.Location = new System.Drawing.Point(236, 314);
            this.nudBorder.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudBorder.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudBorder.Name = "nudBorder";
            this.nudBorder.Size = new System.Drawing.Size(52, 23);
            this.nudBorder.TabIndex = 40;
            // 
            // nudVal
            // 
            this.nudVal.Location = new System.Drawing.Point(69, 314);
            this.nudVal.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudVal.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudVal.Name = "nudVal";
            this.nudVal.Size = new System.Drawing.Size(80, 23);
            this.nudVal.TabIndex = 39;
            this.nudVal.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudMax
            // 
            this.nudMax.Location = new System.Drawing.Point(195, 284);
            this.nudMax.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudMax.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(93, 23);
            this.nudMax.TabIndex = 38;
            this.nudMax.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(69, 284);
            this.nudMin.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudMin.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(80, 23);
            this.nudMin.TabIndex = 37;
            // 
            // lbBorder
            // 
            this.lbBorder.AutoSize = true;
            this.lbBorder.Location = new System.Drawing.Point(155, 316);
            this.lbBorder.Name = "lbBorder";
            this.lbBorder.Size = new System.Drawing.Size(68, 15);
            this.lbBorder.TabIndex = 36;
            this.lbBorder.Text = "Border Size:";
            // 
            // lbVal
            // 
            this.lbVal.AutoSize = true;
            this.lbVal.Location = new System.Drawing.Point(22, 316);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(38, 15);
            this.lbVal.TabIndex = 35;
            this.lbVal.Text = "Value:";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(155, 286);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(33, 15);
            this.lbMax.TabIndex = 34;
            this.lbMax.Text = "Max:";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(22, 286);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(31, 15);
            this.lbMin.TabIndex = 34;
            this.lbMin.Text = "Min:";
            // 
            // hsForeColor
            // 
            this.hsForeColor.Location = new System.Drawing.Point(519, 99);
            this.hsForeColor.Name = "hsForeColor";
            this.hsForeColor.Size = new System.Drawing.Size(50, 19);
            this.hsForeColor.TabIndex = 33;
            // 
            // hsBorder
            // 
            this.hsBorder.Location = new System.Drawing.Point(110, 350);
            this.hsBorder.Name = "hsBorder";
            this.hsBorder.Size = new System.Drawing.Size(50, 19);
            this.hsBorder.TabIndex = 33;
            // 
            // hsPBar
            // 
            this.hsPBar.Location = new System.Drawing.Point(139, 252);
            this.hsPBar.Name = "hsPBar";
            this.hsPBar.Size = new System.Drawing.Size(50, 19);
            this.hsPBar.TabIndex = 33;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(425, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(88, 15);
            this.label27.TabIndex = 32;
            this.label27.Text = "AutoForeColor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 15);
            this.label15.TabIndex = 32;
            this.label15.Text = "Draw Border:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Show Progress Bar:";
            // 
            // hsRetry
            // 
            this.hsRetry.Location = new System.Drawing.Point(305, 260);
            this.hsRetry.Name = "hsRetry";
            this.hsRetry.Size = new System.Drawing.Size(50, 19);
            this.hsRetry.TabIndex = 31;
            // 
            // hsCancel
            // 
            this.hsCancel.Location = new System.Drawing.Point(305, 235);
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.Size = new System.Drawing.Size(50, 19);
            this.hsCancel.TabIndex = 31;
            // 
            // hsOK
            // 
            this.hsOK.Location = new System.Drawing.Point(305, 210);
            this.hsOK.Name = "hsOK";
            this.hsOK.Size = new System.Drawing.Size(50, 19);
            this.hsOK.TabIndex = 31;
            // 
            // hsNo
            // 
            this.hsNo.Location = new System.Drawing.Point(305, 185);
            this.hsNo.Name = "hsNo";
            this.hsNo.Size = new System.Drawing.Size(50, 19);
            this.hsNo.TabIndex = 31;
            // 
            // hsYes
            // 
            this.hsYes.Location = new System.Drawing.Point(304, 160);
            this.hsYes.Name = "hsYes";
            this.hsYes.Size = new System.Drawing.Size(50, 19);
            this.hsYes.TabIndex = 31;
            // 
            // hsIgnore
            // 
            this.hsIgnore.Location = new System.Drawing.Point(305, 310);
            this.hsIgnore.Name = "hsIgnore";
            this.hsIgnore.Size = new System.Drawing.Size(50, 19);
            this.hsIgnore.TabIndex = 31;
            // 
            // hsDefault
            // 
            this.hsDefault.Location = new System.Drawing.Point(305, 335);
            this.hsDefault.Name = "hsDefault";
            this.hsDefault.Size = new System.Drawing.Size(50, 19);
            this.hsDefault.TabIndex = 31;
            // 
            // hsAbort
            // 
            this.hsAbort.Location = new System.Drawing.Point(304, 285);
            this.hsAbort.Name = "hsAbort";
            this.hsAbort.Size = new System.Drawing.Size(50, 19);
            this.hsAbort.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(595, 263);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 15);
            this.label16.TabIndex = 30;
            this.label16.Text = "HTProgressBox:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(595, 154);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 15);
            this.label20.TabIndex = 30;
            this.label20.Text = "HTInputBox:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(592, 35);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 15);
            this.label19.TabIndex = 30;
            this.label19.Text = "HTMsgBox:";
            // 
            // ibResult
            // 
            this.ibResult.AutoSize = true;
            this.ibResult.Location = new System.Drawing.Point(595, 219);
            this.ibResult.Name = "ibResult";
            this.ibResult.Size = new System.Drawing.Size(69, 15);
            this.ibResult.TabIndex = 29;
            this.ibResult.Text = "<no result>";
            this.ibResult.Visible = false;
            // 
            // ibResultTitle
            // 
            this.ibResultTitle.AutoSize = true;
            this.ibResultTitle.Location = new System.Drawing.Point(595, 200);
            this.ibResultTitle.Name = "ibResultTitle";
            this.ibResultTitle.Size = new System.Drawing.Size(42, 15);
            this.ibResultTitle.TabIndex = 28;
            this.ibResultTitle.Text = "Result:";
            this.ibResultTitle.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(691, 260);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Show";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(676, 173);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Show Dialog";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(595, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 26;
            this.button6.Text = "Show";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ibDefault
            // 
            this.ibDefault.Location = new System.Drawing.Point(21, 188);
            this.ibDefault.Multiline = true;
            this.ibDefault.Name = "ibDefault";
            this.ibDefault.Size = new System.Drawing.Size(268, 45);
            this.ibDefault.TabIndex = 20;
            // 
            // ibSetToDefault
            // 
            this.ibSetToDefault.Location = new System.Drawing.Point(305, 360);
            this.ibSetToDefault.Name = "ibSetToDefault";
            this.ibSetToDefault.Size = new System.Drawing.Size(265, 23);
            this.ibSetToDefault.TabIndex = 21;
            this.ibSetToDefault.Text = "Set to default";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 15);
            this.label22.TabIndex = 18;
            this.label22.Text = "Default Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 337);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "\"Set to default\" Button Text:";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(595, 100);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(69, 15);
            this.lResult.TabIndex = 8;
            this.lResult.Text = "<no result>";
            this.lResult.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "Result:";
            this.label10.Visible = false;
            // 
            // pbOverlayColor
            // 
            this.pbOverlayColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbOverlayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOverlayColor.Location = new System.Drawing.Point(535, 60);
            this.pbOverlayColor.Name = "pbOverlayColor";
            this.pbOverlayColor.Size = new System.Drawing.Size(30, 30);
            this.pbOverlayColor.TabIndex = 6;
            this.pbOverlayColor.TabStop = false;
            this.pbOverlayColor.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(434, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 15);
            this.label17.TabIndex = 5;
            this.label17.Text = "OverlayColor:";
            // 
            // pbForeColor
            // 
            this.pbForeColor.BackColor = System.Drawing.Color.Black;
            this.pbForeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbForeColor.Location = new System.Drawing.Point(386, 93);
            this.pbForeColor.Name = "pbForeColor";
            this.pbForeColor.Size = new System.Drawing.Size(30, 30);
            this.pbForeColor.TabIndex = 6;
            this.pbForeColor.TabStop = false;
            this.pbForeColor.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(312, 100);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 15);
            this.label21.TabIndex = 5;
            this.label21.Text = "ForeColor:";
            // 
            // pbBackColor
            // 
            this.pbBackColor.BackColor = System.Drawing.Color.White;
            this.pbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackColor.Location = new System.Drawing.Point(386, 60);
            this.pbBackColor.Name = "pbBackColor";
            this.pbBackColor.Size = new System.Drawing.Size(30, 30);
            this.pbBackColor.TabIndex = 6;
            this.pbBackColor.TabStop = false;
            this.pbBackColor.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "BackColor:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(311, 132);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(43, 15);
            this.label24.TabIndex = 5;
            this.label24.Text = "Image:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Icon:";
            // 
            // tbImage
            // 
            this.tbImage.Location = new System.Drawing.Point(360, 129);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(177, 23);
            this.tbImage.TabIndex = 3;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(21, 70);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(268, 93);
            this.tbMessage.TabIndex = 3;
            this.tbMessage.Text = "This is a test message!";
            // 
            // tbIcon
            // 
            this.tbIcon.Location = new System.Drawing.Point(313, 31);
            this.tbIcon.Name = "tbIcon";
            this.tbIcon.Size = new System.Drawing.Size(224, 23);
            this.tbIcon.TabIndex = 3;
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(485, 234);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(85, 23);
            this.tbCancel.TabIndex = 3;
            this.tbCancel.Text = "Cancel";
            // 
            // tbOK
            // 
            this.tbOK.Location = new System.Drawing.Point(465, 210);
            this.tbOK.Name = "tbOK";
            this.tbOK.Size = new System.Drawing.Size(105, 23);
            this.tbOK.TabIndex = 3;
            this.tbOK.Text = "OK";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(463, 185);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(107, 23);
            this.tbNo.TabIndex = 3;
            this.tbNo.Text = "No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(358, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cancel Button Text:";
            // 
            // tbIgnore
            // 
            this.tbIgnore.Location = new System.Drawing.Point(481, 307);
            this.tbIgnore.Name = "tbIgnore";
            this.tbIgnore.Size = new System.Drawing.Size(89, 23);
            this.tbIgnore.TabIndex = 3;
            this.tbIgnore.Text = "Ignore";
            // 
            // tbAbort
            // 
            this.tbAbort.Location = new System.Drawing.Point(481, 283);
            this.tbAbort.Name = "tbAbort";
            this.tbAbort.Size = new System.Drawing.Size(89, 23);
            this.tbAbort.TabIndex = 3;
            this.tbAbort.Text = "Abort";
            // 
            // tbRetry
            // 
            this.tbRetry.Location = new System.Drawing.Point(481, 258);
            this.tbRetry.Name = "tbRetry";
            this.tbRetry.Size = new System.Drawing.Size(89, 23);
            this.tbRetry.TabIndex = 3;
            this.tbRetry.Text = "Retry";
            // 
            // tbYes
            // 
            this.tbYes.Location = new System.Drawing.Point(466, 159);
            this.tbYes.Name = "tbYes";
            this.tbYes.Size = new System.Drawing.Size(104, 23);
            this.tbYes.TabIndex = 3;
            this.tbYes.Text = "Yes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(361, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "OK Button Text:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(21, 31);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(268, 23);
            this.tbTitle.TabIndex = 3;
            this.tbTitle.Text = "Hi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "No Button Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(358, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ignore Button Text:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(358, 286);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "Abort Button Text:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 261);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Retry Button Text:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(358, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yes Button Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(535, 129);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 24);
            this.button5.TabIndex = 1;
            this.button5.Text = "...";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(535, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 24);
            this.button3.TabIndex = 1;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(595, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tpControl1
            // 
            this.tpControl1.Controls.Add(this.htButton1);
            this.tpControl1.Controls.Add(this.htProgressBar5);
            this.tpControl1.Controls.Add(this.HTListView2);
            this.tpControl1.Controls.Add(this.sliderValue);
            this.tpControl1.Controls.Add(this.HTSwitch1);
            this.tpControl1.Controls.Add(this.HTSlider1);
            this.tpControl1.Location = new System.Drawing.Point(4, 20);
            this.tpControl1.Name = "tpControl1";
            this.tpControl1.Padding = new System.Windows.Forms.Padding(3);
            this.tpControl1.Size = new System.Drawing.Size(792, 426);
            this.tpControl1.TabIndex = 1;
            this.tpControl1.Text = "Slider & Switch & ListView";
            this.tpControl1.UseVisualStyleBackColor = true;
            // 
            // htButton1
            // 
            this.htButton1.ButtonImage = null;
            this.htButton1.ButtonShape = HTAlt.WinForms.HTButton.ButtonShapes.Rectangle;
            this.htButton1.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.htButton1.DrawImage = false;
            this.htButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.htButton1.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.htButton1.Location = new System.Drawing.Point(8, 65);
            this.htButton1.Name = "htButton1";
            this.htButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.htButton1.Size = new System.Drawing.Size(124, 49);
            this.htButton1.TabIndex = 16;
            this.htButton1.Text = "Sample Text";
            // 
            // htProgressBar5
            // 
            this.htProgressBar5.BorderThickness = 2;
            this.htProgressBar5.DrawBorder = true;
            this.htProgressBar5.Location = new System.Drawing.Point(8, 38);
            this.htProgressBar5.Name = "htProgressBar5";
            this.htProgressBar5.Size = new System.Drawing.Size(274, 10);
            this.htProgressBar5.TabIndex = 14;
            this.htProgressBar5.Text = "label19";
            this.htProgressBar5.Value = 34;
            // 
            // HTListView2
            // 
            this.HTListView2.BackColor = System.Drawing.Color.Black;
            this.HTListView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HTListView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.HTListView2.ForeColor = System.Drawing.Color.White;
            this.HTListView2.HeaderBackColor = System.Drawing.Color.Black;
            this.HTListView2.HeaderBorderThickness = 3;
            this.HTListView2.HeaderForeColor = System.Drawing.Color.White;
            this.HTListView2.HideSelection = false;
            this.HTListView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.HTListView2.Location = new System.Drawing.Point(8, 120);
            this.HTListView2.Name = "HTListView2";
            this.HTListView2.OverlayColor = System.Drawing.Color.DodgerBlue;
            this.HTListView2.Size = new System.Drawing.Size(777, 300);
            this.HTListView2.TabIndex = 3;
            this.HTListView2.UseCompatibleStateImageBehavior = false;
            this.HTListView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Test";
            this.columnHeader1.Width = 122;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Test";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 188;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Test";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 463;
            // 
            // sliderValue
            // 
            this.sliderValue.AutoSize = true;
            this.sliderValue.Location = new System.Drawing.Point(232, 12);
            this.sliderValue.Name = "sliderValue";
            this.sliderValue.Size = new System.Drawing.Size(51, 15);
            this.sliderValue.TabIndex = 2;
            this.sliderValue.Text = "<value>";
            // 
            // HTSwitch1
            // 
            this.HTSwitch1.Location = new System.Drawing.Point(158, 77);
            this.HTSwitch1.Name = "HTSwitch1";
            this.HTSwitch1.Size = new System.Drawing.Size(50, 19);
            this.HTSwitch1.TabIndex = 1;
            // 
            // HTSlider1
            // 
            this.HTSlider1.BackColor = System.Drawing.Color.White;
            this.HTSlider1.BorderRoundRectSize = new System.Drawing.Size(8, 8);
            this.HTSlider1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.HTSlider1.ForeColor = System.Drawing.Color.Black;
            this.HTSlider1.LargeChange = ((uint)(5u));
            this.HTSlider1.Location = new System.Drawing.Point(8, 6);
            this.HTSlider1.Name = "HTSlider1";
            this.HTSlider1.OverlayColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(157)))), ((int)(((byte)(204)))));
            this.HTSlider1.Size = new System.Drawing.Size(200, 26);
            this.HTSlider1.SmallChange = ((uint)(1u));
            this.HTSlider1.TabIndex = 0;
            this.HTSlider1.Text = "HTSlider1";
            this.HTSlider1.ThumbRoundRectSize = new System.Drawing.Size(16, 16);
            this.HTSlider1.ThumbSize = new System.Drawing.Size(16, 16);
            this.HTSlider1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.HTSlider1_Scroll);
            // 
            // tpTools
            // 
            this.tpTools.BackColor = System.Drawing.Color.White;
            this.tpTools.Controls.Add(this.textBox2);
            this.tpTools.Controls.Add(this.checkBox1);
            this.tpTools.Controls.Add(this.pbValidUrl);
            this.tpTools.Controls.Add(this.label26);
            this.tpTools.Controls.Add(this.label25);
            this.tpTools.Controls.Add(this.textBox1);
            this.tpTools.Controls.Add(this.label23);
            this.tpTools.Controls.Add(this.label18);
            this.tpTools.Controls.Add(this.hbRandom);
            this.tpTools.Controls.Add(this.lbRandom);
            this.tpTools.Controls.Add(this.nudRandom);
            this.tpTools.Location = new System.Drawing.Point(4, 20);
            this.tpTools.Name = "tpTools";
            this.tpTools.Size = new System.Drawing.Size(792, 426);
            this.tpTools.TabIndex = 4;
            this.tpTools.Text = "Tools";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(11, 269);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(166, 149);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "korot;";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 229);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(105, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "ignore defaults";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // pbValidUrl
            // 
            this.pbValidUrl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbValidUrl.Location = new System.Drawing.Point(9, 165);
            this.pbValidUrl.Name = "pbValidUrl";
            this.pbValidUrl.Size = new System.Drawing.Size(23, 23);
            this.pbValidUrl.TabIndex = 6;
            this.pbValidUrl.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 251);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(135, 15);
            this.label26.TabIndex = 5;
            this.label26.Text = "Protocols (divide with ; )";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 202);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 15);
            this.label25.TabIndex = 5;
            this.label25.Text = "Red: false , Green: true";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label23.Location = new System.Drawing.Point(7, 142);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "Valid Url";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(7, 14);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "Generate Random Text";
            // 
            // hbRandom
            // 
            this.hbRandom.ButtonImage = null;
            this.hbRandom.ButtonShape = HTAlt.WinForms.HTButton.ButtonShapes.Rectangle;
            this.hbRandom.ClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.hbRandom.DrawImage = false;
            this.hbRandom.ForeColor = System.Drawing.Color.Black;
            this.hbRandom.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.hbRandom.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.None;
            this.hbRandom.Location = new System.Drawing.Point(11, 77);
            this.hbRandom.Name = "hbRandom";
            this.hbRandom.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.hbRandom.Size = new System.Drawing.Size(158, 34);
            this.hbRandom.TabIndex = 2;
            this.hbRandom.Text = "Generate Text";
            this.hbRandom.Click += new System.EventHandler(this.hbRandom_Click);
            // 
            // lbRandom
            // 
            this.lbRandom.AutoSize = true;
            this.lbRandom.Location = new System.Drawing.Point(8, 114);
            this.lbRandom.Name = "lbRandom";
            this.lbRandom.Size = new System.Drawing.Size(85, 15);
            this.lbRandom.TabIndex = 1;
            this.lbRandom.Text = "<randomtext>";
            // 
            // nudRandom
            // 
            this.nudRandom.Location = new System.Drawing.Point(11, 48);
            this.nudRandom.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.nudRandom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRandom.Name = "nudRandom";
            this.nudRandom.Size = new System.Drawing.Size(158, 23);
            this.nudRandom.TabIndex = 0;
            this.nudRandom.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HTTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "HTAlt Test App";
            this.HTTabControl1.ResumeLayout(false);
            this.tpBoxes.ResumeLayout(false);
            this.tpBoxes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlayColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForeColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            this.tpControl1.ResumeLayout(false);
            this.tpControl1.PerformLayout();
            this.tpTools.ResumeLayout(false);
            this.tpTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbValidUrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRandom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HTAlt.WinForms.HTTabControl HTTabControl1;
        private System.Windows.Forms.TabPage tpBoxes;
        private System.Windows.Forms.TabPage tpControl1;
        private HTAlt.WinForms.HTSwitch HTSwitch1;
        private HTAlt.WinForms.HTSlider HTSlider1;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIcon;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbBackColor;
        private System.Windows.Forms.TextBox tbOK;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbCancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label sliderValue;
        private HTAlt.WinForms.HTListView HTListView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label ibResult;
        private System.Windows.Forms.Label ibResultTitle;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox ibDefault;
        private System.Windows.Forms.TextBox ibSetToDefault;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private HTProgressBar htProgressBar5;
        private HTButton htButton1;
        private System.Windows.Forms.TextBox tbRetry;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbIgnore;
        private System.Windows.Forms.TextBox tbAbort;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private HTSwitch hsCancel;
        private HTSwitch hsOK;
        private HTSwitch hsNo;
        private HTSwitch hsYes;
        private HTSwitch hsIgnore;
        private HTSwitch hsAbort;
        private HTSwitch hsRetry;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.NumericUpDown nudBorder;
        private System.Windows.Forms.NumericUpDown nudVal;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lbBorder;
        private System.Windows.Forms.Label lbVal;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Label lbMin;
        private HTSwitch hsBorder;
        private HTSwitch hsPBar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbOverlayColor;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tpTools;
        private HTButton hbRandom;
        private System.Windows.Forms.Label lbRandom;
        private System.Windows.Forms.NumericUpDown nudRandom;
        private HTSwitch hsDefault;
        private System.Windows.Forms.PictureBox pbValidUrl;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.PictureBox pbForeColor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Button button5;
        private HTSwitch hsForeColor;
        private System.Windows.Forms.Label label27;
    }
}

