namespace MedicalLabs.Forms
{
    partial class FrmResult
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvInvoices = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbPatient = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.grbDate = new System.Windows.Forms.GroupBox();
            this.dtTimeTo = new System.Windows.Forms.DateTimePicker();
            this.dtTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chkPatient = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSubAnalysis = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAnalysisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rdChoseResult = new System.Windows.Forms.RadioButton();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.rdResult = new System.Windows.Forms.RadioButton();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnResult = new MedicalLabs.Class.MyButton();
            this.btnClear = new MedicalLabs.Class.MyButton();
            this.btnSave = new MedicalLabs.Class.MyButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).BeginInit();
            this.grbPatient.SuspendLayout();
            this.grbDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoices
            // 
            this.dgvInvoices.AllowUserToAddRows = false;
            this.dgvInvoices.AllowUserToDeleteRows = false;
            this.dgvInvoices.AllowUserToResizeColumns = false;
            this.dgvInvoices.AllowUserToResizeRows = false;
            this.dgvInvoices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.InvoNum,
            this.Date,
            this.PatientName,
            this.TechnicalName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInvoices.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInvoices.Location = new System.Drawing.Point(3, 3);
            this.dgvInvoices.Name = "dgvInvoices";
            this.dgvInvoices.ReadOnly = true;
            this.dgvInvoices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvInvoices.RowHeadersVisible = false;
            this.dgvInvoices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvoices.Size = new System.Drawing.Size(612, 254);
            this.dgvInvoices.TabIndex = 0;
            this.dgvInvoices.Click += new System.EventHandler(this.dgvInvoices_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // InvoNum
            // 
            this.InvoNum.DataPropertyName = "InvoNum";
            this.InvoNum.HeaderText = "رقم الفاتورة";
            this.InvoNum.Name = "InvoNum";
            this.InvoNum.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاريخ الفاتورة";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "المريض";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            // 
            // TechnicalName
            // 
            this.TechnicalName.DataPropertyName = "TechnicalName";
            this.TechnicalName.HeaderText = "فني التحاليل";
            this.TechnicalName.Name = "TechnicalName";
            this.TechnicalName.ReadOnly = true;
            this.TechnicalName.Visible = false;
            // 
            // grbPatient
            // 
            this.grbPatient.Controls.Add(this.label3);
            this.grbPatient.Controls.Add(this.label2);
            this.grbPatient.Controls.Add(this.label1);
            this.grbPatient.Controls.Add(this.txtGender);
            this.grbPatient.Controls.Add(this.txtAge);
            this.grbPatient.Controls.Add(this.cmbPatient);
            this.grbPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbPatient.Location = new System.Drawing.Point(646, 168);
            this.grbPatient.Name = "grbPatient";
            this.grbPatient.Size = new System.Drawing.Size(280, 93);
            this.grbPatient.TabIndex = 158;
            this.grbPatient.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(219, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "الجنس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "العمر";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "المريض";
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(22, 68);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(153, 20);
            this.txtGender.TabIndex = 2;
            this.txtGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(22, 41);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(154, 20);
            this.txtAge.TabIndex = 1;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbPatient
            // 
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(22, 14);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(154, 21);
            this.cmbPatient.TabIndex = 0;
            this.cmbPatient.SelectionChangeCommitted += new System.EventHandler(this.cmbPatient_SelectionChangeCommitted);
            // 
            // grbDate
            // 
            this.grbDate.Controls.Add(this.dtTimeTo);
            this.grbDate.Controls.Add(this.dtTimeFrom);
            this.grbDate.Controls.Add(this.label5);
            this.grbDate.Controls.Add(this.label4);
            this.grbDate.Controls.Add(this.dtpTo);
            this.grbDate.Controls.Add(this.dtpFrom);
            this.grbDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbDate.Location = new System.Drawing.Point(645, 46);
            this.grbDate.Name = "grbDate";
            this.grbDate.Size = new System.Drawing.Size(286, 75);
            this.grbDate.TabIndex = 159;
            this.grbDate.TabStop = false;
            // 
            // dtTimeTo
            // 
            this.dtTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeTo.Location = new System.Drawing.Point(9, 44);
            this.dtTimeTo.Name = "dtTimeTo";
            this.dtTimeTo.Size = new System.Drawing.Size(103, 20);
            this.dtTimeTo.TabIndex = 9;
            // 
            // dtTimeFrom
            // 
            this.dtTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtTimeFrom.Location = new System.Drawing.Point(152, 41);
            this.dtTimeFrom.Name = "dtTimeFrom";
            this.dtTimeFrom.Size = new System.Drawing.Size(103, 20);
            this.dtTimeFrom.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(118, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "إلي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(258, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "من";
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(9, 12);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(103, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(152, 15);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(103, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(926, 182);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 58);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDate.Location = new System.Drawing.Point(939, 12);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(60, 23);
            this.chkDate.TabIndex = 162;
            this.chkDate.Text = "التاريخ";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chkPatient
            // 
            this.chkPatient.AutoSize = true;
            this.chkPatient.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPatient.Location = new System.Drawing.Point(940, 135);
            this.chkPatient.Name = "chkPatient";
            this.chkPatient.Size = new System.Drawing.Size(68, 23);
            this.chkPatient.TabIndex = 163;
            this.chkPatient.Text = "المريض";
            this.chkPatient.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Image = global::MedicalLabs.Properties.Resources.patient__1_;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(647, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 41);
            this.label8.TabIndex = 165;
            this.label8.Text = "بيانات المريض";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = global::MedicalLabs.Properties.Resources.schedule;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(640, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 41);
            this.label6.TabIndex = 166;
            this.label6.Text = "التاريخ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvSubAnalysis
            // 
            this.dgvSubAnalysis.AllowUserToAddRows = false;
            this.dgvSubAnalysis.AllowUserToDeleteRows = false;
            this.dgvSubAnalysis.AllowUserToOrderColumns = true;
            this.dgvSubAnalysis.AllowUserToResizeColumns = false;
            this.dgvSubAnalysis.AllowUserToResizeRows = false;
            this.dgvSubAnalysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubAnalysis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSubAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ت,
            this.SubAnalysisName,
            this.Result,
            this.Unit,
            this.Range});
            this.dgvSubAnalysis.Location = new System.Drawing.Point(3, 316);
            this.dgvSubAnalysis.Name = "dgvSubAnalysis";
            this.dgvSubAnalysis.RowHeadersVisible = false;
            this.dgvSubAnalysis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubAnalysis.Size = new System.Drawing.Size(1005, 238);
            this.dgvSubAnalysis.TabIndex = 171;
            this.dgvSubAnalysis.Click += new System.EventHandler(this.dgvSubAnalysis_Click);
            this.dgvSubAnalysis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSubAnalysis_KeyDown);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // ت
            // 
            this.ت.DataPropertyName = "ت";
            this.ت.HeaderText = "ت";
            this.ت.Name = "ت";
            // 
            // SubAnalysisName
            // 
            this.SubAnalysisName.DataPropertyName = "SubAnalysisName";
            this.SubAnalysisName.HeaderText = "اسم تحليل";
            this.SubAnalysisName.Name = "SubAnalysisName";
            // 
            // Result
            // 
            this.Result.DataPropertyName = "Result";
            this.Result.HeaderText = "نتيجة";
            this.Result.Name = "Result";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "وحدة";
            this.Unit.Name = "Unit";
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            this.Range.HeaderText = "قيمة الطبيعية";
            this.Range.Name = "Range";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(288, 281);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(172, 20);
            this.txtResult.TabIndex = 172;
            this.txtResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResult_KeyDown);
            // 
            // rdChoseResult
            // 
            this.rdChoseResult.AutoSize = true;
            this.rdChoseResult.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdChoseResult.Location = new System.Drawing.Point(704, 281);
            this.rdChoseResult.Name = "rdChoseResult";
            this.rdChoseResult.Size = new System.Drawing.Size(85, 23);
            this.rdChoseResult.TabIndex = 175;
            this.rdChoseResult.Text = "إختيار نتيجة";
            this.rdChoseResult.UseVisualStyleBackColor = true;
            // 
            // cmbResult
            // 
            this.cmbResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbResult.FormattingEnabled = true;
            this.cmbResult.Items.AddRange(new object[] {
            "Positive",
            "Negative",
            "AB+",
            "AB-",
            "A+",
            "A-",
            "B+",
            "B-",
            "O-"});
            this.cmbResult.Location = new System.Drawing.Point(526, 281);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.Size = new System.Drawing.Size(172, 21);
            this.cmbResult.TabIndex = 173;
            this.cmbResult.SelectedIndexChanged += new System.EventHandler(this.cmbResult_SelectedIndexChanged);
            this.cmbResult.SelectionChangeCommitted += new System.EventHandler(this.cmbResult_SelectionChangeCommitted);
            this.cmbResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbResult_KeyDown);
            // 
            // rdResult
            // 
            this.rdResult.AutoSize = true;
            this.rdResult.Checked = true;
            this.rdResult.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdResult.Location = new System.Drawing.Point(462, 279);
            this.rdResult.Name = "rdResult";
            this.rdResult.Size = new System.Drawing.Size(54, 23);
            this.rdResult.TabIndex = 174;
            this.rdResult.TabStop = true;
            this.rdResult.Text = "نتيجة";
            this.rdResult.UseVisualStyleBackColor = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(186, 274);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(95, 36);
            this.btnEnter.TabIndex = 176;
            this.btnEnter.Text = "إدخال النتيجة";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnResult.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnResult.BorderRadius = 0;
            this.btnResult.BorderSize = 0;
            this.btnResult.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnResult.FlatAppearance.BorderSize = 3;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnResult.Image = global::MedicalLabs.Properties.Resources.printer;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(438, 560);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(195, 50);
            this.btnResult.TabIndex = 170;
            this.btnResult.Text = "طباعة الفاتورة";
            this.btnResult.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 0;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.Image = global::MedicalLabs.Properties.Resources.refresh;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(59, 560);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(195, 50);
            this.btnClear.TabIndex = 169;
            this.btnClear.Text = "فاتورة جديدة";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnNew_Click);
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
            this.btnSave.Image = global::MedicalLabs.Properties.Resources.file;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(784, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 50);
            this.btnSave.TabIndex = 168;
            this.btnSave.Text = "حفظ الفاتورة";
            this.btnSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 612);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.rdChoseResult);
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.rdResult);
            this.Controls.Add(this.dgvSubAnalysis);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chkPatient);
            this.Controls.Add(this.chkDate);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grbDate);
            this.Controls.Add(this.grbPatient);
            this.Controls.Add(this.dgvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmResult";
            this.Text = "FrmResult";
            this.Load += new System.EventHandler(this.FrmResult_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmResult_VisibleChanged);
            this.HandleCreated += new System.EventHandler(this.FrmResult_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmResult_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoices)).EndInit();
            this.grbPatient.ResumeLayout(false);
            this.grbPatient.PerformLayout();
            this.grbDate.ResumeLayout(false);
            this.grbDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoices;
        private System.Windows.Forms.GroupBox grbPatient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.GroupBox grbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtTimeTo;
        private System.Windows.Forms.DateTimePicker dtTimeFrom;
        private System.Windows.Forms.CheckBox chkDate;
        private System.Windows.Forms.CheckBox chkPatient;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private Class.MyButton btnResult;
        private Class.MyButton btnClear;
        private Class.MyButton btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnicalName;
        private System.Windows.Forms.DataGridView dgvSubAnalysis;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rdChoseResult;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.RadioButton rdResult;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ت;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAnalysisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
    }
}