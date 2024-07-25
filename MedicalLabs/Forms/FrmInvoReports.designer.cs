﻿
namespace MedicalLabs.Forms
{
    partial class FrmInvoReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoReports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotInvoReport = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtInvoNum = new System.Windows.Forms.TextBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.chkInvoNum = new System.Windows.Forms.CheckBox();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.grpDate = new System.Windows.Forms.GroupBox();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groubBox111 = new System.Windows.Forms.GroupBox();
            this.dgvInvoReports = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NET = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnPrintSearch = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDelInvo = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnOpenInvoice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpSearch.SuspendLayout();
            this.grpDate.SuspendLayout();
            this.groubBox111.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Printer.png");
            this.imageList2.Images.SetKeyName(1, "Refresh.ico");
            this.imageList2.Images.SetKeyName(2, "Print.ico");
            this.imageList2.Images.SetKeyName(3, "Search.ico");
            this.imageList2.Images.SetKeyName(4, "Del.ico");
            this.imageList2.Images.SetKeyName(5, "View Doc.ico");
            this.imageList2.Images.SetKeyName(6, "Add Card.ico");
            this.imageList2.Images.SetKeyName(7, "Add Folder.ico");
            this.imageList2.Images.SetKeyName(8, "Back 2.ico");
            this.imageList2.Images.SetKeyName(9, "Download.ico");
            this.imageList2.Images.SetKeyName(10, "Forward 2.ico");
            this.imageList2.Images.SetKeyName(11, "Properties.ico");
            this.imageList2.Images.SetKeyName(12, "Rename - Edit.ico");
            this.imageList2.Images.SetKeyName(13, "Spell.ico");
            this.imageList2.Images.SetKeyName(14, "6.jpg");
            this.imageList2.Images.SetKeyName(15, "7.jpg");
            this.imageList2.Images.SetKeyName(16, "12.jpg");
            this.imageList2.Images.SetKeyName(17, "13.jpg");
            this.imageList2.Images.SetKeyName(18, "14.jpg");
            this.imageList2.Images.SetKeyName(19, "19.jpg");
            this.imageList2.Images.SetKeyName(20, "1.jpg");
            this.imageList2.Images.SetKeyName(21, "9.jpg");
            this.imageList2.Images.SetKeyName(22, "Edit.ico");
            this.imageList2.Images.SetKeyName(23, "Delete.ico");
            this.imageList2.Images.SetKeyName(24, "Actions-trash-empty-icon.png");
            this.imageList2.Images.SetKeyName(25, "Actions-view-refresh-icon.png");
            this.imageList2.Images.SetKeyName(26, "recycle_bin_full3.png");
            this.imageList2.Images.SetKeyName(27, "trashcan_full.png");
            this.imageList2.Images.SetKeyName(28, "p4.png");
            this.imageList2.Images.SetKeyName(29, "Browse 1.ico");
            this.imageList2.Images.SetKeyName(30, "refresh-icon.png");
            this.imageList2.Images.SetKeyName(31, "p4.png");
            this.imageList2.Images.SetKeyName(32, "p1.jpg");
            this.imageList2.Images.SetKeyName(33, "p2.png");
            this.imageList2.Images.SetKeyName(34, "p4.png");
            this.imageList2.Images.SetKeyName(35, "p7.png");
            this.imageList2.Images.SetKeyName(36, "p9.jpg");
            this.imageList2.Images.SetKeyName(37, "8.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1479606346_config-users.png");
            this.imageList1.Images.SetKeyName(1, "3d bar chart.bmp");
            this.imageList1.Images.SetKeyName(2, "13.png");
            this.imageList1.Images.SetKeyName(3, "198-512.png");
            this.imageList1.Images.SetKeyName(4, "checklist-icon-277x300.png");
            this.imageList1.Images.SetKeyName(5, "solution.png");
            this.imageList1.Images.SetKeyName(6, "6.jpg");
            this.imageList1.Images.SetKeyName(7, "9.jpg");
            this.imageList1.Images.SetKeyName(8, "27.jpg");
            this.imageList1.Images.SetKeyName(9, "32.jpg");
            this.imageList1.Images.SetKeyName(10, "33.jpg");
            this.imageList1.Images.SetKeyName(11, "35.jpg");
            this.imageList1.Images.SetKeyName(12, "images.jpg");
            this.imageList1.Images.SetKeyName(13, "images.png");
            this.imageList1.Images.SetKeyName(14, "5.jpg");
            this.imageList1.Images.SetKeyName(15, "5.png");
            this.imageList1.Images.SetKeyName(16, "8.jpg");
            this.imageList1.Images.SetKeyName(17, "18.jpg");
            this.imageList1.Images.SetKeyName(18, "19.jpg");
            this.imageList1.Images.SetKeyName(19, "22.png");
            this.imageList1.Images.SetKeyName(20, "3.png");
            this.imageList1.Images.SetKeyName(21, "6.png");
            this.imageList1.Images.SetKeyName(22, "7.jpg");
            this.imageList1.Images.SetKeyName(23, "2.png");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.White;
            this.imageList3.Images.SetKeyName(0, "1472054491_button_30.png");
            this.imageList3.Images.SetKeyName(1, "7.jpg");
            this.imageList3.Images.SetKeyName(2, "Paste.ico");
            this.imageList3.Images.SetKeyName(3, "Contacts.ico");
            this.imageList3.Images.SetKeyName(4, "user (1).png");
            this.imageList3.Images.SetKeyName(5, "participants.png");
            this.imageList3.Images.SetKeyName(6, "111.png");
            this.imageList3.Images.SetKeyName(7, "3.png");
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Navy;
            this.txtTotal.Location = new System.Drawing.Point(6, 19);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 35);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // lblTotInvoReport
            // 
            this.lblTotInvoReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblTotInvoReport.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.lblTotInvoReport.Location = new System.Drawing.Point(0, 59);
            this.lblTotInvoReport.Name = "lblTotInvoReport";
            this.lblTotInvoReport.Size = new System.Drawing.Size(581, 19);
            this.lblTotInvoReport.TabIndex = 2;
            this.lblTotInvoReport.Text = "الإجمالي بالحروف";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtInvoNum);
            this.grpSearch.Controls.Add(this.pictureBox3);
            this.grpSearch.Controls.Add(this.pictureBox1);
            this.grpSearch.Controls.Add(this.cmbName);
            this.grpSearch.Controls.Add(this.chkInvoNum);
            this.grpSearch.Controls.Add(this.chkName);
            this.grpSearch.Controls.Add(this.chkDate);
            this.grpSearch.Controls.Add(this.grpDate);
            this.grpSearch.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSearch.Location = new System.Drawing.Point(621, 36);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpSearch.Size = new System.Drawing.Size(347, 287);
            this.grpSearch.TabIndex = 222;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "خيارات البحث";
            // 
            // txtInvoNum
            // 
            this.txtInvoNum.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoNum.Location = new System.Drawing.Point(8, 40);
            this.txtInvoNum.Name = "txtInvoNum";
            this.txtInvoNum.Size = new System.Drawing.Size(194, 28);
            this.txtInvoNum.TabIndex = 231;
            this.txtInvoNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInvoNum_KeyDown);
            // 
            // cmbName
            // 
            this.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.cmbName.Enabled = false;
            this.cmbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(8, 89);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(217, 27);
            this.cmbName.TabIndex = 228;
            // 
            // chkInvoNum
            // 
            this.chkInvoNum.AutoSize = true;
            this.chkInvoNum.Checked = true;
            this.chkInvoNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInvoNum.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkInvoNum.Location = new System.Drawing.Point(243, 43);
            this.chkInvoNum.Name = "chkInvoNum";
            this.chkInvoNum.Size = new System.Drawing.Size(95, 23);
            this.chkInvoNum.TabIndex = 13;
            this.chkInvoNum.Text = "رقم الفاتورة";
            this.chkInvoNum.UseVisualStyleBackColor = true;
            this.chkInvoNum.CheckedChanged += new System.EventHandler(this.chkInvoNum_CheckedChanged);
            // 
            // chkName
            // 
            this.chkName.AutoSize = true;
            this.chkName.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkName.Location = new System.Drawing.Point(228, 93);
            this.chkName.Name = "chkName";
            this.chkName.Size = new System.Drawing.Size(110, 23);
            this.chkName.TabIndex = 12;
            this.chkName.Text = "اسم المستخدم";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkName_CheckedChanged);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDate.Location = new System.Drawing.Point(278, 144);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(60, 23);
            this.chkDate.TabIndex = 11;
            this.chkDate.Text = "التاريخ";
            this.chkDate.UseVisualStyleBackColor = false;
            this.chkDate.CheckedChanged += new System.EventHandler(this.chkDate_CheckedChanged);
            // 
            // grpDate
            // 
            this.grpDate.Controls.Add(this.dtpTimeTo);
            this.grpDate.Controls.Add(this.dtpTimeFrom);
            this.grpDate.Controls.Add(this.label10);
            this.grpDate.Controls.Add(this.dtpDateTo);
            this.grpDate.Controls.Add(this.dtpDateFrom);
            this.grpDate.Controls.Add(this.label9);
            this.grpDate.Enabled = false;
            this.grpDate.Location = new System.Drawing.Point(8, 172);
            this.grpDate.Name = "grpDate";
            this.grpDate.Size = new System.Drawing.Size(330, 99);
            this.grpDate.TabIndex = 9;
            this.grpDate.TabStop = false;
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(17, 61);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTimeTo.RightToLeftLayout = true;
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(125, 26);
            this.dtpTimeTo.TabIndex = 13;
            this.dtpTimeTo.Value = new System.DateTime(2017, 6, 18, 23, 59, 59, 0);
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(17, 21);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpTimeFrom.RightToLeftLayout = true;
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(125, 26);
            this.dtpTimeFrom.TabIndex = 12;
            this.dtpTimeFrom.Value = new System.DateTime(2017, 6, 18, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(296, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 19);
            this.label10.TabIndex = 11;
            this.label10.Text = "الى";
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(175, 61);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDateTo.RightToLeftLayout = true;
            this.dtpDateTo.Size = new System.Drawing.Size(115, 26);
            this.dtpDateTo.TabIndex = 1;
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(175, 21);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpDateFrom.RightToLeftLayout = true;
            this.dtpDateFrom.Size = new System.Drawing.Size(115, 26);
            this.dtpDateFrom.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(296, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "من";
            // 
            // groubBox111
            // 
            this.groubBox111.Controls.Add(this.PictureBox2);
            this.groubBox111.Controls.Add(this.txtTotal);
            this.groubBox111.Controls.Add(this.lblTotInvoReport);
            this.groubBox111.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groubBox111.Location = new System.Drawing.Point(21, 407);
            this.groubBox111.Name = "groubBox111";
            this.groubBox111.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groubBox111.Size = new System.Drawing.Size(587, 86);
            this.groubBox111.TabIndex = 225;
            this.groubBox111.TabStop = false;
            this.groubBox111.Text = "الإجمــــــــــــــالي";
            // 
            // dgvInvoReports
            // 
            this.dgvInvoReports.AllowUserToAddRows = false;
            this.dgvInvoReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ت,
            this.InvoNum,
            this.PatientName,
            this.NET,
            this.Date,
            this.UserName});
            this.dgvInvoReports.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoReports.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvoReports.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvoReports.Location = new System.Drawing.Point(26, 38);
            this.dgvInvoReports.MultiSelect = false;
            this.dgvInvoReports.Name = "dgvInvoReports";
            this.dgvInvoReports.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoReports.RowHeadersVisible = false;
            this.dgvInvoReports.RowHeadersWidth = 102;
            this.dgvInvoReports.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvInvoReports.RowTemplate.Height = 28;
            this.dgvInvoReports.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoReports.Size = new System.Drawing.Size(582, 324);
            this.dgvInvoReports.TabIndex = 224;
            this.dgvInvoReports.Click += new System.EventHandler(this.dgvInvoReport_Click);
            this.dgvInvoReports.DoubleClick += new System.EventHandler(this.dgvInvoReport_DoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 12;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // ت
            // 
            this.ت.DataPropertyName = "ت";
            this.ت.FillWeight = 40.22937F;
            this.ت.HeaderText = "ت";
            this.ت.MinimumWidth = 12;
            this.ت.Name = "ت";
            // 
            // InvoNum
            // 
            this.InvoNum.DataPropertyName = "InvoNum";
            this.InvoNum.FillWeight = 102.6759F;
            this.InvoNum.HeaderText = "رقم الفاتورة";
            this.InvoNum.MinimumWidth = 12;
            this.InvoNum.Name = "InvoNum";
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.FillWeight = 88.38953F;
            this.PatientName.HeaderText = "اسم العميل";
            this.PatientName.MinimumWidth = 12;
            this.PatientName.Name = "PatientName";
            // 
            // NET
            // 
            this.NET.DataPropertyName = "NET";
            this.NET.FillWeight = 111.6199F;
            this.NET.HeaderText = "القيمة المالية";
            this.NET.MinimumWidth = 12;
            this.NET.Name = "NET";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            dataGridViewCellStyle2.Format = "dd-MM-yyyy tt hh:mm  ";
            dataGridViewCellStyle2.NullValue = null;
            this.Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Date.FillWeight = 167.5126F;
            this.Date.HeaderText = "التاريخ";
            this.Date.MinimumWidth = 12;
            this.Date.Name = "Date";
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.FillWeight = 89.57249F;
            this.UserName.HeaderText = "المستخدم";
            this.UserName.MinimumWidth = 12;
            this.UserName.Name = "UserName";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 369);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(582, 25);
            this.progressBar1.TabIndex = 227;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnExportExcel.FlatAppearance.BorderSize = 3;
            this.btnExportExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportExcel.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.btnExportExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnExportExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportExcel.ImageIndex = 37;
            this.btnExportExcel.ImageList = this.imageList2;
            this.btnExportExcel.Location = new System.Drawing.Point(630, 447);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnExportExcel.Size = new System.Drawing.Size(164, 46);
            this.btnExportExcel.TabIndex = 231;
            this.btnExportExcel.Text = "تصدير الى أكسل";
            this.btnExportExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnPrintSearch
            // 
            this.btnPrintSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnPrintSearch.FlatAppearance.BorderSize = 3;
            this.btnPrintSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintSearch.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.btnPrintSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnPrintSearch.Image = global::MedicalLabs.Properties.Resources.printer;
            this.btnPrintSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrintSearch.Location = new System.Drawing.Point(805, 447);
            this.btnPrintSearch.Name = "btnPrintSearch";
            this.btnPrintSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrintSearch.Size = new System.Drawing.Size(164, 46);
            this.btnPrintSearch.TabIndex = 230;
            this.btnPrintSearch.Text = "طباعة التقرير";
            this.btnPrintSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintSearch.UseVisualStyleBackColor = true;
            this.btnPrintSearch.Click += new System.EventHandler(this.btnPrintSearch_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(201, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 230;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 229;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(147, 19);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(41, 37);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 231;
            this.PictureBox2.TabStop = false;
            // 
            // btnDelInvo
            // 
            this.btnDelInvo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelInvo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelInvo.FlatAppearance.BorderSize = 3;
            this.btnDelInvo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelInvo.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.btnDelInvo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelInvo.Image = global::MedicalLabs.Properties.Resources.delete_folder__1_;
            this.btnDelInvo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelInvo.ImageKey = "(none)";
            this.btnDelInvo.Location = new System.Drawing.Point(805, 391);
            this.btnDelInvo.Name = "btnDelInvo";
            this.btnDelInvo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelInvo.Size = new System.Drawing.Size(164, 45);
            this.btnDelInvo.TabIndex = 228;
            this.btnDelInvo.Text = "حذف الفاتورة";
            this.btnDelInvo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelInvo.UseVisualStyleBackColor = true;
            this.btnDelInvo.Click += new System.EventHandler(this.btnDelInvo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnRefresh.FlatAppearance.BorderSize = 3;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnRefresh.Image = global::MedicalLabs.Properties.Resources.refresh;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.ImageKey = "(none)";
            this.btnRefresh.Location = new System.Drawing.Point(630, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRefresh.Size = new System.Drawing.Size(164, 46);
            this.btnRefresh.TabIndex = 226;
            this.btnRefresh.Text = "تحديث";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnOpenInvoice
            // 
            this.btnOpenInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnOpenInvoice.FlatAppearance.BorderSize = 3;
            this.btnOpenInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInvoice.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.btnOpenInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnOpenInvoice.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenInvoice.ImageKey = "Edit.ico";
            this.btnOpenInvoice.ImageList = this.imageList2;
            this.btnOpenInvoice.Location = new System.Drawing.Point(630, 391);
            this.btnOpenInvoice.Name = "btnOpenInvoice";
            this.btnOpenInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnOpenInvoice.Size = new System.Drawing.Size(164, 45);
            this.btnOpenInvoice.TabIndex = 229;
            this.btnOpenInvoice.Text = "تعديل الفاتورة";
            this.btnOpenInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenInvoice.UseVisualStyleBackColor = true;
            this.btnOpenInvoice.Click += new System.EventHandler(this.btnOpenInvoice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSearch.FlatAppearance.BorderSize = 3;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSearch.Image = global::MedicalLabs.Properties.Resources.search;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.ImageKey = "(none)";
            this.btnSearch.Location = new System.Drawing.Point(805, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(164, 46);
            this.btnSearch.TabIndex = 223;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmInvoReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(981, 510);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnPrintSearch);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.groubBox111);
            this.Controls.Add(this.btnDelInvo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnOpenInvoice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvInvoReports);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "FrmInvoReports";
            this.Text = "FrmInvoReports";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmInvoReports_FormClosing);
            this.Load += new System.EventHandler(this.FrmInvoReports_Load);
            this.HandleCreated += new System.EventHandler(this.FrmInvoReports_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmInvoReports_Resize);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpDate.ResumeLayout(false);
            this.grpDate.PerformLayout();
            this.groubBox111.ResumeLayout(false);
            this.groubBox111.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnExportExcel;
        internal System.Windows.Forms.ImageList imageList2;
        internal System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.ImageList imageList3;
        internal System.Windows.Forms.Button btnPrintSearch;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label lblTotInvoReport;
        internal System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.GroupBox grpSearch;
        internal System.Windows.Forms.TextBox txtInvoNum;
        internal System.Windows.Forms.PictureBox pictureBox3;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ComboBox cmbName;
        internal System.Windows.Forms.CheckBox chkInvoNum;
        internal System.Windows.Forms.CheckBox chkName;
        internal System.Windows.Forms.CheckBox chkDate;
        internal System.Windows.Forms.GroupBox grpDate;
        internal System.Windows.Forms.DateTimePicker dtpTimeTo;
        internal System.Windows.Forms.DateTimePicker dtpTimeFrom;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.GroupBox groubBox111;
        internal System.Windows.Forms.Button btnDelInvo;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Button btnOpenInvoice;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.DataGridView dgvInvoReports;
        internal System.Windows.Forms.ProgressBar progressBar1;
        internal System.Windows.Forms.PictureBox PictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ت;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NET;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
    }
}