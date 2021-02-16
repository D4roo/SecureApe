namespace SecureApe
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbPasscode = new System.Windows.Forms.GroupBox();
            this.cmdScanStart = new System.Windows.Forms.Button();
            this.cmdBackPass = new System.Windows.Forms.Button();
            this.cmdEnter = new System.Windows.Forms.Button();
            this.lbPass = new System.Windows.Forms.Label();
            this.txtPasscode = new System.Windows.Forms.TextBox();
            this.grbHome = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmdSTOPsnd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdPLAY3 = new System.Windows.Forms.Button();
            this.cmdPLAY2 = new System.Windows.Forms.Button();
            this.cmdPLAY1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmpPLAYc = new System.Windows.Forms.Button();
            this.cmdPLAYb = new System.Windows.Forms.Button();
            this.cmdPLAYa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdPlaySCP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLogOut = new System.Windows.Forms.Button();
            this.grScanner = new System.Windows.Forms.GroupBox();
            this.cmdQRrun = new System.Windows.Forms.Button();
            this.cmdQRstop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.txtQRdecode = new System.Windows.Forms.TextBox();
            this.cmdQRback = new System.Windows.Forms.Button();
            this.picQRscan = new System.Windows.Forms.PictureBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdPasscode = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerQRpic = new System.Windows.Forms.Timer(this.components);
            this.grbPasscode.SuspendLayout();
            this.grbHome.SuspendLayout();
            this.grScanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRscan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPasscode
            // 
            this.grbPasscode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbPasscode.Controls.Add(this.cmdScanStart);
            this.grbPasscode.Controls.Add(this.cmdBackPass);
            this.grbPasscode.Controls.Add(this.cmdEnter);
            this.grbPasscode.Controls.Add(this.lbPass);
            this.grbPasscode.Controls.Add(this.txtPasscode);
            this.grbPasscode.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPasscode.Location = new System.Drawing.Point(12, 310);
            this.grbPasscode.Name = "grbPasscode";
            this.grbPasscode.Size = new System.Drawing.Size(478, 113);
            this.grbPasscode.TabIndex = 2;
            this.grbPasscode.TabStop = false;
            this.grbPasscode.Text = "Passcode";
            this.grbPasscode.Visible = false;
            // 
            // cmdScanStart
            // 
            this.cmdScanStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdScanStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdScanStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdScanStart.Location = new System.Drawing.Point(273, 69);
            this.cmdScanStart.Name = "cmdScanStart";
            this.cmdScanStart.Size = new System.Drawing.Size(80, 36);
            this.cmdScanStart.TabIndex = 4;
            this.cmdScanStart.Text = "Scan";
            this.cmdScanStart.UseVisualStyleBackColor = false;
            this.cmdScanStart.Click += new System.EventHandler(this.cmdScanStart_Click);
            // 
            // cmdBackPass
            // 
            this.cmdBackPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdBackPass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBackPass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBackPass.Location = new System.Drawing.Point(359, 69);
            this.cmdBackPass.Name = "cmdBackPass";
            this.cmdBackPass.Size = new System.Drawing.Size(109, 36);
            this.cmdBackPass.TabIndex = 3;
            this.cmdBackPass.Text = "Back";
            this.cmdBackPass.UseVisualStyleBackColor = false;
            this.cmdBackPass.Click += new System.EventHandler(this.cmdBackPass_Click);
            // 
            // cmdEnter
            // 
            this.cmdEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdEnter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEnter.Location = new System.Drawing.Point(359, 22);
            this.cmdEnter.Name = "cmdEnter";
            this.cmdEnter.Size = new System.Drawing.Size(109, 36);
            this.cmdEnter.TabIndex = 2;
            this.cmdEnter.Text = "Enter";
            this.cmdEnter.UseVisualStyleBackColor = false;
            this.cmdEnter.Click += new System.EventHandler(this.cmdEnter_Click);
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(6, 48);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(98, 21);
            this.lbPass.TabIndex = 1;
            this.lbPass.Text = "Enter here";
            // 
            // txtPasscode
            // 
            this.txtPasscode.BackColor = System.Drawing.Color.Gray;
            this.txtPasscode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasscode.Location = new System.Drawing.Point(6, 73);
            this.txtPasscode.Name = "txtPasscode";
            this.txtPasscode.Size = new System.Drawing.Size(206, 32);
            this.txtPasscode.TabIndex = 0;
            // 
            // grbHome
            // 
            this.grbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grbHome.Controls.Add(this.label8);
            this.grbHome.Controls.Add(this.cmdSTOPsnd);
            this.grbHome.Controls.Add(this.label7);
            this.grbHome.Controls.Add(this.label6);
            this.grbHome.Controls.Add(this.label5);
            this.grbHome.Controls.Add(this.cmdPLAY3);
            this.grbHome.Controls.Add(this.cmdPLAY2);
            this.grbHome.Controls.Add(this.cmdPLAY1);
            this.grbHome.Controls.Add(this.label4);
            this.grbHome.Controls.Add(this.cmpPLAYc);
            this.grbHome.Controls.Add(this.cmdPLAYb);
            this.grbHome.Controls.Add(this.cmdPLAYa);
            this.grbHome.Controls.Add(this.label3);
            this.grbHome.Controls.Add(this.cmdPlaySCP);
            this.grbHome.Controls.Add(this.label2);
            this.grbHome.Controls.Add(this.label1);
            this.grbHome.Controls.Add(this.cmdLogOut);
            this.grbHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHome.Location = new System.Drawing.Point(12, 12);
            this.grbHome.Name = "grbHome";
            this.grbHome.Size = new System.Drawing.Size(478, 239);
            this.grbHome.TabIndex = 3;
            this.grbHome.TabStop = false;
            this.grbHome.Text = "SecureApe";
            this.grbHome.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Sound";
            // 
            // cmdSTOPsnd
            // 
            this.cmdSTOPsnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdSTOPsnd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSTOPsnd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSTOPsnd.Location = new System.Drawing.Point(388, 64);
            this.cmdSTOPsnd.Name = "cmdSTOPsnd";
            this.cmdSTOPsnd.Size = new System.Drawing.Size(71, 34);
            this.cmdSTOPsnd.TabIndex = 15;
            this.cmdSTOPsnd.Text = "Stop";
            this.cmdSTOPsnd.UseVisualStyleBackColor = false;
            this.cmdSTOPsnd.Click += new System.EventHandler(this.cmdSTOPsnd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "  Safe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Intruder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = " False Alarm";
            // 
            // cmdPLAY3
            // 
            this.cmdPLAY3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPLAY3.BackgroundImage = global::SecureApe.Properties.Resources.Intercom;
            this.cmdPLAY3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPLAY3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPLAY3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPLAY3.Location = new System.Drawing.Point(230, 167);
            this.cmdPLAY3.Name = "cmdPLAY3";
            this.cmdPLAY3.Size = new System.Drawing.Size(52, 65);
            this.cmdPLAY3.TabIndex = 11;
            this.cmdPLAY3.UseVisualStyleBackColor = false;
            this.cmdPLAY3.Click += new System.EventHandler(this.cmdPLAY3_Click);
            // 
            // cmdPLAY2
            // 
            this.cmdPLAY2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPLAY2.BackgroundImage = global::SecureApe.Properties.Resources.Intercom;
            this.cmdPLAY2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPLAY2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPLAY2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPLAY2.Location = new System.Drawing.Point(273, 64);
            this.cmdPLAY2.Name = "cmdPLAY2";
            this.cmdPLAY2.Size = new System.Drawing.Size(52, 65);
            this.cmdPLAY2.TabIndex = 10;
            this.cmdPLAY2.UseVisualStyleBackColor = false;
            this.cmdPLAY2.Click += new System.EventHandler(this.cmdPLAY2_Click);
            // 
            // cmdPLAY1
            // 
            this.cmdPLAY1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPLAY1.BackgroundImage = global::SecureApe.Properties.Resources.Intercom;
            this.cmdPLAY1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPLAY1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPLAY1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPLAY1.Location = new System.Drawing.Point(193, 64);
            this.cmdPLAY1.Name = "cmdPLAY1";
            this.cmdPLAY1.Size = new System.Drawing.Size(52, 65);
            this.cmdPLAY1.TabIndex = 9;
            this.cmdPLAY1.UseVisualStyleBackColor = false;
            this.cmdPLAY1.Click += new System.EventHandler(this.cmdPLAY1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = " Intercom";
            // 
            // cmpPLAYc
            // 
            this.cmpPLAYc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmpPLAYc.BackgroundImage = global::SecureApe.Properties.Resources.ImperialCON;
            this.cmpPLAYc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmpPLAYc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmpPLAYc.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpPLAYc.Location = new System.Drawing.Point(67, 173);
            this.cmpPLAYc.Name = "cmpPLAYc";
            this.cmpPLAYc.Size = new System.Drawing.Size(51, 34);
            this.cmpPLAYc.TabIndex = 7;
            this.cmpPLAYc.UseVisualStyleBackColor = false;
            this.cmpPLAYc.Click += new System.EventHandler(this.cmpPLAYc_Click);
            // 
            // cmdPLAYb
            // 
            this.cmdPLAYb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPLAYb.BackgroundImage = global::SecureApe.Properties.Resources.ImperialCON;
            this.cmdPLAYb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPLAYb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPLAYb.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPLAYb.Location = new System.Drawing.Point(95, 133);
            this.cmdPLAYb.Name = "cmdPLAYb";
            this.cmdPLAYb.Size = new System.Drawing.Size(44, 34);
            this.cmdPLAYb.TabIndex = 6;
            this.cmdPLAYb.UseVisualStyleBackColor = false;
            this.cmdPLAYb.Click += new System.EventHandler(this.cmdPLAYb_Click);
            // 
            // cmdPLAYa
            // 
            this.cmdPLAYa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPLAYa.BackgroundImage = global::SecureApe.Properties.Resources.ImperialCON;
            this.cmdPLAYa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPLAYa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPLAYa.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPLAYa.Location = new System.Drawing.Point(45, 133);
            this.cmdPLAYa.Name = "cmdPLAYa";
            this.cmdPLAYa.Size = new System.Drawing.Size(44, 34);
            this.cmdPLAYa.TabIndex = 5;
            this.cmdPLAYa.UseVisualStyleBackColor = false;
            this.cmdPLAYa.Click += new System.EventHandler(this.cmdPLAYa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Imperial Alert";
            // 
            // cmdPlaySCP
            // 
            this.cmdPlaySCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdPlaySCP.BackgroundImage = global::SecureApe.Properties.Resources.SCPicon;
            this.cmdPlaySCP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPlaySCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPlaySCP.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlaySCP.Location = new System.Drawing.Point(58, 71);
            this.cmdPlaySCP.Name = "cmdPlaySCP";
            this.cmdPlaySCP.Size = new System.Drawing.Size(66, 34);
            this.cmdPlaySCP.TabIndex = 3;
            this.cmdPlaySCP.UseVisualStyleBackColor = false;
            this.cmdPlaySCP.Click += new System.EventHandler(this.cmdPlaySCP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alpha Warhead";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome 05 Tier Ape";
            // 
            // cmdLogOut
            // 
            this.cmdLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLogOut.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLogOut.Location = new System.Drawing.Point(374, 199);
            this.cmdLogOut.Name = "cmdLogOut";
            this.cmdLogOut.Size = new System.Drawing.Size(98, 34);
            this.cmdLogOut.TabIndex = 0;
            this.cmdLogOut.Text = "Log Out";
            this.cmdLogOut.UseVisualStyleBackColor = false;
            this.cmdLogOut.Click += new System.EventHandler(this.cmdLogOut_Click);
            // 
            // grScanner
            // 
            this.grScanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grScanner.Controls.Add(this.cmdQRrun);
            this.grScanner.Controls.Add(this.cmdQRstop);
            this.grScanner.Controls.Add(this.label9);
            this.grScanner.Controls.Add(this.cboDevice);
            this.grScanner.Controls.Add(this.txtQRdecode);
            this.grScanner.Controls.Add(this.cmdQRback);
            this.grScanner.Controls.Add(this.picQRscan);
            this.grScanner.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grScanner.Location = new System.Drawing.Point(12, 5);
            this.grScanner.Name = "grScanner";
            this.grScanner.Size = new System.Drawing.Size(420, 412);
            this.grScanner.TabIndex = 5;
            this.grScanner.TabStop = false;
            this.grScanner.Text = "Card Scanner";
            this.grScanner.Visible = false;
            // 
            // cmdQRrun
            // 
            this.cmdQRrun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdQRrun.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdQRrun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQRrun.Location = new System.Drawing.Point(327, 263);
            this.cmdQRrun.Name = "cmdQRrun";
            this.cmdQRrun.Size = new System.Drawing.Size(80, 36);
            this.cmdQRrun.TabIndex = 9;
            this.cmdQRrun.Text = "Start";
            this.cmdQRrun.UseVisualStyleBackColor = false;
            this.cmdQRrun.Click += new System.EventHandler(this.cmdQRrun_Click);
            // 
            // cmdQRstop
            // 
            this.cmdQRstop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdQRstop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdQRstop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQRstop.Location = new System.Drawing.Point(327, 304);
            this.cmdQRstop.Name = "cmdQRstop";
            this.cmdQRstop.Size = new System.Drawing.Size(80, 36);
            this.cmdQRstop.TabIndex = 8;
            this.cmdQRstop.Text = "Stop";
            this.cmdQRstop.UseVisualStyleBackColor = false;
            this.cmdQRstop.Click += new System.EventHandler(this.cmdQRstop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cam -";
            // 
            // cboDevice
            // 
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(76, 374);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(206, 24);
            this.cboDevice.TabIndex = 7;
            // 
            // txtQRdecode
            // 
            this.txtQRdecode.Location = new System.Drawing.Point(314, 27);
            this.txtQRdecode.Name = "txtQRdecode";
            this.txtQRdecode.Size = new System.Drawing.Size(100, 23);
            this.txtQRdecode.TabIndex = 6;
            this.txtQRdecode.Visible = false;
            // 
            // cmdQRback
            // 
            this.cmdQRback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdQRback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdQRback.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdQRback.Location = new System.Drawing.Point(327, 364);
            this.cmdQRback.Name = "cmdQRback";
            this.cmdQRback.Size = new System.Drawing.Size(80, 36);
            this.cmdQRback.TabIndex = 5;
            this.cmdQRback.Text = "Back";
            this.cmdQRback.UseVisualStyleBackColor = false;
            this.cmdQRback.Click += new System.EventHandler(this.cmdQRback_Click);
            // 
            // picQRscan
            // 
            this.picQRscan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQRscan.Location = new System.Drawing.Point(6, 27);
            this.picQRscan.Name = "picQRscan";
            this.picQRscan.Size = new System.Drawing.Size(300, 313);
            this.picQRscan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picQRscan.TabIndex = 0;
            this.picQRscan.TabStop = false;
            // 
            // cmdExit
            // 
            this.cmdExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Location = new System.Drawing.Point(415, 399);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(75, 39);
            this.cmdExit.TabIndex = 4;
            this.cmdExit.Text = "Exit";
            this.cmdExit.UseVisualStyleBackColor = false;
            this.cmdExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdPasscode
            // 
            this.cmdPasscode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdPasscode.BackgroundImage = global::SecureApe.Properties.Resources.ButtonIcon;
            this.cmdPasscode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmdPasscode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPasscode.Location = new System.Drawing.Point(188, 399);
            this.cmdPasscode.Name = "cmdPasscode";
            this.cmdPasscode.Size = new System.Drawing.Size(125, 39);
            this.cmdPasscode.TabIndex = 1;
            this.cmdPasscode.UseVisualStyleBackColor = false;
            this.cmdPasscode.Click += new System.EventHandler(this.cmdPasscode_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SecureApe.Properties.Resources.SecureApe;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(537, 460);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerQRpic
            // 
            this.timerQRpic.Interval = 1000;
            this.timerQRpic.Tick += new System.EventHandler(this.timerQRpic_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.grScanner);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.grbHome);
            this.Controls.Add(this.grbPasscode);
            this.Controls.Add(this.cmdPasscode);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(516, 497);
            this.MinimumSize = new System.Drawing.Size(516, 497);
            this.Name = "Form1";
            this.Text = "SecureApe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbPasscode.ResumeLayout(false);
            this.grbPasscode.PerformLayout();
            this.grbHome.ResumeLayout(false);
            this.grbHome.PerformLayout();
            this.grScanner.ResumeLayout(false);
            this.grScanner.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQRscan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cmdPasscode;
        private System.Windows.Forms.GroupBox grbPasscode;
        private System.Windows.Forms.Button cmdBackPass;
        private System.Windows.Forms.Button cmdEnter;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.TextBox txtPasscode;
        private System.Windows.Forms.GroupBox grbHome;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdPlaySCP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdPLAYa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmpPLAYc;
        private System.Windows.Forms.Button cmdPLAYb;
        private System.Windows.Forms.Button cmdPLAY1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSTOPsnd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdPLAY3;
        private System.Windows.Forms.Button cmdPLAY2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmdScanStart;
        private System.Windows.Forms.GroupBox grScanner;
        private System.Windows.Forms.TextBox txtQRdecode;
        private System.Windows.Forms.Button cmdQRback;
        private System.Windows.Forms.PictureBox picQRscan;
        private System.Windows.Forms.ComboBox cboDevice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmdQRrun;
        private System.Windows.Forms.Button cmdQRstop;
        private System.Windows.Forms.Timer timerQRpic;
    }
}

