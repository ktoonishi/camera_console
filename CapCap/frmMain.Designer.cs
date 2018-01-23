namespace camera_console
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnTest = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tbSetting = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbReso = new System.Windows.Forms.ComboBox();
            this.lblCapSize = new System.Windows.Forms.Label();
            this.gbIP = new System.Windows.Forms.GroupBox();
            this.chkMirror = new System.Windows.Forms.CheckBox();
            this.cmbTimer = new System.Windows.Forms.ComboBox();
            this.cmbCam = new System.Windows.Forms.ComboBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbtnSave_Other = new System.Windows.Forms.LinkLabel();
            this.btnSave_Other = new System.Windows.Forms.Button();
            this.rbtnSave_Dialog = new System.Windows.Forms.RadioButton();
            this.rbtnSave_Other = new System.Windows.Forms.RadioButton();
            this.rbtnSave_Desktop = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSnumU = new System.Windows.Forms.NumericUpDown();
            this.txtSnumB = new System.Windows.Forms.NumericUpDown();
            this.lblExt = new System.Windows.Forms.Label();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.txtSnum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbExt = new System.Windows.Forms.ComboBox();
            this.lblExt_Discription = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnLicenseOC3 = new System.Windows.Forms.Button();
            this.lblTimerCount = new System.Windows.Forms.Label();
            this.chkTimer = new System.Windows.Forms.CheckBox();
            this.btnCapture = new System.Windows.Forms.Button();
            this.timCap = new System.Windows.Forms.Timer(this.components);
            this.stb = new System.Windows.Forms.StatusStrip();
            this.lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblReso_Bar = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDebug = new System.Windows.Forms.ToolStripStatusLabel();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ofdSavePath = new System.Windows.Forms.OpenFileDialog();
            this.timClk1Sec = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tbSetting.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbIP.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnumU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnumB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnum)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.stb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTest);
            this.splitContainer1.Panel1.Controls.Add(this.pic);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1163, 703);
            this.splitContainer1.SplitterDistance = 907;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 16);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(106, 48);
            this.btnTest.TabIndex = 4;
            this.btnTest.Text = "テスト";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(907, 703);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tbSetting);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblTimerCount);
            this.splitContainer2.Panel2.Controls.Add(this.chkTimer);
            this.splitContainer2.Panel2.Controls.Add(this.btnCapture);
            this.splitContainer2.Size = new System.Drawing.Size(252, 703);
            this.splitContainer2.SplitterDistance = 509;
            this.splitContainer2.TabIndex = 0;
            // 
            // tbSetting
            // 
            this.tbSetting.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tbSetting.Controls.Add(this.tabPage1);
            this.tbSetting.Controls.Add(this.tabPage2);
            this.tbSetting.Controls.Add(this.tabPage3);
            this.tbSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSetting.Location = new System.Drawing.Point(0, 0);
            this.tbSetting.Multiline = true;
            this.tbSetting.Name = "tbSetting";
            this.tbSetting.SelectedIndex = 0;
            this.tbSetting.Size = new System.Drawing.Size(252, 509);
            this.tbSetting.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbSetting.TabIndex = 0;
            this.tbSetting.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.lblTimer);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbReso);
            this.tabPage1.Controls.Add(this.lblCapSize);
            this.tabPage1.Controls.Add(this.gbIP);
            this.tabPage1.Controls.Add(this.cmbTimer);
            this.tabPage1.Controls.Add(this.cmbCam);
            this.tabPage1.Controls.Add(this.lblCap);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(216, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "いろいろ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(14, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 76);
            this.label4.TabIndex = 12;
            this.label4.Text = "手入力も可能\r\n定期的に撮るに\r\nチェックをいれると\r\nタイマー撮影";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTimer.Location = new System.Drawing.Point(145, 178);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(24, 19);
            this.lblTimer.TabIndex = 11;
            this.lblTimer.Text = "秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "タイマー撮り";
            // 
            // cmbReso
            // 
            this.cmbReso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReso.FormattingEnabled = true;
            this.cmbReso.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbReso.Location = new System.Drawing.Point(10, 99);
            this.cmbReso.Name = "cmbReso";
            this.cmbReso.Size = new System.Drawing.Size(196, 30);
            this.cmbReso.TabIndex = 9;
            this.cmbReso.SelectedIndexChanged += new System.EventHandler(this.cmbReso_SelectedIndexChanged);
            // 
            // lblCapSize
            // 
            this.lblCapSize.AutoSize = true;
            this.lblCapSize.Location = new System.Drawing.Point(6, 70);
            this.lblCapSize.Name = "lblCapSize";
            this.lblCapSize.Size = new System.Drawing.Size(98, 22);
            this.lblCapSize.TabIndex = 3;
            this.lblCapSize.Text = "画面のサイズ";
            // 
            // gbIP
            // 
            this.gbIP.Controls.Add(this.chkMirror);
            this.gbIP.Location = new System.Drawing.Point(6, 345);
            this.gbIP.Name = "gbIP";
            this.gbIP.Size = new System.Drawing.Size(200, 150);
            this.gbIP.TabIndex = 2;
            this.gbIP.TabStop = false;
            this.gbIP.Text = "画像処理";
            // 
            // chkMirror
            // 
            this.chkMirror.AutoSize = true;
            this.chkMirror.Location = new System.Drawing.Point(12, 28);
            this.chkMirror.Name = "chkMirror";
            this.chkMirror.Size = new System.Drawing.Size(147, 26);
            this.chkMirror.TabIndex = 0;
            this.chkMirror.Text = "画像を左右反転";
            this.chkMirror.UseVisualStyleBackColor = true;
            // 
            // cmbTimer
            // 
            this.cmbTimer.BackColor = System.Drawing.SystemColors.Info;
            this.cmbTimer.FormattingEnabled = true;
            this.cmbTimer.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60",
            "300",
            "600"});
            this.cmbTimer.Location = new System.Drawing.Point(10, 167);
            this.cmbTimer.MaxLength = 4;
            this.cmbTimer.Name = "cmbTimer";
            this.cmbTimer.Size = new System.Drawing.Size(129, 30);
            this.cmbTimer.TabIndex = 1;
            this.cmbTimer.TextChanged += new System.EventHandler(this.cmbTimer_TextChanged);
            // 
            // cmbCam
            // 
            this.cmbCam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCam.FormattingEnabled = true;
            this.cmbCam.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.cmbCam.Location = new System.Drawing.Point(10, 30);
            this.cmbCam.Name = "cmbCam";
            this.cmbCam.Size = new System.Drawing.Size(129, 30);
            this.cmbCam.TabIndex = 1;
            this.cmbCam.SelectedIndexChanged += new System.EventHandler(this.cmbCam_SelectedIndexChanged);
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Location = new System.Drawing.Point(6, 5);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(84, 22);
            this.lblCap.TabIndex = 0;
            this.lblCap.Text = "つかうカメラ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lblName);
            this.tabPage2.Controls.Add(this.cmbExt);
            this.tabPage2.Controls.Add(this.lblExt_Discription);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(216, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "保存";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbtnSave_Other);
            this.groupBox2.Controls.Add(this.btnSave_Other);
            this.groupBox2.Controls.Add(this.rbtnSave_Dialog);
            this.groupBox2.Controls.Add(this.rbtnSave_Other);
            this.groupBox2.Controls.Add(this.rbtnSave_Desktop);
            this.groupBox2.Location = new System.Drawing.Point(10, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 205);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "保存先";
            // 
            // lbtnSave_Other
            // 
            this.lbtnSave_Other.AutoEllipsis = true;
            this.lbtnSave_Other.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbtnSave_Other.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbtnSave_Other.Location = new System.Drawing.Point(6, 125);
            this.lbtnSave_Other.Name = "lbtnSave_Other";
            this.lbtnSave_Other.Size = new System.Drawing.Size(184, 77);
            this.lbtnSave_Other.TabIndex = 11;
            this.lbtnSave_Other.TabStop = true;
            this.lbtnSave_Other.Text = "設定されてません";
            this.lbtnSave_Other.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbtnSave_Other_LinkClicked);
            // 
            // btnSave_Other
            // 
            this.btnSave_Other.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSave_Other.Location = new System.Drawing.Point(142, 89);
            this.btnSave_Other.Name = "btnSave_Other";
            this.btnSave_Other.Size = new System.Drawing.Size(48, 33);
            this.btnSave_Other.TabIndex = 10;
            this.btnSave_Other.Text = "設定";
            this.btnSave_Other.UseVisualStyleBackColor = true;
            this.btnSave_Other.Click += new System.EventHandler(this.btnSave_Other_Click);
            // 
            // rbtnSave_Dialog
            // 
            this.rbtnSave_Dialog.AutoSize = true;
            this.rbtnSave_Dialog.Location = new System.Drawing.Point(6, 60);
            this.rbtnSave_Dialog.Name = "rbtnSave_Dialog";
            this.rbtnSave_Dialog.Size = new System.Drawing.Size(87, 26);
            this.rbtnSave_Dialog.TabIndex = 9;
            this.rbtnSave_Dialog.Text = "毎回きく";
            this.rbtnSave_Dialog.UseVisualStyleBackColor = true;
            // 
            // rbtnSave_Other
            // 
            this.rbtnSave_Other.AutoSize = true;
            this.rbtnSave_Other.Location = new System.Drawing.Point(6, 96);
            this.rbtnSave_Other.Name = "rbtnSave_Other";
            this.rbtnSave_Other.Size = new System.Drawing.Size(144, 26);
            this.rbtnSave_Other.TabIndex = 7;
            this.rbtnSave_Other.Text = "それ以外のどこか";
            this.rbtnSave_Other.UseVisualStyleBackColor = true;
            // 
            // rbtnSave_Desktop
            // 
            this.rbtnSave_Desktop.AutoSize = true;
            this.rbtnSave_Desktop.Checked = true;
            this.rbtnSave_Desktop.Location = new System.Drawing.Point(6, 28);
            this.rbtnSave_Desktop.Name = "rbtnSave_Desktop";
            this.rbtnSave_Desktop.Size = new System.Drawing.Size(104, 26);
            this.rbtnSave_Desktop.TabIndex = 6;
            this.rbtnSave_Desktop.TabStop = true;
            this.rbtnSave_Desktop.Text = "ですくとっぷ";
            this.rbtnSave_Desktop.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSnumU);
            this.groupBox1.Controls.Add(this.txtSnumB);
            this.groupBox1.Controls.Add(this.lblExt);
            this.groupBox1.Controls.Add(this.chkDate);
            this.groupBox1.Controls.Add(this.txtSnum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(10, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 205);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ファイル名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(8, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "* が連番に置換わる！";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(96, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "～";
            // 
            // txtSnumU
            // 
            this.txtSnumU.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSnumU.Location = new System.Drawing.Point(121, 101);
            this.txtSnumU.Name = "txtSnumU";
            this.txtSnumU.Size = new System.Drawing.Size(62, 27);
            this.txtSnumU.TabIndex = 6;
            this.txtSnumU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSnumU.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.txtSnumU.ValueChanged += new System.EventHandler(this.txtSnumU_ValueChanged);
            // 
            // txtSnumB
            // 
            this.txtSnumB.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSnumB.Location = new System.Drawing.Point(31, 101);
            this.txtSnumB.Name = "txtSnumB";
            this.txtSnumB.Size = new System.Drawing.Size(62, 27);
            this.txtSnumB.TabIndex = 5;
            this.txtSnumB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSnumB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSnumB.ValueChanged += new System.EventHandler(this.txtSnumB_ValueChanged);
            // 
            // lblExt
            // 
            this.lblExt.AutoSize = true;
            this.lblExt.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblExt.Location = new System.Drawing.Point(157, 33);
            this.lblExt.Name = "lblExt";
            this.lblExt.Size = new System.Drawing.Size(41, 19);
            this.lblExt.TabIndex = 4;
            this.lblExt.Text = ".png";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(6, 173);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(184, 26);
            this.chkDate.TabIndex = 3;
            this.chkDate.Text = "ファイル名+日付にする";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // txtSnum
            // 
            this.txtSnum.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSnum.Location = new System.Drawing.Point(121, 63);
            this.txtSnum.Name = "txtSnum";
            this.txtSnum.Size = new System.Drawing.Size(62, 27);
            this.txtSnum.TabIndex = 2;
            this.txtSnum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSnum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSnum.ValueChanged += new System.EventHandler(this.txtSnum_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(30, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "つぎの連番";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.Info;
            this.txtName.Location = new System.Drawing.Point(6, 28);
            this.txtName.MaxLength = 32;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(148, 29);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "test*";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 91);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 22);
            this.lblName.TabIndex = 3;
            // 
            // cmbExt
            // 
            this.cmbExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExt.FormattingEnabled = true;
            this.cmbExt.Location = new System.Drawing.Point(16, 30);
            this.cmbExt.Name = "cmbExt";
            this.cmbExt.Size = new System.Drawing.Size(119, 30);
            this.cmbExt.TabIndex = 2;
            this.cmbExt.SelectedIndexChanged += new System.EventHandler(this.cmbExt_SelectedIndexChanged);
            // 
            // lblExt_Discription
            // 
            this.lblExt_Discription.AutoSize = true;
            this.lblExt_Discription.Location = new System.Drawing.Point(6, 5);
            this.lblExt_Discription.Name = "lblExt_Discription";
            this.lblExt_Discription.Size = new System.Drawing.Size(101, 22);
            this.lblExt_Discription.TabIndex = 1;
            this.lblExt_Discription.Text = "ほぞんの形式";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLicenseOC3);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(216, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Licence";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLicenseOC3
            // 
            this.btnLicenseOC3.Location = new System.Drawing.Point(6, 12);
            this.btnLicenseOC3.Name = "btnLicenseOC3";
            this.btnLicenseOC3.Size = new System.Drawing.Size(204, 72);
            this.btnLicenseOC3.TabIndex = 0;
            this.btnLicenseOC3.Text = "OpenCV3";
            this.btnLicenseOC3.UseVisualStyleBackColor = true;
            this.btnLicenseOC3.Click += new System.EventHandler(this.btnLicenseOC3_Click);
            // 
            // lblTimerCount
            // 
            this.lblTimerCount.Font = new System.Drawing.Font("Meiryo UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTimerCount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTimerCount.Location = new System.Drawing.Point(16, 66);
            this.lblTimerCount.Name = "lblTimerCount";
            this.lblTimerCount.Size = new System.Drawing.Size(204, 52);
            this.lblTimerCount.TabIndex = 3;
            this.lblTimerCount.Text = "あと ";
            this.lblTimerCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimerCount.Visible = false;
            // 
            // chkTimer
            // 
            this.chkTimer.AutoSize = true;
            this.chkTimer.Location = new System.Drawing.Point(10, 2);
            this.chkTimer.Name = "chkTimer";
            this.chkTimer.Size = new System.Drawing.Size(126, 26);
            this.chkTimer.TabIndex = 2;
            this.chkTimer.Text = "定期的に撮る";
            this.chkTimer.UseVisualStyleBackColor = true;
            this.chkTimer.CheckedChanged += new System.EventHandler(this.chkTimer_CheckedChanged);
            // 
            // btnCapture
            // 
            this.btnCapture.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCapture.Location = new System.Drawing.Point(4, 34);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(237, 124);
            this.btnCapture.TabIndex = 1;
            this.btnCapture.Text = "撮";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // timCap
            // 
            this.timCap.Interval = 50;
            this.timCap.Tick += new System.EventHandler(this.timCap_Tick);
            // 
            // stb
            // 
            this.stb.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stb.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMessage,
            this.lblReso_Bar,
            this.lblDebug});
            this.stb.Location = new System.Drawing.Point(0, 674);
            this.stb.Name = "stb";
            this.stb.Size = new System.Drawing.Size(1163, 29);
            this.stb.TabIndex = 1;
            this.stb.Text = "statusStrip1";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = false;
            this.lblMessage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(600, 24);
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReso_Bar
            // 
            this.lblReso_Bar.AutoSize = false;
            this.lblReso_Bar.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblReso_Bar.Name = "lblReso_Bar";
            this.lblReso_Bar.Size = new System.Drawing.Size(120, 24);
            // 
            // lblDebug
            // 
            this.lblDebug.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(43, 24);
            this.lblDebug.Text = "-----";
            // 
            // sfdSaveFile
            // 
            this.sfdSaveFile.Filter = "画像ファイル (*.png; *.bmp; *.jpg) | *.png, *.bmp, *.jpg | すべてのファイル (*.*) | *.*";
            // 
            // ofdSavePath
            // 
            this.ofdSavePath.AddExtension = false;
            this.ofdSavePath.CheckFileExists = false;
            this.ofdSavePath.FileName = "この欄はそのまま";
            this.ofdSavePath.Filter = "すべてのファイル (*.*) | *.*";
            this.ofdSavePath.Title = "保存するフォルダを選択する";
            this.ofdSavePath.ValidateNames = false;
            // 
            // timClk1Sec
            // 
            this.timClk1Sec.Interval = 1000;
            this.timClk1Sec.Tick += new System.EventHandler(this.timClk1Sec_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 703);
            this.Controls.Add(this.stb);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "カメラコンソール";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tbSetting.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbIP.ResumeLayout(false);
            this.gbIP.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnumU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnumB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnum)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.stb.ResumeLayout(false);
            this.stb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.TabControl tbSetting;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblCapSize;
        private System.Windows.Forms.GroupBox gbIP;
        private System.Windows.Forms.ComboBox cmbCam;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbExt;
        private System.Windows.Forms.Label lblExt_Discription;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cmbReso;
        private System.Windows.Forms.Timer timCap;
        private System.Windows.Forms.StatusStrip stb;
        private System.Windows.Forms.ToolStripStatusLabel lblDebug;
        private System.Windows.Forms.Label lblExt;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.NumericUpDown txtSnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnSave_Other;
        private System.Windows.Forms.RadioButton rbtnSave_Desktop;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.ToolStripStatusLabel lblReso_Bar;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.RadioButton rbtnSave_Dialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtSnumU;
        private System.Windows.Forms.NumericUpDown txtSnumB;
        private System.Windows.Forms.Button btnSave_Other;
        private System.Windows.Forms.OpenFileDialog ofdSavePath;
        private System.Windows.Forms.LinkLabel lbtnSave_Other;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTimer;
        private System.Windows.Forms.CheckBox chkTimer;
        private System.Windows.Forms.Label lblTimerCount;
        private System.Windows.Forms.Timer timClk1Sec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkMirror;
        private System.Windows.Forms.Button btnLicenseOC3;
    }
}

