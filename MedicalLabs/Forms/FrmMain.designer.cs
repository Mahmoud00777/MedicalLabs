namespace MedicalLabs
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnResource = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnTechnical = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnBuyInvoice = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnPaient = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tslSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tslUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tslMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.tslTreasury = new System.Windows.Forms.ToolStripMenuItem();
            this.tslEmployee = new System.Windows.Forms.ToolStripMenuItem();
            this.tslInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.tslDel = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 28);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMax);
            this.panel3.Controls.Add(this.btnMin);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(94, 28);
            this.panel3.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::MedicalLabs.Properties.Resources.maximize;
            this.btnMax.Location = new System.Drawing.Point(60, 1);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(27, 24);
            this.btnMax.TabIndex = 2;
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::MedicalLabs.Properties.Resources.minimize_sign;
            this.btnMin.Location = new System.Drawing.Point(31, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(27, 24);
            this.btnMin.TabIndex = 1;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::MedicalLabs.Properties.Resources.close_button;
            this.btnClose.Location = new System.Drawing.Point(3, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(26, 24);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslDateTime,
            this.tslUser,
            this.tslMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 734);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1154, 26);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslDateTime
            // 
            this.tslDateTime.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslDateTime.Name = "tslDateTime";
            this.tslDateTime.Size = new System.Drawing.Size(98, 21);
            this.tslDateTime.Text = "الساعة و التاريخ";
            // 
            // tslUser
            // 
            this.tslUser.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslUser.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.tslUser.Name = "tslUser";
            this.tslUser.Size = new System.Drawing.Size(125, 21);
            this.tslUser.Text = "مستخدم المنظومة";
            // 
            // tslMessage
            // 
            this.tslMessage.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslMessage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslMessage.Margin = new System.Windows.Forms.Padding(300, 3, 0, 2);
            this.tslMessage.Name = "tslMessage";
            this.tslMessage.Size = new System.Drawing.Size(81, 21);
            this.tslMessage.Text = "تأكيد الحفظ";
            this.tslMessage.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnChart);
            this.pnlMenu.Controls.Add(this.btnResource);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Controls.Add(this.btnTechnical);
            this.pnlMenu.Controls.Add(this.btnAnalysis);
            this.pnlMenu.Controls.Add(this.btnBuyInvoice);
            this.pnlMenu.Controls.Add(this.btnStore);
            this.pnlMenu.Controls.Add(this.btnItem);
            this.pnlMenu.Controls.Add(this.btnPaient);
            this.pnlMenu.Controls.Add(this.btnResult);
            this.pnlMenu.Controls.Add(this.btnInvoice);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(939, 56);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(215, 678);
            this.pnlMenu.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Image = global::MedicalLabs.Properties.Resources.logout;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(-1, 628);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(215, 51);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "تسجيل الخروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChart
            // 
            this.btnChart.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChart.FlatAppearance.BorderSize = 0;
            this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChart.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChart.Image = global::MedicalLabs.Properties.Resources.line_chart;
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChart.Location = new System.Drawing.Point(0, 573);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(215, 51);
            this.btnChart.TabIndex = 12;
            this.btnChart.Text = "الاحصائيات";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnResource
            // 
            this.btnResource.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResource.FlatAppearance.BorderSize = 0;
            this.btnResource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResource.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResource.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResource.Image = global::MedicalLabs.Properties.Resources.people;
            this.btnResource.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResource.Location = new System.Drawing.Point(0, 516);
            this.btnResource.Name = "btnResource";
            this.btnResource.Size = new System.Drawing.Size(215, 51);
            this.btnResource.TabIndex = 11;
            this.btnResource.Text = "الموردين";
            this.btnResource.UseVisualStyleBackColor = true;
            this.btnResource.Click += new System.EventHandler(this.btnResource_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.Image = global::MedicalLabs.Properties.Resources.report;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.Location = new System.Drawing.Point(1, 62);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(215, 51);
            this.btnReports.TabIndex = 10;
            this.btnReports.Text = "تــــقــــاريــــر";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnTechnical
            // 
            this.btnTechnical.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnTechnical.FlatAppearance.BorderSize = 0;
            this.btnTechnical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTechnical.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTechnical.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTechnical.Image = global::MedicalLabs.Properties.Resources.store;
            this.btnTechnical.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTechnical.Location = new System.Drawing.Point(0, 231);
            this.btnTechnical.Name = "btnTechnical";
            this.btnTechnical.Size = new System.Drawing.Size(215, 51);
            this.btnTechnical.TabIndex = 5;
            this.btnTechnical.Text = "التـــقـــنـيـيـن";
            this.btnTechnical.UseVisualStyleBackColor = true;
            this.btnTechnical.Click += new System.EventHandler(this.btnTechnical_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAnalysis.FlatAppearance.BorderSize = 0;
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAnalysis.Image = global::MedicalLabs.Properties.Resources.medical;
            this.btnAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalysis.Location = new System.Drawing.Point(0, 174);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(216, 51);
            this.btnAnalysis.TabIndex = 9;
            this.btnAnalysis.Text = "التـــحـــالــيــل";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // btnBuyInvoice
            // 
            this.btnBuyInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuyInvoice.FlatAppearance.BorderSize = 0;
            this.btnBuyInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyInvoice.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBuyInvoice.Image = global::MedicalLabs.Properties.Resources.bulk_buying;
            this.btnBuyInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuyInvoice.Location = new System.Drawing.Point(0, 402);
            this.btnBuyInvoice.Name = "btnBuyInvoice";
            this.btnBuyInvoice.Size = new System.Drawing.Size(215, 51);
            this.btnBuyInvoice.TabIndex = 8;
            this.btnBuyInvoice.Text = "المـــشــتريات";
            this.btnBuyInvoice.UseVisualStyleBackColor = true;
            this.btnBuyInvoice.Click += new System.EventHandler(this.btnBuyInvoice_Click);
            // 
            // btnStore
            // 
            this.btnStore.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStore.Image = global::MedicalLabs.Properties.Resources.update__1_;
            this.btnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStore.Location = new System.Drawing.Point(0, 345);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(215, 51);
            this.btnStore.TabIndex = 7;
            this.btnStore.Text = "الـمــخـــزن";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnItem
            // 
            this.btnItem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnItem.Image = global::MedicalLabs.Properties.Resources.stand;
            this.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItem.Location = new System.Drawing.Point(0, 459);
            this.btnItem.Name = "btnItem";
            this.btnItem.Size = new System.Drawing.Size(215, 51);
            this.btnItem.TabIndex = 6;
            this.btnItem.Text = "الـــمــواد";
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            // 
            // btnPaient
            // 
            this.btnPaient.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPaient.FlatAppearance.BorderSize = 0;
            this.btnPaient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaient.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPaient.Image = global::MedicalLabs.Properties.Resources.patient;
            this.btnPaient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPaient.Location = new System.Drawing.Point(0, 288);
            this.btnPaient.Name = "btnPaient";
            this.btnPaient.Size = new System.Drawing.Size(215, 51);
            this.btnPaient.TabIndex = 3;
            this.btnPaient.Text = "المرضـــى";
            this.btnPaient.UseVisualStyleBackColor = true;
            this.btnPaient.Click += new System.EventHandler(this.btnPaient_Click);
            // 
            // btnResult
            // 
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnResult.Image = global::MedicalLabs.Properties.Resources.exam;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResult.Location = new System.Drawing.Point(0, 119);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(215, 51);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "النـــتـــائــج";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInvoice.Image = global::MedicalLabs.Properties.Resources.invoices;
            this.btnInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.Location = new System.Drawing.Point(-1, 6);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(216, 51);
            this.btnInvoice.TabIndex = 1;
            this.btnInvoice.Text = "الفــــــــاتــــورة";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.menuStrip1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslSettings,
            this.tslUsers,
            this.tslMonitor,
            this.tslTreasury,
            this.tslEmployee,
            this.tslInventory,
            this.tslDel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1154, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tslSettings
            // 
            this.tslSettings.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslSettings.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslSettings.Image = global::MedicalLabs.Properties.Resources.settings;
            this.tslSettings.Margin = new System.Windows.Forms.Padding(0, 0, 270, 0);
            this.tslSettings.Name = "tslSettings";
            this.tslSettings.Size = new System.Drawing.Size(94, 25);
            this.tslSettings.Text = "الاعــدادات";
            this.tslSettings.Click += new System.EventHandler(this.tslSettings_Click);
            // 
            // tslUsers
            // 
            this.tslUsers.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslUsers.Image = global::MedicalLabs.Properties.Resources.user;
            this.tslUsers.Name = "tslUsers";
            this.tslUsers.Size = new System.Drawing.Size(129, 25);
            this.tslUsers.Text = "المـسـتـخـدمـيـن";
            this.tslUsers.Click += new System.EventHandler(this.tslUsers_Click);
            // 
            // tslMonitor
            // 
            this.tslMonitor.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslMonitor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslMonitor.Image = global::MedicalLabs.Properties.Resources.stand;
            this.tslMonitor.Name = "tslMonitor";
            this.tslMonitor.Size = new System.Drawing.Size(142, 25);
            this.tslMonitor.Text = "شـاشــة المـراقـبـة";
            this.tslMonitor.Click += new System.EventHandler(this.tslMonitor_Click);
            // 
            // tslTreasury
            // 
            this.tslTreasury.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslTreasury.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslTreasury.Image = global::MedicalLabs.Properties.Resources.bank__1_;
            this.tslTreasury.Name = "tslTreasury";
            this.tslTreasury.Size = new System.Drawing.Size(93, 25);
            this.tslTreasury.Text = "الـخــزيـنـة";
            this.tslTreasury.Click += new System.EventHandler(this.tslTreasury_Click);
            // 
            // tslEmployee
            // 
            this.tslEmployee.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslEmployee.Image = global::MedicalLabs.Properties.Resources.employee;
            this.tslEmployee.Name = "tslEmployee";
            this.tslEmployee.Size = new System.Drawing.Size(114, 25);
            this.tslEmployee.Text = "الـمـوظـفـيـن";
            this.tslEmployee.Click += new System.EventHandler(this.tslEmployee_Click);
            // 
            // tslInventory
            // 
            this.tslInventory.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslInventory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslInventory.Image = global::MedicalLabs.Properties.Resources.inventory__1_;
            this.tslInventory.Name = "tslInventory";
            this.tslInventory.Size = new System.Drawing.Size(90, 25);
            this.tslInventory.Text = "الـــجـــــرد";
            this.tslInventory.Click += new System.EventHandler(this.tslInventory_Click);
            // 
            // tslDel
            // 
            this.tslDel.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslDel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tslDel.Image = global::MedicalLabs.Properties.Resources.recycle_bin__1_;
            this.tslDel.Name = "tslDel";
            this.tslDel.Size = new System.Drawing.Size(130, 25);
            this.tslDel.Text = "سلة المحذوفات";
            this.tslDel.Click += new System.EventHandler(this.tslDel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1154, 28);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "منظومة مختبرات طبية  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 56);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(939, 678);
            this.pnlMain.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(128, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(692, 489);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 760);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslDateTime;
        internal System.Windows.Forms.ToolStripStatusLabel tslMessage;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.ToolStripMenuItem tslSettings;
        internal System.Windows.Forms.ToolStripMenuItem tslUsers;
        internal System.Windows.Forms.ToolStripMenuItem tslMonitor;
        internal System.Windows.Forms.ToolStripMenuItem tslTreasury;
        internal System.Windows.Forms.ToolStripMenuItem tslEmployee;
        internal System.Windows.Forms.ToolStripMenuItem tslInventory;
        internal System.Windows.Forms.Button btnBuyInvoice;
        internal System.Windows.Forms.Button btnStore;
        internal System.Windows.Forms.Button btnItem;
        internal System.Windows.Forms.Button btnTechnical;
        internal System.Windows.Forms.Button btnPaient;
        internal System.Windows.Forms.Button btnResult;
        internal System.Windows.Forms.Button btnInvoice;
        internal System.Windows.Forms.Button btnAnalysis;
        internal System.Windows.Forms.Button btnReports;
        internal System.Windows.Forms.Button btnChart;
        internal System.Windows.Forms.Button btnResource;
        internal System.Windows.Forms.ToolStripStatusLabel tslUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlMain;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.ToolStripMenuItem tslDel;
    }
}

