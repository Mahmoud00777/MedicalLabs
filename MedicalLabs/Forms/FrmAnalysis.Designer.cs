namespace MedicalLabs.Forms
{
    partial class FrmAnalysis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnalysis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picNew = new System.Windows.Forms.PictureBox();
            this.picDelete = new System.Windows.Forms.PictureBox();
            this.picSave = new System.Windows.Forms.PictureBox();
            this.picNewSub = new System.Windows.Forms.PictureBox();
            this.picDeleteSub = new System.Windows.Forms.PictureBox();
            this.picSaveSub = new System.Windows.Forms.PictureBox();
            this.dgvSubAnalysis = new System.Windows.Forms.DataGridView();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ت1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubAnalysisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Range = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbSubAnalysis = new System.Windows.Forms.GroupBox();
            this.btnUnit = new System.Windows.Forms.Button();
            this.chkAnalysis = new System.Windows.Forms.CheckBox();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.txtSubAnName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbAnalysis = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbAnalysis = new System.Windows.Forms.GroupBox();
            this.cmbAnalysisA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvAnalysis = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnalysisName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdateGroup = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.lstAnalysis = new System.Windows.Forms.ListBox();
            this.lstGroup = new System.Windows.Forms.ListBox();
            this.grpGroup = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAnalysis2 = new System.Windows.Forms.ComboBox();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.btnDelGroup = new System.Windows.Forms.Button();
            this.btnAddGroup = new System.Windows.Forms.Button();
            this.btnDelConGroup = new MedicalLabs.Class.MyButton();
            this.btnSaveConGroup = new MedicalLabs.Class.MyButton();
            this.btnNew = new MedicalLabs.Class.MyButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubAnalysis)).BeginInit();
            this.grbSubAnalysis.SuspendLayout();
            this.grbAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grpGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 602);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.tabPage1.Controls.Add(this.picNew);
            this.tabPage1.Controls.Add(this.picDelete);
            this.tabPage1.Controls.Add(this.picSave);
            this.tabPage1.Controls.Add(this.picNewSub);
            this.tabPage1.Controls.Add(this.picDeleteSub);
            this.tabPage1.Controls.Add(this.picSaveSub);
            this.tabPage1.Controls.Add(this.dgvSubAnalysis);
            this.tabPage1.Controls.Add(this.grbSubAnalysis);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.grbAnalysis);
            this.tabPage1.Controls.Add(this.dgvAnalysis);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(911, 570);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = " التحاليل";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // picNew
            // 
            this.picNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picNew.Image = global::MedicalLabs.Properties.Resources.rotate_arrow;
            this.picNew.Location = new System.Drawing.Point(658, 190);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(67, 50);
            this.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNew.TabIndex = 71;
            this.picNew.TabStop = false;
            this.toolTip1.SetToolTip(this.picNew, "جــــديـــد");
            this.picNew.Click += new System.EventHandler(this.picNew_Click);
            this.picNew.MouseEnter += new System.EventHandler(this.picNew_MouseEnter);
            this.picNew.MouseLeave += new System.EventHandler(this.picNew_MouseLeave);
            // 
            // picDelete
            // 
            this.picDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDelete.Image = global::MedicalLabs.Properties.Resources.delete_folder;
            this.picDelete.Location = new System.Drawing.Point(737, 190);
            this.picDelete.Name = "picDelete";
            this.picDelete.Size = new System.Drawing.Size(67, 50);
            this.picDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDelete.TabIndex = 70;
            this.picDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.picDelete, "حــــــذف");
            this.picDelete.Click += new System.EventHandler(this.picDelete_Click);
            this.picDelete.MouseEnter += new System.EventHandler(this.picDelete_MouseEnter);
            this.picDelete.MouseLeave += new System.EventHandler(this.picDelete_MouseLeave);
            // 
            // picSave
            // 
            this.picSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSave.Image = global::MedicalLabs.Properties.Resources.diskette__2_;
            this.picSave.Location = new System.Drawing.Point(816, 190);
            this.picSave.Name = "picSave";
            this.picSave.Size = new System.Drawing.Size(67, 50);
            this.picSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSave.TabIndex = 69;
            this.picSave.TabStop = false;
            this.toolTip1.SetToolTip(this.picSave, "حـــــفـــــظ");
            this.picSave.Click += new System.EventHandler(this.picSave_Click);
            this.picSave.MouseEnter += new System.EventHandler(this.picSave_MouseEnter);
            this.picSave.MouseLeave += new System.EventHandler(this.picSave_MouseLeave);
            // 
            // picNewSub
            // 
            this.picNewSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picNewSub.Image = global::MedicalLabs.Properties.Resources.rotate_arrow;
            this.picNewSub.Location = new System.Drawing.Point(637, 510);
            this.picNewSub.Name = "picNewSub";
            this.picNewSub.Size = new System.Drawing.Size(67, 50);
            this.picNewSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picNewSub.TabIndex = 68;
            this.picNewSub.TabStop = false;
            this.toolTip1.SetToolTip(this.picNewSub, "جــــديــــد");
            this.picNewSub.Click += new System.EventHandler(this.picNewSub_Click);
            this.picNewSub.MouseEnter += new System.EventHandler(this.picNewSub_MouseEnter);
            this.picNewSub.MouseLeave += new System.EventHandler(this.picNewSub_MouseLeave);
            // 
            // picDeleteSub
            // 
            this.picDeleteSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDeleteSub.Image = global::MedicalLabs.Properties.Resources.delete_folder;
            this.picDeleteSub.Location = new System.Drawing.Point(724, 510);
            this.picDeleteSub.Name = "picDeleteSub";
            this.picDeleteSub.Size = new System.Drawing.Size(67, 50);
            this.picDeleteSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picDeleteSub.TabIndex = 67;
            this.picDeleteSub.TabStop = false;
            this.toolTip1.SetToolTip(this.picDeleteSub, "حــــذف");
            this.picDeleteSub.Click += new System.EventHandler(this.picDeleteSub_Click);
            this.picDeleteSub.MouseEnter += new System.EventHandler(this.picDeleteSub_MouseEnter);
            this.picDeleteSub.MouseLeave += new System.EventHandler(this.picDeleteSub_MouseLeave);
            // 
            // picSaveSub
            // 
            this.picSaveSub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSaveSub.Image = global::MedicalLabs.Properties.Resources.diskette__2_;
            this.picSaveSub.Location = new System.Drawing.Point(816, 510);
            this.picSaveSub.Name = "picSaveSub";
            this.picSaveSub.Size = new System.Drawing.Size(67, 50);
            this.picSaveSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picSaveSub.TabIndex = 66;
            this.picSaveSub.TabStop = false;
            this.toolTip1.SetToolTip(this.picSaveSub, "حــــــفـــــظ");
            this.picSaveSub.Click += new System.EventHandler(this.picSaveSub_Click);
            this.picSaveSub.MouseEnter += new System.EventHandler(this.picSaveSub_MouseEnter);
            this.picSaveSub.MouseLeave += new System.EventHandler(this.picSaveSub_MouseLeave);
            // 
            // dgvSubAnalysis
            // 
            this.dgvSubAnalysis.AllowUserToAddRows = false;
            this.dgvSubAnalysis.AllowUserToDeleteRows = false;
            this.dgvSubAnalysis.AllowUserToResizeColumns = false;
            this.dgvSubAnalysis.AllowUserToResizeRows = false;
            this.dgvSubAnalysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubAnalysis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubAnalysis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSubAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id1,
            this.ت1,
            this.AnalysisName1,
            this.SubAnalysisName,
            this.Unit,
            this.Range,
            this.Num1,
            this.UnitId});
            this.dgvSubAnalysis.EnableHeadersVisualStyles = false;
            this.dgvSubAnalysis.Location = new System.Drawing.Point(3, 260);
            this.dgvSubAnalysis.MultiSelect = false;
            this.dgvSubAnalysis.Name = "dgvSubAnalysis";
            this.dgvSubAnalysis.ReadOnly = true;
            this.dgvSubAnalysis.RowHeadersVisible = false;
            this.dgvSubAnalysis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubAnalysis.Size = new System.Drawing.Size(527, 300);
            this.dgvSubAnalysis.TabIndex = 53;
            this.dgvSubAnalysis.Click += new System.EventHandler(this.dgvSubAnalysis_Click);
            // 
            // Id1
            // 
            this.Id1.DataPropertyName = "Id1";
            this.Id1.HeaderText = "Id";
            this.Id1.Name = "Id1";
            this.Id1.ReadOnly = true;
            this.Id1.Visible = false;
            // 
            // ت1
            // 
            this.ت1.DataPropertyName = "ت1";
            this.ت1.HeaderText = "ت";
            this.ت1.Name = "ت1";
            this.ت1.ReadOnly = true;
            // 
            // AnalysisName1
            // 
            this.AnalysisName1.DataPropertyName = "AnalysisName1";
            this.AnalysisName1.HeaderText = "تحليل رئيسي";
            this.AnalysisName1.Name = "AnalysisName1";
            this.AnalysisName1.ReadOnly = true;
            this.AnalysisName1.Visible = false;
            // 
            // SubAnalysisName
            // 
            this.SubAnalysisName.DataPropertyName = "SubAnalysisName";
            this.SubAnalysisName.HeaderText = "تحليل ";
            this.SubAnalysisName.Name = "SubAnalysisName";
            this.SubAnalysisName.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "وحدة";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // Range
            // 
            this.Range.DataPropertyName = "Range";
            this.Range.HeaderText = "قيمة طبيعية";
            this.Range.Name = "Range";
            this.Range.ReadOnly = true;
            // 
            // Num1
            // 
            this.Num1.DataPropertyName = "Num1";
            this.Num1.HeaderText = "Num1";
            this.Num1.Name = "Num1";
            this.Num1.ReadOnly = true;
            this.Num1.Visible = false;
            // 
            // UnitId
            // 
            this.UnitId.DataPropertyName = "UnitId";
            this.UnitId.HeaderText = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.ReadOnly = true;
            this.UnitId.Visible = false;
            // 
            // grbSubAnalysis
            // 
            this.grbSubAnalysis.Controls.Add(this.btnUnit);
            this.grbSubAnalysis.Controls.Add(this.chkAnalysis);
            this.grbSubAnalysis.Controls.Add(this.txtRange);
            this.grbSubAnalysis.Controls.Add(this.label3);
            this.grbSubAnalysis.Controls.Add(this.label5);
            this.grbSubAnalysis.Controls.Add(this.cmbUnit);
            this.grbSubAnalysis.Controls.Add(this.txtSubAnName);
            this.grbSubAnalysis.Controls.Add(this.label6);
            this.grbSubAnalysis.Controls.Add(this.label7);
            this.grbSubAnalysis.Controls.Add(this.cmbAnalysis);
            this.grbSubAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSubAnalysis.Location = new System.Drawing.Point(572, 251);
            this.grbSubAnalysis.Name = "grbSubAnalysis";
            this.grbSubAnalysis.Size = new System.Drawing.Size(336, 253);
            this.grbSubAnalysis.TabIndex = 51;
            this.grbSubAnalysis.TabStop = false;
            // 
            // btnUnit
            // 
            this.btnUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUnit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUnit.FlatAppearance.BorderSize = 0;
            this.btnUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnit.ForeColor = System.Drawing.Color.White;
            this.btnUnit.Image = ((System.Drawing.Image)(resources.GetObject("btnUnit.Image")));
            this.btnUnit.Location = new System.Drawing.Point(15, 111);
            this.btnUnit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUnit.Name = "btnUnit";
            this.btnUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUnit.Size = new System.Drawing.Size(29, 24);
            this.btnUnit.TabIndex = 673;
            this.btnUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.btnUnit, "اضافة وحدة");
            this.btnUnit.UseVisualStyleBackColor = false;
            this.btnUnit.Click += new System.EventHandler(this.btnUnit_Click);
            // 
            // chkAnalysis
            // 
            this.chkAnalysis.AutoSize = true;
            this.chkAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.chkAnalysis.Location = new System.Drawing.Point(61, 49);
            this.chkAnalysis.Name = "chkAnalysis";
            this.chkAnalysis.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkAnalysis.Size = new System.Drawing.Size(167, 23);
            this.chkAnalysis.TabIndex = 36;
            this.chkAnalysis.Text = "هل لدي تحليل نتيجة واحدة";
            this.chkAnalysis.UseVisualStyleBackColor = false;
            this.chkAnalysis.CheckedChanged += new System.EventHandler(this.chkAnalysis_CheckedChanged);
            // 
            // txtRange
            // 
            this.txtRange.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRange.Location = new System.Drawing.Point(48, 144);
            this.txtRange.Multiline = true;
            this.txtRange.Name = "txtRange";
            this.txtRange.Size = new System.Drawing.Size(179, 104);
            this.txtRange.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "القيمة الطبيعية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(250, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "أسم النتيجة";
            // 
            // cmbUnit
            // 
            this.cmbUnit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(48, 111);
            this.cmbUnit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(179, 24);
            this.cmbUnit.TabIndex = 33;
            // 
            // txtSubAnName
            // 
            this.txtSubAnName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubAnName.Location = new System.Drawing.Point(48, 79);
            this.txtSubAnName.Name = "txtSubAnName";
            this.txtSubAnName.Size = new System.Drawing.Size(179, 22);
            this.txtSubAnName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(274, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "الوحدة";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(255, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "أسم تحليل";
            // 
            // cmbAnalysis
            // 
            this.cmbAnalysis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAnalysis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnalysis.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnalysis.FormattingEnabled = true;
            this.cmbAnalysis.Location = new System.Drawing.Point(48, 19);
            this.cmbAnalysis.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbAnalysis.Name = "cmbAnalysis";
            this.cmbAnalysis.Size = new System.Drawing.Size(179, 24);
            this.cmbAnalysis.TabIndex = 17;
            this.cmbAnalysis.SelectionChangeCommitted += new System.EventHandler(this.cmbAnalysis_SelectionChangeCommitted);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label9.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(575, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(342, 39);
            this.label9.TabIndex = 50;
            this.label9.Text = "بيانات تحليل";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbAnalysis
            // 
            this.grbAnalysis.Controls.Add(this.cmbAnalysisA);
            this.grbAnalysis.Controls.Add(this.label2);
            this.grbAnalysis.Controls.Add(this.label4);
            this.grbAnalysis.Controls.Add(this.txtPrice);
            this.grbAnalysis.Location = new System.Drawing.Point(575, 30);
            this.grbAnalysis.Name = "grbAnalysis";
            this.grbAnalysis.Size = new System.Drawing.Size(334, 141);
            this.grbAnalysis.TabIndex = 23;
            this.grbAnalysis.TabStop = false;
            // 
            // cmbAnalysisA
            // 
            this.cmbAnalysisA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAnalysisA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnalysisA.FormattingEnabled = true;
            this.cmbAnalysisA.Location = new System.Drawing.Point(27, 19);
            this.cmbAnalysisA.Name = "cmbAnalysisA";
            this.cmbAnalysisA.Size = new System.Drawing.Size(194, 27);
            this.cmbAnalysisA.TabIndex = 12;
            this.cmbAnalysisA.SelectedIndexChanged += new System.EventHandler(this.cmbAnalysisA_SelectedIndexChanged);
            this.cmbAnalysisA.SelectionChangeCommitted += new System.EventHandler(this.cmbAnalysisA_SelectionChangeCommitted);
            this.cmbAnalysisA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbAnalysisA_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "أسم التحليل";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "السعر";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(27, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(194, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // dgvAnalysis
            // 
            this.dgvAnalysis.AllowUserToAddRows = false;
            this.dgvAnalysis.AllowUserToDeleteRows = false;
            this.dgvAnalysis.AllowUserToResizeColumns = false;
            this.dgvAnalysis.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            this.dgvAnalysis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnalysis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAnalysis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalysis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAnalysis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAnalysis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ت,
            this.AnalysisName,
            this.Price});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnalysis.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAnalysis.EnableHeadersVisualStyles = false;
            this.dgvAnalysis.Location = new System.Drawing.Point(0, 0);
            this.dgvAnalysis.MultiSelect = false;
            this.dgvAnalysis.Name = "dgvAnalysis";
            this.dgvAnalysis.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAnalysis.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAnalysis.RowHeadersVisible = false;
            this.dgvAnalysis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnalysis.Size = new System.Drawing.Size(530, 240);
            this.dgvAnalysis.TabIndex = 18;
            this.dgvAnalysis.Click += new System.EventHandler(this.dgvAnalysis_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // ت
            // 
            this.ت.DataPropertyName = "ت";
            this.ت.HeaderText = "ت";
            this.ت.Name = "ت";
            this.ت.ReadOnly = true;
            // 
            // AnalysisName
            // 
            this.AnalysisName.DataPropertyName = "AnalysisName";
            this.AnalysisName.HeaderText = "أسم تحليل";
            this.AnalysisName.Name = "AnalysisName";
            this.AnalysisName.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "السعر";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.btnClear);
            this.tabPage3.Controls.Add(this.btnUpdateGroup);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.txtGroup);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.lstAnalysis);
            this.tabPage3.Controls.Add(this.lstGroup);
            this.tabPage3.Controls.Add(this.grpGroup);
            this.tabPage3.Controls.Add(this.btnDelGroup);
            this.tabPage3.Controls.Add(this.btnAddGroup);
            this.tabPage3.Controls.Add(this.btnDelConGroup);
            this.tabPage3.Controls.Add(this.btnSaveConGroup);
            this.tabPage3.Controls.Add(this.btnNew);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(911, 570);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = " مجموعات";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.ImageKey = "7.jpg";
            this.label1.Location = new System.Drawing.Point(545, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(362, 66);
            this.label1.TabIndex = 251;
            this.label1.Text = "بيانات المجموعة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::MedicalLabs.Properties.Resources.rotate_arrow;
            this.btnClear.Location = new System.Drawing.Point(302, 73);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClear.Size = new System.Drawing.Size(37, 29);
            this.btnClear.TabIndex = 250;
            this.toolTip1.SetToolTip(this.btnClear, "جديد");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdateGroup
            // 
            this.btnUpdateGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnUpdateGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateGroup.FlatAppearance.BorderSize = 0;
            this.btnUpdateGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGroup.ForeColor = System.Drawing.Color.White;
            this.btnUpdateGroup.Image = global::MedicalLabs.Properties.Resources.file;
            this.btnUpdateGroup.Location = new System.Drawing.Point(422, 73);
            this.btnUpdateGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateGroup.Name = "btnUpdateGroup";
            this.btnUpdateGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUpdateGroup.Size = new System.Drawing.Size(37, 29);
            this.btnUpdateGroup.TabIndex = 245;
            this.toolTip1.SetToolTip(this.btnUpdateGroup, "تعديل");
            this.btnUpdateGroup.UseVisualStyleBackColor = false;
            this.btnUpdateGroup.Click += new System.EventHandler(this.btnUpdateGroup_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label16.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.ImageKey = "2.png";
            this.label16.Location = new System.Drawing.Point(6, 3);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(221, 35);
            this.label16.TabIndex = 244;
            this.label16.Text = "التحاليل";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGroup
            // 
            this.txtGroup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroup.Location = new System.Drawing.Point(264, 43);
            this.txtGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGroup.Size = new System.Drawing.Size(234, 29);
            this.txtGroup.TabIndex = 237;
            this.txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label32.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label32.ImageKey = "7.jpg";
            this.label32.Location = new System.Drawing.Point(264, 6);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label32.Size = new System.Drawing.Size(234, 35);
            this.label32.TabIndex = 239;
            this.label32.Text = "المجموعات";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstAnalysis
            // 
            this.lstAnalysis.FormattingEnabled = true;
            this.lstAnalysis.ItemHeight = 19;
            this.lstAnalysis.Location = new System.Drawing.Point(4, 39);
            this.lstAnalysis.Name = "lstAnalysis";
            this.lstAnalysis.Size = new System.Drawing.Size(224, 308);
            this.lstAnalysis.TabIndex = 3;
            this.lstAnalysis.Click += new System.EventHandler(this.lstAnalysis_Click);
            // 
            // lstGroup
            // 
            this.lstGroup.FormattingEnabled = true;
            this.lstGroup.ItemHeight = 19;
            this.lstGroup.Location = new System.Drawing.Point(264, 103);
            this.lstGroup.Name = "lstGroup";
            this.lstGroup.Size = new System.Drawing.Size(234, 270);
            this.lstGroup.TabIndex = 2;
            this.lstGroup.Click += new System.EventHandler(this.lstGroup_Click);
            // 
            // grpGroup
            // 
            this.grpGroup.Controls.Add(this.label11);
            this.grpGroup.Controls.Add(this.label10);
            this.grpGroup.Controls.Add(this.cmbAnalysis2);
            this.grpGroup.Controls.Add(this.cmbGroup);
            this.grpGroup.Location = new System.Drawing.Point(546, 55);
            this.grpGroup.Name = "grpGroup";
            this.grpGroup.Size = new System.Drawing.Size(362, 187);
            this.grpGroup.TabIndex = 1;
            this.grpGroup.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(260, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 21);
            this.label11.TabIndex = 14;
            this.label11.Text = "اسم التحليل";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(255, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "اسم المجموعة";
            // 
            // cmbAnalysis2
            // 
            this.cmbAnalysis2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbAnalysis2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbAnalysis2.FormattingEnabled = true;
            this.cmbAnalysis2.Location = new System.Drawing.Point(36, 106);
            this.cmbAnalysis2.Name = "cmbAnalysis2";
            this.cmbAnalysis2.Size = new System.Drawing.Size(218, 27);
            this.cmbAnalysis2.TabIndex = 1;
            // 
            // cmbGroup
            // 
            this.cmbGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(36, 32);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(218, 27);
            this.cmbGroup.TabIndex = 0;
            // 
            // btnDelGroup
            // 
            this.btnDelGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelGroup.FlatAppearance.BorderSize = 0;
            this.btnDelGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelGroup.ForeColor = System.Drawing.Color.White;
            this.btnDelGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnDelGroup.Image")));
            this.btnDelGroup.Location = new System.Drawing.Point(342, 73);
            this.btnDelGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDelGroup.Name = "btnDelGroup";
            this.btnDelGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDelGroup.Size = new System.Drawing.Size(37, 29);
            this.btnDelGroup.TabIndex = 243;
            this.toolTip1.SetToolTip(this.btnDelGroup, "حذف");
            this.btnDelGroup.UseVisualStyleBackColor = false;
            this.btnDelGroup.Click += new System.EventHandler(this.btnDelGroup_Click);
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddGroup.FlatAppearance.BorderSize = 0;
            this.btnAddGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddGroup.ForeColor = System.Drawing.Color.White;
            this.btnAddGroup.Image = ((System.Drawing.Image)(resources.GetObject("btnAddGroup.Image")));
            this.btnAddGroup.Location = new System.Drawing.Point(381, 73);
            this.btnAddGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddGroup.Size = new System.Drawing.Size(37, 29);
            this.btnAddGroup.TabIndex = 238;
            this.toolTip1.SetToolTip(this.btnAddGroup, "إضافة");
            this.btnAddGroup.UseVisualStyleBackColor = false;
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnDelConGroup
            // 
            this.btnDelConGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnDelConGroup.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelConGroup.BorderColor = System.Drawing.Color.White;
            this.btnDelConGroup.BorderRadius = 0;
            this.btnDelConGroup.BorderSize = 0;
            this.btnDelConGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelConGroup.FlatAppearance.BorderSize = 3;
            this.btnDelConGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelConGroup.Font = new System.Drawing.Font("Hacen Saudi Arabia XL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelConGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelConGroup.Image = global::MedicalLabs.Properties.Resources.delete_folder__1_;
            this.btnDelConGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelConGroup.Location = new System.Drawing.Point(366, 418);
            this.btnDelConGroup.Name = "btnDelConGroup";
            this.btnDelConGroup.Size = new System.Drawing.Size(214, 52);
            this.btnDelConGroup.TabIndex = 249;
            this.btnDelConGroup.Text = "حذف";
            this.btnDelConGroup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelConGroup.UseVisualStyleBackColor = false;
            this.btnDelConGroup.Click += new System.EventHandler(this.btnDelConGroup_Click);
            // 
            // btnSaveConGroup
            // 
            this.btnSaveConGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveConGroup.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSaveConGroup.BorderColor = System.Drawing.Color.White;
            this.btnSaveConGroup.BorderRadius = 0;
            this.btnSaveConGroup.BorderSize = 0;
            this.btnSaveConGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSaveConGroup.FlatAppearance.BorderSize = 3;
            this.btnSaveConGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveConGroup.Font = new System.Drawing.Font("Hacen Saudi Arabia XL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveConGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSaveConGroup.Image = global::MedicalLabs.Properties.Resources.file;
            this.btnSaveConGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveConGroup.Location = new System.Drawing.Point(688, 418);
            this.btnSaveConGroup.Name = "btnSaveConGroup";
            this.btnSaveConGroup.Size = new System.Drawing.Size(214, 52);
            this.btnSaveConGroup.TabIndex = 248;
            this.btnSaveConGroup.Text = "حفظ";
            this.btnSaveConGroup.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnSaveConGroup.UseVisualStyleBackColor = false;
            this.btnSaveConGroup.Click += new System.EventHandler(this.btnSaveConGroup_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnNew.BorderColor = System.Drawing.Color.White;
            this.btnNew.BorderRadius = 0;
            this.btnNew.BorderSize = 0;
            this.btnNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNew.FlatAppearance.BorderSize = 3;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Hacen Saudi Arabia XL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNew.Image = global::MedicalLabs.Properties.Resources.refresh;
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNew.Location = new System.Drawing.Point(8, 418);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(214, 52);
            this.btnNew.TabIndex = 246;
            this.btnNew.Text = "جديد";
            this.btnNew.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(919, 602);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FrmAnalysis";
            this.Text = "FrmAnalysis";
            this.Load += new System.EventHandler(this.FrmAnalysis_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmAnalysis_VisibleChanged);
            this.HandleCreated += new System.EventHandler(this.FrmAnalysis_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmAnalysis_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDeleteSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSaveSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubAnalysis)).EndInit();
            this.grbSubAnalysis.ResumeLayout(false);
            this.grbSubAnalysis.PerformLayout();
            this.grbAnalysis.ResumeLayout(false);
            this.grbAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnalysis)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.grpGroup.ResumeLayout(false);
            this.grpGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbAnalysis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvAnalysis;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpGroup;
        private System.Windows.Forms.ComboBox cmbAnalysis2;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Button btnDelGroup;
        internal System.Windows.Forms.Button btnAddGroup;
        internal System.Windows.Forms.TextBox txtGroup;
        internal System.Windows.Forms.Label label32;
        private System.Windows.Forms.ListBox lstAnalysis;
        private System.Windows.Forms.ListBox lstGroup;
        internal System.Windows.Forms.Button btnUpdateGroup;
        private Class.MyButton btnDelConGroup;
        private Class.MyButton btnSaveConGroup;
        private Class.MyButton btnNew;
        private System.Windows.Forms.ComboBox cmbAnalysisA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ت;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridView dgvSubAnalysis;
        private System.Windows.Forms.GroupBox grbSubAnalysis;
        private System.Windows.Forms.CheckBox chkAnalysis;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.TextBox txtSubAnName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbAnalysis;
        private System.Windows.Forms.PictureBox picNewSub;
        private System.Windows.Forms.PictureBox picDeleteSub;
        private System.Windows.Forms.PictureBox picSaveSub;
        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.PictureBox picDelete;
        private System.Windows.Forms.PictureBox picSave;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ت1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AnalysisName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubAnalysisName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Range;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        internal System.Windows.Forms.Button btnUnit;
    }
}