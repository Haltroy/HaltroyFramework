﻿using HTAlt.WinForms;

namespace HTAlt.Test
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
            this.hsBorder = new HTAlt.WinForms.HTSwitch();
            this.hsPBar = new HTAlt.WinForms.HTSwitch();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hsRetry = new HTAlt.WinForms.HTSwitch();
            this.hsCancel = new HTAlt.WinForms.HTSwitch();
            this.hsOK = new HTAlt.WinForms.HTSwitch();
            this.hsNo = new HTAlt.WinForms.HTSwitch();
            this.hsYes = new HTAlt.WinForms.HTSwitch();
            this.hsIgnore = new HTAlt.WinForms.HTSwitch();
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
            this.pbBackColor = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HTListView2 = new HTAlt.WinForms.HTListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sliderValue = new System.Windows.Forms.Label();
            this.HTSwitch1 = new HTAlt.WinForms.HTSwitch();
            this.HTSlider1 = new HTAlt.WinForms.HTSlider();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.htButton9 = new HTAlt.WinForms.HTButton();
            this.htButton8 = new HTAlt.WinForms.HTButton();
            this.htButton7 = new HTAlt.WinForms.HTButton();
            this.htButton6 = new HTAlt.WinForms.HTButton();
            this.htButton5 = new HTAlt.WinForms.HTButton();
            this.htButton4 = new HTAlt.WinForms.HTButton();
            this.htButton3 = new HTAlt.WinForms.HTButton();
            this.htButton2 = new HTAlt.WinForms.HTButton();
            this.htButton1 = new HTAlt.WinForms.HTButton();
            this.HTProgressBar8 = new HTAlt.WinForms.HTProgressBar();
            this.HTProgressBar4 = new HTAlt.WinForms.HTProgressBar();
            this.HTProgressBar7 = new HTAlt.WinForms.HTProgressBar();
            this.HTProgressBar3 = new HTAlt.WinForms.HTProgressBar();
            this.htProgressBar6 = new HTAlt.WinForms.HTProgressBar();
            this.HTProgressBar2 = new HTAlt.WinForms.HTProgressBar();
            this.htProgressBar5 = new HTAlt.WinForms.HTProgressBar();
            this.HTProgressBar1 = new HTAlt.WinForms.HTProgressBar();
            this.label24 = new System.Windows.Forms.Label();
            this.HTSwitch3 = new HTAlt.WinForms.HTSwitch();
            this.label21 = new System.Windows.Forms.Label();
            this.HTSwitch2 = new HTAlt.WinForms.HTSwitch();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.HTTabControl1.SuspendLayout();
            this.tpBoxes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOverlayColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // HTTabControl1
            // 
            this.HTTabControl1.AllowDrop = true;
            this.HTTabControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.HTTabControl1.BorderTabLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.HTTabControl1.Controls.Add(this.tpBoxes);
            this.HTTabControl1.Controls.Add(this.tabPage2);
            this.HTTabControl1.Controls.Add(this.tabPage4);
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
            this.tpBoxes.Controls.Add(this.hsBorder);
            this.tpBoxes.Controls.Add(this.hsPBar);
            this.tpBoxes.Controls.Add(this.label15);
            this.tpBoxes.Controls.Add(this.label3);
            this.tpBoxes.Controls.Add(this.hsRetry);
            this.tpBoxes.Controls.Add(this.hsCancel);
            this.tpBoxes.Controls.Add(this.hsOK);
            this.tpBoxes.Controls.Add(this.hsNo);
            this.tpBoxes.Controls.Add(this.hsYes);
            this.tpBoxes.Controls.Add(this.hsIgnore);
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
            this.tpBoxes.Controls.Add(this.pbBackColor);
            this.tpBoxes.Controls.Add(this.label5);
            this.tpBoxes.Controls.Add(this.label4);
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
            this.tpBoxes.Controls.Add(this.button2);
            this.tpBoxes.Controls.Add(this.button3);
            this.tpBoxes.Controls.Add(this.button1);
            this.tpBoxes.Location = new System.Drawing.Point(4, 20);
            this.tpBoxes.Name = "tpBoxes";
            this.tpBoxes.Padding = new System.Windows.Forms.Padding(3);
            this.tpBoxes.Size = new System.Drawing.Size(792, 426);
            this.tpBoxes.TabIndex = 0;
            this.tpBoxes.Text = "MsgBox & InputBox";
            this.tpBoxes.UseVisualStyleBackColor = true;
            // 
            // nudBorder
            // 
            this.nudBorder.Location = new System.Drawing.Point(237, 347);
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
            this.nudVal.Location = new System.Drawing.Point(70, 347);
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
            this.nudMax.Location = new System.Drawing.Point(196, 317);
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
            this.nudMin.Location = new System.Drawing.Point(70, 317);
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
            this.lbBorder.Location = new System.Drawing.Point(156, 349);
            this.lbBorder.Name = "lbBorder";
            this.lbBorder.Size = new System.Drawing.Size(75, 16);
            this.lbBorder.TabIndex = 36;
            this.lbBorder.Text = "Border Size:";
            // 
            // lbVal
            // 
            this.lbVal.AutoSize = true;
            this.lbVal.Location = new System.Drawing.Point(23, 349);
            this.lbVal.Name = "lbVal";
            this.lbVal.Size = new System.Drawing.Size(41, 16);
            this.lbVal.TabIndex = 35;
            this.lbVal.Text = "Value:";
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(156, 319);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(34, 16);
            this.lbMax.TabIndex = 34;
            this.lbMax.Text = "Max:";
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(23, 319);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(32, 16);
            this.lbMin.TabIndex = 34;
            this.lbMin.Text = "Min:";
            // 
            // hsBorder
            // 
            this.hsBorder.Location = new System.Drawing.Point(111, 383);
            this.hsBorder.Name = "hsBorder";
            this.hsBorder.Size = new System.Drawing.Size(50, 19);
            this.hsBorder.TabIndex = 33;
            // 
            // hsPBar
            // 
            this.hsPBar.Location = new System.Drawing.Point(140, 285);
            this.hsPBar.Name = "hsPBar";
            this.hsPBar.Size = new System.Drawing.Size(50, 19);
            this.hsPBar.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 384);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 16);
            this.label15.TabIndex = 32;
            this.label15.Text = "Draw Border:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "Show Progress Bar:";
            // 
            // hsRetry
            // 
            this.hsRetry.Location = new System.Drawing.Point(315, 206);
            this.hsRetry.Name = "hsRetry";
            this.hsRetry.Size = new System.Drawing.Size(50, 19);
            this.hsRetry.TabIndex = 31;
            // 
            // hsCancel
            // 
            this.hsCancel.Location = new System.Drawing.Point(315, 181);
            this.hsCancel.Name = "hsCancel";
            this.hsCancel.Size = new System.Drawing.Size(50, 19);
            this.hsCancel.TabIndex = 31;
            // 
            // hsOK
            // 
            this.hsOK.Location = new System.Drawing.Point(315, 156);
            this.hsOK.Name = "hsOK";
            this.hsOK.Size = new System.Drawing.Size(50, 19);
            this.hsOK.TabIndex = 31;
            // 
            // hsNo
            // 
            this.hsNo.Location = new System.Drawing.Point(315, 131);
            this.hsNo.Name = "hsNo";
            this.hsNo.Size = new System.Drawing.Size(50, 19);
            this.hsNo.TabIndex = 31;
            // 
            // hsYes
            // 
            this.hsYes.Location = new System.Drawing.Point(314, 106);
            this.hsYes.Name = "hsYes";
            this.hsYes.Size = new System.Drawing.Size(50, 19);
            this.hsYes.TabIndex = 31;
            // 
            // hsIgnore
            // 
            this.hsIgnore.Location = new System.Drawing.Point(315, 256);
            this.hsIgnore.Name = "hsIgnore";
            this.hsIgnore.Size = new System.Drawing.Size(50, 19);
            this.hsIgnore.TabIndex = 31;
            // 
            // hsAbort
            // 
            this.hsAbort.Location = new System.Drawing.Point(314, 231);
            this.hsAbort.Name = "hsAbort";
            this.hsAbort.Size = new System.Drawing.Size(50, 19);
            this.hsAbort.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(615, 256);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "HTProgressBox:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(615, 147);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "HTInputBox:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(612, 28);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(71, 16);
            this.label19.TabIndex = 30;
            this.label19.Text = "HTMsgBox:";
            // 
            // ibResult
            // 
            this.ibResult.AutoSize = true;
            this.ibResult.Location = new System.Drawing.Point(615, 212);
            this.ibResult.Name = "ibResult";
            this.ibResult.Size = new System.Drawing.Size(73, 16);
            this.ibResult.TabIndex = 29;
            this.ibResult.Text = "<no result>";
            this.ibResult.Visible = false;
            // 
            // ibResultTitle
            // 
            this.ibResultTitle.AutoSize = true;
            this.ibResultTitle.Location = new System.Drawing.Point(615, 193);
            this.ibResultTitle.Name = "ibResultTitle";
            this.ibResultTitle.Size = new System.Drawing.Size(48, 16);
            this.ibResultTitle.TabIndex = 28;
            this.ibResultTitle.Text = "Result:";
            this.ibResultTitle.Visible = false;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(711, 253);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 26;
            this.button8.Text = "Show";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(696, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(90, 23);
            this.button4.TabIndex = 27;
            this.button4.Text = "Show Dialog";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(615, 166);
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
            this.ibDefault.Size = new System.Drawing.Size(268, 46);
            this.ibDefault.TabIndex = 20;
            // 
            // ibSetToDefault
            // 
            this.ibSetToDefault.Location = new System.Drawing.Point(21, 256);
            this.ibSetToDefault.Name = "ibSetToDefault";
            this.ibSetToDefault.Size = new System.Drawing.Size(268, 23);
            this.ibSetToDefault.TabIndex = 21;
            this.ibSetToDefault.Text = "Set to default";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(18, 169);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 16);
            this.label22.TabIndex = 18;
            this.label22.Text = "Default Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 237);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 16);
            this.label12.TabIndex = 19;
            this.label12.Text = "\"Set to default\" Button Text:";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Location = new System.Drawing.Point(615, 93);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(73, 16);
            this.lResult.TabIndex = 8;
            this.lResult.Text = "<no result>";
            this.lResult.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(615, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "Result:";
            this.label10.Visible = false;
            // 
            // pbOverlayColor
            // 
            this.pbOverlayColor.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbOverlayColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOverlayColor.Location = new System.Drawing.Point(518, 60);
            this.pbOverlayColor.Name = "pbOverlayColor";
            this.pbOverlayColor.Size = new System.Drawing.Size(30, 30);
            this.pbOverlayColor.TabIndex = 6;
            this.pbOverlayColor.TabStop = false;
            this.pbOverlayColor.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(431, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "OverlayColor:";
            // 
            // pbBackColor
            // 
            this.pbBackColor.BackColor = System.Drawing.Color.White;
            this.pbBackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBackColor.Location = new System.Drawing.Point(382, 60);
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
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "BackColor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Icon:";
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
            this.tbIcon.Size = new System.Drawing.Size(235, 23);
            this.tbIcon.TabIndex = 3;
            // 
            // tbCancel
            // 
            this.tbCancel.Location = new System.Drawing.Point(495, 180);
            this.tbCancel.Name = "tbCancel";
            this.tbCancel.Size = new System.Drawing.Size(85, 23);
            this.tbCancel.TabIndex = 3;
            this.tbCancel.Text = "Cancel";
            // 
            // tbOK
            // 
            this.tbOK.Location = new System.Drawing.Point(475, 156);
            this.tbOK.Name = "tbOK";
            this.tbOK.Size = new System.Drawing.Size(105, 23);
            this.tbOK.TabIndex = 3;
            this.tbOK.Text = "OK";
            // 
            // tbNo
            // 
            this.tbNo.Location = new System.Drawing.Point(473, 131);
            this.tbNo.Name = "tbNo";
            this.tbNo.Size = new System.Drawing.Size(107, 23);
            this.tbNo.TabIndex = 3;
            this.tbNo.Text = "No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(368, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Cancel Button Text:";
            // 
            // tbIgnore
            // 
            this.tbIgnore.Location = new System.Drawing.Point(491, 253);
            this.tbIgnore.Name = "tbIgnore";
            this.tbIgnore.Size = new System.Drawing.Size(89, 23);
            this.tbIgnore.TabIndex = 3;
            this.tbIgnore.Text = "Ignore";
            // 
            // tbAbort
            // 
            this.tbAbort.Location = new System.Drawing.Point(491, 229);
            this.tbAbort.Name = "tbAbort";
            this.tbAbort.Size = new System.Drawing.Size(89, 23);
            this.tbAbort.TabIndex = 3;
            this.tbAbort.Text = "Abort";
            // 
            // tbRetry
            // 
            this.tbRetry.Location = new System.Drawing.Point(491, 204);
            this.tbRetry.Name = "tbRetry";
            this.tbRetry.Size = new System.Drawing.Size(89, 23);
            this.tbRetry.TabIndex = 3;
            this.tbRetry.Text = "Retry";
            // 
            // tbYes
            // 
            this.tbYes.Location = new System.Drawing.Point(476, 105);
            this.tbYes.Name = "tbYes";
            this.tbYes.Size = new System.Drawing.Size(104, 23);
            this.tbYes.TabIndex = 3;
            this.tbYes.Text = "Yes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(371, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 16);
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
            this.label7.Location = new System.Drawing.Point(368, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "No Button Text:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Message:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(368, 256);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 16);
            this.label14.TabIndex = 2;
            this.label14.Text = "Ignore Button Text:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(368, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Abort Button Text:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 16);
            this.label11.TabIndex = 2;
            this.label11.Text = "Retry Button Text:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Yes Button Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Title:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(696, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Dialog";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 30);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 24);
            this.button3.TabIndex = 1;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(615, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.HTListView2);
            this.tabPage2.Controls.Add(this.sliderValue);
            this.tabPage2.Controls.Add(this.HTSwitch1);
            this.tabPage2.Controls.Add(this.HTSlider1);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Slider & Switch & ListView";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.HTListView2.Location = new System.Drawing.Point(8, 85);
            this.HTListView2.Name = "HTListView2";
            this.HTListView2.OverlayColor = System.Drawing.Color.DodgerBlue;
            this.HTListView2.Size = new System.Drawing.Size(777, 335);
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
            this.sliderValue.Size = new System.Drawing.Size(50, 16);
            this.sliderValue.TabIndex = 2;
            this.sliderValue.Text = "<value>";
            // 
            // HTSwitch1
            // 
            this.HTSwitch1.Location = new System.Drawing.Point(8, 47);
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.htButton9);
            this.tabPage4.Controls.Add(this.htButton8);
            this.tabPage4.Controls.Add(this.htButton7);
            this.tabPage4.Controls.Add(this.htButton6);
            this.tabPage4.Controls.Add(this.htButton5);
            this.tabPage4.Controls.Add(this.htButton4);
            this.tabPage4.Controls.Add(this.htButton3);
            this.tabPage4.Controls.Add(this.htButton2);
            this.tabPage4.Controls.Add(this.htButton1);
            this.tabPage4.Controls.Add(this.HTProgressBar8);
            this.tabPage4.Controls.Add(this.HTProgressBar4);
            this.tabPage4.Controls.Add(this.HTProgressBar7);
            this.tabPage4.Controls.Add(this.HTProgressBar3);
            this.tabPage4.Controls.Add(this.htProgressBar6);
            this.tabPage4.Controls.Add(this.HTProgressBar2);
            this.tabPage4.Controls.Add(this.htProgressBar5);
            this.tabPage4.Controls.Add(this.HTProgressBar1);
            this.tabPage4.Controls.Add(this.label24);
            this.tabPage4.Controls.Add(this.HTSwitch3);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.HTSwitch2);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Location = new System.Drawing.Point(4, 20);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 426);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Forms & Button & ProgressBar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // htButton9
            // 
            this.htButton9.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton9.ButtonText = "Sample Text";
            this.htButton9.FlatAppearance.BorderSize = 0;
            this.htButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton9.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Tile;
            this.htButton9.Location = new System.Drawing.Point(410, 252);
            this.htButton9.Name = "htButton9";
            this.htButton9.Size = new System.Drawing.Size(124, 49);
            this.htButton9.TabIndex = 24;
            this.htButton9.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.JustImage;
            this.htButton9.UseVisualStyleBackColor = true;
            // 
            // htButton8
            // 
            this.htButton8.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton8.ButtonText = "Sample Text";
            this.htButton8.FlatAppearance.BorderSize = 0;
            this.htButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton8.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Stretch;
            this.htButton8.Location = new System.Drawing.Point(410, 169);
            this.htButton8.Name = "htButton8";
            this.htButton8.Size = new System.Drawing.Size(124, 49);
            this.htButton8.TabIndex = 23;
            this.htButton8.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.JustImage;
            this.htButton8.UseVisualStyleBackColor = true;
            // 
            // htButton7
            // 
            this.htButton7.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton7.ButtonText = "Sample Text";
            this.htButton7.FlatAppearance.BorderSize = 0;
            this.htButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton7.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Center;
            this.htButton7.Location = new System.Drawing.Point(269, 169);
            this.htButton7.Name = "htButton7";
            this.htButton7.Size = new System.Drawing.Size(124, 49);
            this.htButton7.TabIndex = 22;
            this.htButton7.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.JustImage;
            this.htButton7.UseVisualStyleBackColor = true;
            // 
            // htButton6
            // 
            this.htButton6.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton6.ButtonText = "Sample Text";
            this.htButton6.FlatAppearance.BorderSize = 0;
            this.htButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton6.Location = new System.Drawing.Point(139, 169);
            this.htButton6.Name = "htButton6";
            this.htButton6.Size = new System.Drawing.Size(124, 49);
            this.htButton6.TabIndex = 21;
            this.htButton6.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.JustImage;
            this.htButton6.UseVisualStyleBackColor = true;
            // 
            // htButton5
            // 
            this.htButton5.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton5.ButtonText = "Sample Text";
            this.htButton5.FlatAppearance.BorderSize = 0;
            this.htButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton5.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.htButton5.Location = new System.Drawing.Point(9, 97);
            this.htButton5.Name = "htButton5";
            this.htButton5.Size = new System.Drawing.Size(124, 49);
            this.htButton5.TabIndex = 20;
            this.htButton5.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.None;
            this.htButton5.UseVisualStyleBackColor = true;
            // 
            // htButton4
            // 
            this.htButton4.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton4.ButtonText = "Sample Text";
            this.htButton4.FlatAppearance.BorderSize = 0;
            this.htButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton4.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.htButton4.Location = new System.Drawing.Point(9, 169);
            this.htButton4.Name = "htButton4";
            this.htButton4.Size = new System.Drawing.Size(124, 49);
            this.htButton4.TabIndex = 19;
            this.htButton4.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.JustImage;
            this.htButton4.UseVisualStyleBackColor = true;
            // 
            // htButton3
            // 
            this.htButton3.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton3.ButtonText = "Sample Text";
            this.htButton3.FlatAppearance.BorderSize = 0;
            this.htButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton3.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.htButton3.Location = new System.Drawing.Point(9, 234);
            this.htButton3.Name = "htButton3";
            this.htButton3.Size = new System.Drawing.Size(124, 49);
            this.htButton3.TabIndex = 18;
            this.htButton3.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.JustText;
            this.htButton3.UseVisualStyleBackColor = true;
            // 
            // htButton2
            // 
            this.htButton2.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton2.ButtonText = "Sample Text";
            this.htButton2.FlatAppearance.BorderSize = 0;
            this.htButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton2.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.htButton2.Location = new System.Drawing.Point(9, 344);
            this.htButton2.Name = "htButton2";
            this.htButton2.Size = new System.Drawing.Size(124, 49);
            this.htButton2.TabIndex = 17;
            this.htButton2.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.TextBelowImage;
            this.htButton2.UseVisualStyleBackColor = true;
            // 
            // htButton1
            // 
            this.htButton1.ButtonImage = global::HTAlt.Test.Properties.Resources.ht_logo_2020;
            this.htButton1.ButtonText = "Sample Text";
            this.htButton1.FlatAppearance.BorderSize = 0;
            this.htButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.htButton1.ImageSizeMode = HTAlt.WinForms.HTButton.ButtonImageSizeMode.Zoom;
            this.htButton1.Location = new System.Drawing.Point(9, 289);
            this.htButton1.Name = "htButton1";
            this.htButton1.Size = new System.Drawing.Size(124, 49);
            this.htButton1.TabIndex = 16;
            this.htButton1.TextImageRelation = HTAlt.WinForms.HTButton.ButtonTextImageRelation.TextAboveImage;
            this.htButton1.UseVisualStyleBackColor = true;
            // 
            // HTProgressBar8
            // 
            this.HTProgressBar8.BorderThickness = 2;
            this.HTProgressBar8.Direction = HTAlt.WinForms.HTProgressBar.ProgressDirection.TopToBottom;
            this.HTProgressBar8.DrawBorder = true;
            this.HTProgressBar8.Location = new System.Drawing.Point(697, 121);
            this.HTProgressBar8.Name = "HTProgressBar8";
            this.HTProgressBar8.Size = new System.Drawing.Size(10, 261);
            this.HTProgressBar8.TabIndex = 8;
            this.HTProgressBar8.Text = "label19";
            this.HTProgressBar8.Value = 34;
            // 
            // HTProgressBar4
            // 
            this.HTProgressBar4.BorderThickness = 0;
            this.HTProgressBar4.Direction = HTAlt.WinForms.HTProgressBar.ProgressDirection.TopToBottom;
            this.HTProgressBar4.Location = new System.Drawing.Point(653, 121);
            this.HTProgressBar4.Name = "HTProgressBar4";
            this.HTProgressBar4.Size = new System.Drawing.Size(10, 261);
            this.HTProgressBar4.TabIndex = 9;
            this.HTProgressBar4.Text = "label19";
            this.HTProgressBar4.Value = 34;
            // 
            // HTProgressBar7
            // 
            this.HTProgressBar7.BorderThickness = 2;
            this.HTProgressBar7.Direction = HTAlt.WinForms.HTProgressBar.ProgressDirection.BottomToTop;
            this.HTProgressBar7.DrawBorder = true;
            this.HTProgressBar7.Location = new System.Drawing.Point(681, 121);
            this.HTProgressBar7.Name = "HTProgressBar7";
            this.HTProgressBar7.Size = new System.Drawing.Size(10, 261);
            this.HTProgressBar7.TabIndex = 10;
            this.HTProgressBar7.Text = "label19";
            this.HTProgressBar7.Value = 34;
            // 
            // HTProgressBar3
            // 
            this.HTProgressBar3.BorderThickness = 0;
            this.HTProgressBar3.Direction = HTAlt.WinForms.HTProgressBar.ProgressDirection.BottomToTop;
            this.HTProgressBar3.Location = new System.Drawing.Point(619, 121);
            this.HTProgressBar3.Name = "HTProgressBar3";
            this.HTProgressBar3.Size = new System.Drawing.Size(10, 261);
            this.HTProgressBar3.TabIndex = 11;
            this.HTProgressBar3.Text = "label19";
            this.HTProgressBar3.Value = 34;
            // 
            // htProgressBar6
            // 
            this.htProgressBar6.BorderThickness = 2;
            this.htProgressBar6.Direction = HTAlt.WinForms.HTProgressBar.ProgressDirection.RightToLeft;
            this.htProgressBar6.DrawBorder = true;
            this.htProgressBar6.Location = new System.Drawing.Point(619, 69);
            this.htProgressBar6.Name = "htProgressBar6";
            this.htProgressBar6.Size = new System.Drawing.Size(153, 10);
            this.htProgressBar6.TabIndex = 12;
            this.htProgressBar6.Text = "label19";
            this.htProgressBar6.Value = 34;
            // 
            // HTProgressBar2
            // 
            this.HTProgressBar2.BorderThickness = 0;
            this.HTProgressBar2.Direction = HTAlt.WinForms.HTProgressBar.ProgressDirection.RightToLeft;
            this.HTProgressBar2.Location = new System.Drawing.Point(619, 36);
            this.HTProgressBar2.Name = "HTProgressBar2";
            this.HTProgressBar2.Size = new System.Drawing.Size(153, 10);
            this.HTProgressBar2.TabIndex = 13;
            this.HTProgressBar2.Text = "label19";
            this.HTProgressBar2.Value = 34;
            // 
            // htProgressBar5
            // 
            this.htProgressBar5.BorderThickness = 2;
            this.htProgressBar5.DrawBorder = true;
            this.htProgressBar5.Location = new System.Drawing.Point(619, 52);
            this.htProgressBar5.Name = "htProgressBar5";
            this.htProgressBar5.Size = new System.Drawing.Size(153, 10);
            this.htProgressBar5.TabIndex = 14;
            this.htProgressBar5.Text = "label19";
            this.htProgressBar5.Value = 34;
            // 
            // HTProgressBar1
            // 
            this.HTProgressBar1.BorderThickness = 0;
            this.HTProgressBar1.Location = new System.Drawing.Point(619, 19);
            this.HTProgressBar1.Name = "HTProgressBar1";
            this.HTProgressBar1.Size = new System.Drawing.Size(153, 10);
            this.HTProgressBar1.TabIndex = 15;
            this.HTProgressBar1.Text = "label19";
            this.HTProgressBar1.Value = 25;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(66, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(104, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "Full Screen Mode";
            this.label24.Click += new System.EventHandler(this.HTSwitch3_CheckedChanged);
            // 
            // HTSwitch3
            // 
            this.HTSwitch3.Location = new System.Drawing.Point(9, 61);
            this.HTSwitch3.Name = "HTSwitch3";
            this.HTSwitch3.Size = new System.Drawing.Size(50, 19);
            this.HTSwitch3.TabIndex = 1;
            this.HTSwitch3.CheckedChanged += new HTAlt.WinForms.HTSwitch.CheckedChangedDelegate(this.HTSwitch3_CheckedChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(66, 39);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 16);
            this.label21.TabIndex = 2;
            this.label21.Text = "Draggable";
            this.label21.Click += new System.EventHandler(this.HTSwitch2_CheckedChanged);
            // 
            // HTSwitch2
            // 
            this.HTSwitch2.Location = new System.Drawing.Point(9, 36);
            this.HTSwitch2.Name = "HTSwitch2";
            this.HTSwitch2.Size = new System.Drawing.Size(50, 19);
            this.HTSwitch2.TabIndex = 1;
            this.HTSwitch2.CheckedChanged += new HTAlt.WinForms.HTSwitch.CheckedChangedDelegate(this.HTSwitch2_CheckedChanged);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(206, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(187, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Spawn a HTTabForm";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Spawn a HTForm";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbBackColor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HTAlt.WinForms.HTTabControl HTTabControl1;
        private System.Windows.Forms.TabPage tpBoxes;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label24;
        private HTAlt.WinForms.HTSwitch HTSwitch3;
        private System.Windows.Forms.Label label21;
        private HTAlt.WinForms.HTSwitch HTSwitch2;
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
        private HTProgressBar HTProgressBar8;
        private HTProgressBar HTProgressBar4;
        private HTProgressBar HTProgressBar7;
        private HTProgressBar HTProgressBar3;
        private HTProgressBar htProgressBar6;
        private HTProgressBar HTProgressBar2;
        private HTProgressBar htProgressBar5;
        private HTProgressBar HTProgressBar1;
        private HTButton htButton2;
        private HTButton htButton1;
        private HTButton htButton5;
        private HTButton htButton4;
        private HTButton htButton3;
        private HTButton htButton7;
        private HTButton htButton6;
        private HTButton htButton9;
        private HTButton htButton8;
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
        private System.Windows.Forms.Button button5;
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
    }
}

