namespace اذكاري
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHigriDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpAzkar = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbMasbaha = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnChangeTasbeh = new System.Windows.Forms.Button();
            this.btnStartTasbeh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSaveMasbaha = new System.Windows.Forms.Button();
            this.tbTypeZeker = new System.Windows.Forms.TextBox();
            this.btnStartTImer = new System.Windows.Forms.Button();
            this.btnStopTimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnResetTasbeh = new System.Windows.Forms.Button();
            this.btnDecreaseTasbeh = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnIncremantTasbeh = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tbHistory = new System.Windows.Forms.TabPage();
            this.lblNoData = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDeleteAzkar = new System.Windows.Forms.Button();
            this.btnDeleteMasbaha = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnForeColor = new System.Windows.Forms.Button();
            this.btnBackColor = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpAzkar.SuspendLayout();
            this.tbMasbaha.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tbHistory.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblHigriDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblDay);
            this.panel1.Controls.Add(this.lblHour);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 35);
            this.panel1.TabIndex = 512;
            // 
            // lblHigriDate
            // 
            this.lblHigriDate.AutoSize = true;
            this.lblHigriDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHigriDate.Location = new System.Drawing.Point(29, 6);
            this.lblHigriDate.Name = "lblHigriDate";
            this.lblHigriDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblHigriDate.Size = new System.Drawing.Size(73, 21);
            this.lblHigriDate.TabIndex = 7;
            this.lblHigriDate.Text = "11-07-1447";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 6);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "التاريخ الهجري : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(287, 6);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 21);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "12-12-2026";
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(497, 6);
            this.lblDay.Name = "lblDay";
            this.lblDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDay.Size = new System.Drawing.Size(49, 21);
            this.lblDay.TabIndex = 4;
            this.lblDay.Text = "الاثنين";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.Location = new System.Drawing.Point(649, 6);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(48, 21);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "8 : 00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(408, 6);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "التاريخ : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 6);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "اليوم :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(724, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "الساعة : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpAzkar);
            this.tabControl1.Controls.Add(this.tbMasbaha);
            this.tabControl1.Controls.Add(this.tbHistory);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(2, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tpAzkar
            // 
            this.tpAzkar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpAzkar.Controls.Add(this.flowLayoutPanel1);
            this.tpAzkar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAzkar.Location = new System.Drawing.Point(4, 26);
            this.tpAzkar.Name = "tpAzkar";
            this.tpAzkar.Padding = new System.Windows.Forms.Padding(3);
            this.tpAzkar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tpAzkar.Size = new System.Drawing.Size(787, 378);
            this.tpAzkar.TabIndex = 0;
            this.tpAzkar.Text = "اذكار الصباح و المساء";
            this.tpAzkar.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, -1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(782, 381);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tbMasbaha
            // 
            this.tbMasbaha.BackColor = System.Drawing.Color.Transparent;
            this.tbMasbaha.Controls.Add(this.panel5);
            this.tbMasbaha.Controls.Add(this.panel2);
            this.tbMasbaha.Controls.Add(this.numericUpDown1);
            this.tbMasbaha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMasbaha.Location = new System.Drawing.Point(4, 26);
            this.tbMasbaha.Name = "tbMasbaha";
            this.tbMasbaha.Padding = new System.Windows.Forms.Padding(3);
            this.tbMasbaha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbMasbaha.Size = new System.Drawing.Size(787, 378);
            this.tbMasbaha.TabIndex = 1;
            this.tbMasbaha.Text = "المسبحة";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnChangeTasbeh);
            this.panel5.Controls.Add(this.btnStartTasbeh);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.btnSaveMasbaha);
            this.panel5.Controls.Add(this.tbTypeZeker);
            this.panel5.Controls.Add(this.btnStartTImer);
            this.panel5.Controls.Add(this.btnStopTimer);
            this.panel5.Location = new System.Drawing.Point(6, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(159, 362);
            this.panel5.TabIndex = 9;
            // 
            // btnChangeTasbeh
            // 
            this.btnChangeTasbeh.BackColor = System.Drawing.Color.Lime;
            this.btnChangeTasbeh.Enabled = false;
            this.btnChangeTasbeh.ForeColor = System.Drawing.Color.Black;
            this.btnChangeTasbeh.Location = new System.Drawing.Point(20, 86);
            this.btnChangeTasbeh.Name = "btnChangeTasbeh";
            this.btnChangeTasbeh.Size = new System.Drawing.Size(45, 34);
            this.btnChangeTasbeh.TabIndex = 10;
            this.btnChangeTasbeh.Text = "تغيير";
            this.btnChangeTasbeh.UseVisualStyleBackColor = false;
            this.btnChangeTasbeh.Click += new System.EventHandler(this.btnChangeTasbeh_Click);
            // 
            // btnStartTasbeh
            // 
            this.btnStartTasbeh.BackColor = System.Drawing.Color.Lime;
            this.btnStartTasbeh.ForeColor = System.Drawing.Color.Black;
            this.btnStartTasbeh.Location = new System.Drawing.Point(100, 86);
            this.btnStartTasbeh.Name = "btnStartTasbeh";
            this.btnStartTasbeh.Size = new System.Drawing.Size(45, 34);
            this.btnStartTasbeh.TabIndex = 9;
            this.btnStartTasbeh.Text = "بدأ ";
            this.btnStartTasbeh.UseVisualStyleBackColor = false;
            this.btnStartTasbeh.Click += new System.EventHandler(this.btnStartTasbeh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(59, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "نوع التسبيح :";
            // 
            // btnSaveMasbaha
            // 
            this.btnSaveMasbaha.BackColor = System.Drawing.Color.Gray;
            this.btnSaveMasbaha.Enabled = false;
            this.btnSaveMasbaha.ForeColor = System.Drawing.Color.White;
            this.btnSaveMasbaha.Location = new System.Drawing.Point(20, 298);
            this.btnSaveMasbaha.Name = "btnSaveMasbaha";
            this.btnSaveMasbaha.Size = new System.Drawing.Size(125, 51);
            this.btnSaveMasbaha.TabIndex = 6;
            this.btnSaveMasbaha.Text = "حفظ";
            this.btnSaveMasbaha.UseVisualStyleBackColor = false;
            this.btnSaveMasbaha.EnabledChanged += new System.EventHandler(this.btnSave_EnabledChanged);
            this.btnSaveMasbaha.Click += new System.EventHandler(this.btnSaveMasbaha_Click);
            // 
            // tbTypeZeker
            // 
            this.tbTypeZeker.Location = new System.Drawing.Point(5, 55);
            this.tbTypeZeker.Name = "tbTypeZeker";
            this.tbTypeZeker.Size = new System.Drawing.Size(151, 25);
            this.tbTypeZeker.TabIndex = 7;
            // 
            // btnStartTImer
            // 
            this.btnStartTImer.BackColor = System.Drawing.Color.Gray;
            this.btnStartTImer.Enabled = false;
            this.btnStartTImer.ForeColor = System.Drawing.Color.White;
            this.btnStartTImer.Location = new System.Drawing.Point(20, 154);
            this.btnStartTImer.Name = "btnStartTImer";
            this.btnStartTImer.Size = new System.Drawing.Size(125, 51);
            this.btnStartTImer.TabIndex = 2;
            this.btnStartTImer.Text = "بدأ المؤقت";
            this.btnStartTImer.UseVisualStyleBackColor = false;
            this.btnStartTImer.EnabledChanged += new System.EventHandler(this.btns_EnableChanged);
            this.btnStartTImer.Click += new System.EventHandler(this.btnStartTImer_Click);
            // 
            // btnStopTimer
            // 
            this.btnStopTimer.BackColor = System.Drawing.Color.Gray;
            this.btnStopTimer.Enabled = false;
            this.btnStopTimer.ForeColor = System.Drawing.Color.White;
            this.btnStopTimer.Location = new System.Drawing.Point(20, 211);
            this.btnStopTimer.Name = "btnStopTimer";
            this.btnStopTimer.Size = new System.Drawing.Size(125, 51);
            this.btnStopTimer.TabIndex = 3;
            this.btnStopTimer.Text = "ايقاف المؤقت";
            this.btnStopTimer.UseVisualStyleBackColor = false;
            this.btnStopTimer.EnabledChanged += new System.EventHandler(this.btns_EnableChanged);
            this.btnStopTimer.Click += new System.EventHandler(this.btnStopTimer_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnResetTasbeh);
            this.panel2.Controls.Add(this.btnDecreaseTasbeh);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnIncremantTasbeh);
            this.panel2.Location = new System.Drawing.Point(171, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 255);
            this.panel2.TabIndex = 5;
            // 
            // btnResetTasbeh
            // 
            this.btnResetTasbeh.BackColor = System.Drawing.Color.Gray;
            this.btnResetTasbeh.BackgroundImage = global::اذكاري.Properties.Resources.download__1_;
            this.btnResetTasbeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetTasbeh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetTasbeh.Enabled = false;
            this.btnResetTasbeh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResetTasbeh.ForeColor = System.Drawing.Color.White;
            this.btnResetTasbeh.Location = new System.Drawing.Point(37, 113);
            this.btnResetTasbeh.Name = "btnResetTasbeh";
            this.btnResetTasbeh.Size = new System.Drawing.Size(120, 121);
            this.btnResetTasbeh.TabIndex = 6;
            this.btnResetTasbeh.UseVisualStyleBackColor = false;
            this.btnResetTasbeh.Click += new System.EventHandler(this.btnResetTasbeh_click);
            // 
            // btnDecreaseTasbeh
            // 
            this.btnDecreaseTasbeh.BackColor = System.Drawing.Color.Green;
            this.btnDecreaseTasbeh.BackgroundImage = global::اذكاري.Properties.Resources._22;
            this.btnDecreaseTasbeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDecreaseTasbeh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDecreaseTasbeh.Enabled = false;
            this.btnDecreaseTasbeh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecreaseTasbeh.ForeColor = System.Drawing.Color.White;
            this.btnDecreaseTasbeh.Location = new System.Drawing.Point(241, 113);
            this.btnDecreaseTasbeh.Name = "btnDecreaseTasbeh";
            this.btnDecreaseTasbeh.Size = new System.Drawing.Size(120, 121);
            this.btnDecreaseTasbeh.TabIndex = 5;
            this.btnDecreaseTasbeh.UseVisualStyleBackColor = false;
            this.btnDecreaseTasbeh.Click += new System.EventHandler(this.btnDecreaseTasbeh_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblNumber);
            this.panel3.Location = new System.Drawing.Point(11, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(586, 85);
            this.panel3.TabIndex = 1;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(266, 10);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNumber.Size = new System.Drawing.Size(56, 65);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "0";
            // 
            // btnIncremantTasbeh
            // 
            this.btnIncremantTasbeh.BackColor = System.Drawing.Color.Green;
            this.btnIncremantTasbeh.BackgroundImage = global::اذكاري.Properties.Resources._11;
            this.btnIncremantTasbeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncremantTasbeh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIncremantTasbeh.Enabled = false;
            this.btnIncremantTasbeh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncremantTasbeh.ForeColor = System.Drawing.Color.White;
            this.btnIncremantTasbeh.Location = new System.Drawing.Point(445, 113);
            this.btnIncremantTasbeh.Name = "btnIncremantTasbeh";
            this.btnIncremantTasbeh.Size = new System.Drawing.Size(120, 121);
            this.btnIncremantTasbeh.TabIndex = 4;
            this.btnIncremantTasbeh.UseVisualStyleBackColor = false;
            this.btnIncremantTasbeh.Click += new System.EventHandler(this.btnIncremantTasbeh_click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Lime;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(171, 287);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(610, 71);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tbHistory
            // 
            this.tbHistory.Controls.Add(this.lblNoData);
            this.tbHistory.Controls.Add(this.flowLayoutPanel2);
            this.tbHistory.Controls.Add(this.panel4);
            this.tbHistory.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHistory.Location = new System.Drawing.Point(4, 26);
            this.tbHistory.Name = "tbHistory";
            this.tbHistory.Size = new System.Drawing.Size(787, 378);
            this.tbHistory.TabIndex = 2;
            this.tbHistory.Text = "السجلات";
            this.tbHistory.UseVisualStyleBackColor = true;
            // 
            // lblNoData
            // 
            this.lblNoData.AutoSize = true;
            this.lblNoData.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoData.ForeColor = System.Drawing.Color.Gray;
            this.lblNoData.Location = new System.Drawing.Point(269, 196);
            this.lblNoData.Name = "lblNoData";
            this.lblNoData.Size = new System.Drawing.Size(236, 47);
            this.lblNoData.TabIndex = 7;
            this.lblNoData.Text = "لا يوجد بيانات !";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 93);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(776, 278);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDeleteAzkar);
            this.panel4.Controls.Add(this.btnDeleteMasbaha);
            this.panel4.Controls.Add(this.button7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button8);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnForeColor);
            this.panel4.Controls.Add(this.btnBackColor);
            this.panel4.Location = new System.Drawing.Point(26, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(737, 67);
            this.panel4.TabIndex = 8;
            // 
            // btnDeleteAzkar
            // 
            this.btnDeleteAzkar.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteAzkar.Enabled = false;
            this.btnDeleteAzkar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAzkar.ForeColor = System.Drawing.Color.White;
            this.btnDeleteAzkar.Location = new System.Drawing.Point(518, 9);
            this.btnDeleteAzkar.Name = "btnDeleteAzkar";
            this.btnDeleteAzkar.Size = new System.Drawing.Size(55, 44);
            this.btnDeleteAzkar.TabIndex = 10;
            this.btnDeleteAzkar.Text = "حذف الاذكار";
            this.btnDeleteAzkar.UseVisualStyleBackColor = false;
            this.btnDeleteAzkar.EnabledChanged += new System.EventHandler(this.btns_EnableChanged);
            this.btnDeleteAzkar.Click += new System.EventHandler(this.btnDeleteAzkar_Click);
            // 
            // btnDeleteMasbaha
            // 
            this.btnDeleteMasbaha.BackColor = System.Drawing.Color.Gray;
            this.btnDeleteMasbaha.Enabled = false;
            this.btnDeleteMasbaha.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMasbaha.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMasbaha.Location = new System.Drawing.Point(457, 9);
            this.btnDeleteMasbaha.Name = "btnDeleteMasbaha";
            this.btnDeleteMasbaha.Size = new System.Drawing.Size(55, 44);
            this.btnDeleteMasbaha.TabIndex = 9;
            this.btnDeleteMasbaha.Text = "حذف التسابيح";
            this.btnDeleteMasbaha.UseVisualStyleBackColor = false;
            this.btnDeleteMasbaha.EnabledChanged += new System.EventHandler(this.btns_EnableChanged);
            this.btnDeleteMasbaha.Click += new System.EventHandler(this.btnDeleteMasbaha_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Lime;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(207, 9);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "لون الخلفية";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(622, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "السجلات :";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Lime;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(146, 9);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 44);
            this.button8.TabIndex = 8;
            this.button8.Text = "لون الصفحة";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(280, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 39);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "حفظ السجلات";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.EnabledChanged += new System.EventHandler(this.btnSave_EnabledChanged);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnForeColor
            // 
            this.btnForeColor.BackColor = System.Drawing.Color.Lime;
            this.btnForeColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForeColor.Location = new System.Drawing.Point(24, 9);
            this.btnForeColor.Name = "btnForeColor";
            this.btnForeColor.Size = new System.Drawing.Size(55, 44);
            this.btnForeColor.TabIndex = 6;
            this.btnForeColor.Text = "تغيير الخط";
            this.btnForeColor.UseVisualStyleBackColor = false;
            this.btnForeColor.Click += new System.EventHandler(this.btnForeColor_Click);
            // 
            // btnBackColor
            // 
            this.btnBackColor.BackColor = System.Drawing.Color.Lime;
            this.btnBackColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackColor.Location = new System.Drawing.Point(85, 9);
            this.btnBackColor.Name = "btnBackColor";
            this.btnBackColor.Size = new System.Drawing.Size(55, 44);
            this.btnBackColor.TabIndex = 5;
            this.btnBackColor.Text = "لون العنصر";
            this.btnBackColor.UseVisualStyleBackColor = false;
            this.btnBackColor.Click += new System.EventHandler(this.btnBackColor_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 60000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "أذكاري";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpAzkar.ResumeLayout(false);
            this.tbMasbaha.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tbHistory.ResumeLayout(false);
            this.tbHistory.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpAzkar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tbMasbaha;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbHistory;
        private System.Windows.Forms.Label lblHigriDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnStartTImer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnStopTimer;
        private System.Windows.Forms.Button btnIncremantTasbeh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDecreaseTasbeh;
        private System.Windows.Forms.Button btnResetTasbeh;
        private System.Windows.Forms.Button btnSaveMasbaha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTypeZeker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnForeColor;
        private System.Windows.Forms.Button btnBackColor;
        private System.Windows.Forms.Label lblNoData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnStartTasbeh;
        private System.Windows.Forms.Button btnChangeTasbeh;
        private System.Windows.Forms.Button btnDeleteAzkar;
        private System.Windows.Forms.Button btnDeleteMasbaha;
    }
}

