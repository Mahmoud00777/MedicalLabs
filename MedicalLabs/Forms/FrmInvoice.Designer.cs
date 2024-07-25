namespace MedicalLabs.Forms
{
    partial class FrmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbAnalysis = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbTechnical = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSubtractAnalysis = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.chkBuy = new System.Windows.Forms.CheckBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.chkDiscount = new System.Windows.Forms.CheckBox();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtNet = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.txtInvoNum = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblNet = new System.Windows.Forms.Label();
            this.dgvInvo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbPatient = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnReceipt = new MedicalLabs.Class.MyButton();
            this.btnPrint = new MedicalLabs.Class.MyButton();
            this.btnNew = new MedicalLabs.Class.MyButton();
            this.btnSave = new MedicalLabs.Class.MyButton();
            this.grbInfo.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvo)).BeginInit();
            this.grbPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbAnalysis
            // 
            this.cmbAnalysis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbAnalysis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnalysis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnalysis.FormattingEnabled = true;
            this.cmbAnalysis.Location = new System.Drawing.Point(25, 46);
            this.cmbAnalysis.Name = "cmbAnalysis";
            this.cmbAnalysis.Size = new System.Drawing.Size(210, 24);
            this.cmbAnalysis.TabIndex = 2;
            this.cmbAnalysis.SelectionChangeCommitted += new System.EventHandler(this.cmbAnalysis_SelectionChangeCommitted);
            this.cmbAnalysis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAnalysis_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "أٍسم تحليل";
            // 
            // cmbPatient
            // 
            this.cmbPatient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPatient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPatient.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(45, 13);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(210, 24);
            this.cmbPatient.TabIndex = 10;
            this.cmbPatient.SelectionChangeCommitted += new System.EventHandler(this.cmbPatient_SelectionChangeCommitted);
            this.cmbPatient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPatient_KeyDown);
            // 
            // cmbTechnical
            // 
            this.cmbTechnical.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTechnical.FormattingEnabled = true;
            this.cmbTechnical.Location = new System.Drawing.Point(244, 122);
            this.cmbTechnical.Name = "cmbTechnical";
            this.cmbTechnical.Size = new System.Drawing.Size(210, 24);
            this.cmbTechnical.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "اسم المريض";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(460, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "اسم تقني تحليل";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.cmbGroup);
            this.grbInfo.Controls.Add(this.label7);
            this.grbInfo.Controls.Add(this.btnSubtractAnalysis);
            this.grbInfo.Controls.Add(this.label6);
            this.grbInfo.Controls.Add(this.cmbSource);
            this.grbInfo.Controls.Add(this.label2);
            this.grbInfo.Controls.Add(this.cmbAnalysis);
            this.grbInfo.Location = new System.Drawing.Point(602, 214);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbInfo.Size = new System.Drawing.Size(351, 235);
            this.grbInfo.TabIndex = 14;
            this.grbInfo.TabStop = false;
            // 
            // cmbGroup
            // 
            this.cmbGroup.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(25, 82);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(210, 24);
            this.cmbGroup.TabIndex = 222;
            this.cmbGroup.SelectionChangeCommitted += new System.EventHandler(this.cmbGroup_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 221;
            this.label7.Text = "المجموعة";
            // 
            // btnSubtractAnalysis
            // 
            this.btnSubtractAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.btnSubtractAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubtractAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSubtractAnalysis.FlatAppearance.BorderSize = 2;
            this.btnSubtractAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubtractAnalysis.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtractAnalysis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSubtractAnalysis.ImageKey = "3.png";
            this.btnSubtractAnalysis.Location = new System.Drawing.Point(84, 184);
            this.btnSubtractAnalysis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSubtractAnalysis.Name = "btnSubtractAnalysis";
            this.btnSubtractAnalysis.Size = new System.Drawing.Size(151, 33);
            this.btnSubtractAnalysis.TabIndex = 220;
            this.btnSubtractAnalysis.Text = "حذف تحليل";
            this.btnSubtractAnalysis.UseVisualStyleBackColor = false;
            this.btnSubtractAnalysis.Click += new System.EventHandler(this.btnSubtractAnalysis_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 19);
            this.label6.TabIndex = 219;
            this.label6.Text = "مصدر العينة";
            // 
            // cmbSource
            // 
            this.cmbSource.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(25, 117);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(210, 24);
            this.cmbSource.TabIndex = 218;
            // 
            // grpInvoice
            // 
            this.grpInvoice.BackColor = System.Drawing.Color.Transparent;
            this.grpInvoice.Controls.Add(this.chkBuy);
            this.grpInvoice.Controls.Add(this.dtpTime);
            this.grpInvoice.Controls.Add(this.chkDiscount);
            this.grpInvoice.Controls.Add(this.lblBarcode);
            this.grpInvoice.Controls.Add(this.label30);
            this.grpInvoice.Controls.Add(this.label4);
            this.grpInvoice.Controls.Add(this.txtNet);
            this.grpInvoice.Controls.Add(this.cmbTechnical);
            this.grpInvoice.Controls.Add(this.dtpDate);
            this.grpInvoice.Controls.Add(this.label29);
            this.grpInvoice.Controls.Add(this.label26);
            this.grpInvoice.Controls.Add(this.txtInvoNum);
            this.grpInvoice.Controls.Add(this.txtdiscount);
            this.grpInvoice.Controls.Add(this.label5);
            this.grpInvoice.Controls.Add(this.txtTotal);
            this.grpInvoice.Controls.Add(this.lblNet);
            this.grpInvoice.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInvoice.Location = new System.Drawing.Point(1, 280);
            this.grpInvoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpInvoice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grpInvoice.Size = new System.Drawing.Size(578, 189);
            this.grpInvoice.TabIndex = 149;
            this.grpInvoice.TabStop = false;
            // 
            // chkBuy
            // 
            this.chkBuy.AutoSize = true;
            this.chkBuy.Checked = true;
            this.chkBuy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBuy.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBuy.ForeColor = System.Drawing.Color.Red;
            this.chkBuy.Location = new System.Drawing.Point(413, 94);
            this.chkBuy.Name = "chkBuy";
            this.chkBuy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkBuy.Size = new System.Drawing.Size(157, 28);
            this.chkBuy.TabIndex = 219;
            this.chkBuy.Text = " الـــدفــــع مــبـــاشـــر";
            this.chkBuy.UseVisualStyleBackColor = true;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(315, 65);
            this.dtpTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.RightToLeftLayout = true;
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(116, 23);
            this.dtpTime.TabIndex = 218;
            // 
            // chkDiscount
            // 
            this.chkDiscount.AutoSize = true;
            this.chkDiscount.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDiscount.Location = new System.Drawing.Point(3, 64);
            this.chkDiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDiscount.Name = "chkDiscount";
            this.chkDiscount.Size = new System.Drawing.Size(47, 26);
            this.chkDiscount.TabIndex = 9;
            this.chkDiscount.Text = "%";
            this.chkDiscount.UseVisualStyleBackColor = true;
            this.chkDiscount.CheckedChanged += new System.EventHandler(this.chkDiscount_CheckedChanged);
            // 
            // lblBarcode
            // 
            this.lblBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblBarcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarcode.Location = new System.Drawing.Point(178, 29);
            this.lblBarcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(127, 60);
            this.lblBarcode.TabIndex = 10;
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(125, 105);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 19);
            this.label30.TabIndex = 8;
            this.label30.Text = "الصافي";
            // 
            // txtNet
            // 
            this.txtNet.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtNet.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNet.ForeColor = System.Drawing.Color.Navy;
            this.txtNet.Location = new System.Drawing.Point(16, 99);
            this.txtNet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(100, 32);
            this.txtNet.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(443, 66);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.RightToLeftLayout = true;
            this.dtpDate.Size = new System.Drawing.Size(117, 23);
            this.dtpDate.TabIndex = 7;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(127, 69);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 19);
            this.label29.TabIndex = 6;
            this.label29.Text = "الخصم";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(122, 34);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 19);
            this.label26.TabIndex = 5;
            this.label26.Text = "الإجمالي";
            // 
            // txtInvoNum
            // 
            this.txtInvoNum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtInvoNum.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtInvoNum.Location = new System.Drawing.Point(313, 29);
            this.txtInvoNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInvoNum.Name = "txtInvoNum";
            this.txtInvoNum.ReadOnly = true;
            this.txtInvoNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInvoNum.Size = new System.Drawing.Size(176, 26);
            this.txtInvoNum.TabIndex = 1;
            this.txtInvoNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtdiscount
            // 
            this.txtdiscount.BackColor = System.Drawing.Color.White;
            this.txtdiscount.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtdiscount.Location = new System.Drawing.Point(52, 64);
            this.txtdiscount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.Size = new System.Drawing.Size(68, 26);
            this.txtdiscount.TabIndex = 3;
            this.txtdiscount.TextChanged += new System.EventHandler(this.txtdiscount_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(498, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "رقم الفاتورة";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTotal.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtTotal.Location = new System.Drawing.Point(16, 28);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 26);
            this.txtTotal.TabIndex = 1;
            // 
            // lblNet
            // 
            this.lblNet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblNet.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.ForeColor = System.Drawing.Color.Black;
            this.lblNet.Location = new System.Drawing.Point(12, 156);
            this.lblNet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(556, 21);
            this.lblNet.TabIndex = 2;
            // 
            // dgvInvo
            // 
            this.dgvInvo.AllowUserToAddRows = false;
            this.dgvInvo.AllowUserToDeleteRows = false;
            this.dgvInvo.AllowUserToResizeColumns = false;
            this.dgvInvo.AllowUserToResizeRows = false;
            this.dgvInvo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInvo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvInvo.EnableHeadersVisualStyles = false;
            this.dgvInvo.Location = new System.Drawing.Point(1, 3);
            this.dgvInvo.Name = "dgvInvo";
            this.dgvInvo.RowHeadersVisible = false;
            this.dgvInvo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvo.Size = new System.Drawing.Size(578, 281);
            this.dgvInvo.TabIndex = 154;
            this.dgvInvo.Click += new System.EventHandler(this.dgvInvo_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ت";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "أسم تحليل";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سعر";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Num";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            // 
            // grbPatient
            // 
            this.grbPatient.Controls.Add(this.label11);
            this.grbPatient.Controls.Add(this.label10);
            this.grbPatient.Controls.Add(this.txtAge);
            this.grbPatient.Controls.Add(this.txtGender);
            this.grbPatient.Controls.Add(this.label3);
            this.grbPatient.Controls.Add(this.cmbPatient);
            this.grbPatient.Location = new System.Drawing.Point(602, 46);
            this.grbPatient.Name = "grbPatient";
            this.grbPatient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbPatient.Size = new System.Drawing.Size(351, 124);
            this.grbPatient.TabIndex = 155;
            this.grbPatient.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(284, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 19);
            this.label11.TabIndex = 221;
            this.label11.Text = "عمر";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(284, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 19);
            this.label10.TabIndex = 220;
            this.label10.Text = "الجنس";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(45, 89);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(210, 20);
            this.txtAge.TabIndex = 219;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(45, 54);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(210, 20);
            this.txtGender.TabIndex = 218;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label9.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(602, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(351, 39);
            this.label9.TabIndex = 156;
            this.label9.Text = "بيانات تحليل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(602, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(351, 43);
            this.label8.TabIndex = 157;
            this.label8.Text = "بيانات المريض";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.Transparent;
            this.btnReceipt.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnReceipt.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnReceipt.BorderRadius = 0;
            this.btnReceipt.BorderSize = 0;
            this.btnReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnReceipt.FlatAppearance.BorderSize = 3;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceipt.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceipt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnReceipt.Location = new System.Drawing.Point(30, 489);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(195, 50);
            this.btnReceipt.TabIndex = 158;
            this.btnReceipt.Text = "F6 إدخال واصل";
            this.btnReceipt.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPrint.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnPrint.BorderRadius = 0;
            this.btnPrint.BorderSize = 0;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnPrint.FlatAppearance.BorderSize = 3;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnPrint.Location = new System.Drawing.Point(245, 489);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(195, 50);
            this.btnPrint.TabIndex = 153;
            this.btnPrint.Text = " F5  طباعة الفاتورة";
            this.btnPrint.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNew.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnNew.BorderRadius = 0;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNew.Location = new System.Drawing.Point(702, 489);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(195, 50);
            this.btnNew.TabIndex = 152;
            this.btnNew.Text = "F3  فاتورة جديدة";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 0;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSave.FlatAppearance.BorderSize = 3;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSave.Location = new System.Drawing.Point(472, 489);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 50);
            this.btnSave.TabIndex = 150;
            this.btnSave.Text = "F4  حفظ الفاتورة";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(965, 550);
            this.Controls.Add(this.btnReceipt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.grbPatient);
            this.Controls.Add(this.dgvInvo);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpInvoice);
            this.Controls.Add(this.grbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoice";
            this.Text = "FrmOrder";
            this.Load += new System.EventHandler(this.FrmInvoice_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmInvoice_VisibleChanged);
            this.HandleCreated += new System.EventHandler(this.FrmInvoice_HandleCreated);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInvoice_KeyDown);
            this.Resize += new System.EventHandler(this.FrmInvoice_Resize);
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvo)).EndInit();
            this.grbPatient.ResumeLayout(false);
            this.grbPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbAnalysis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbTechnical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grbInfo;
        internal System.Windows.Forms.GroupBox grpInvoice;
        internal System.Windows.Forms.DateTimePicker dtpTime;
        internal System.Windows.Forms.CheckBox chkDiscount;
        internal System.Windows.Forms.Label lblBarcode;
        internal System.Windows.Forms.Label label30;
        internal System.Windows.Forms.TextBox txtNet;
        internal System.Windows.Forms.DateTimePicker dtpDate;
        internal System.Windows.Forms.Label label29;
        internal System.Windows.Forms.Label label26;
        internal System.Windows.Forms.TextBox txtInvoNum;
        internal System.Windows.Forms.TextBox txtdiscount;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.Label lblNet;
        private Class.MyButton btnNew;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSource;
        internal System.Windows.Forms.Button btnSubtractAnalysis;
        private System.Windows.Forms.DataGridView dgvInvo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.GroupBox grbPatient;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        internal Class.MyButton btnSave;
        internal Class.MyButton btnPrint;
        private System.Windows.Forms.CheckBox chkBuy;
        internal Class.MyButton btnReceipt;
    }
}