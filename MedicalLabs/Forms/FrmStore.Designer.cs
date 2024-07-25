namespace MedicalLabs.Forms
{
    partial class FrmStore
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pnlPagenation = new System.Windows.Forms.Panel();
            this.txtPageNum = new System.Windows.Forms.TextBox();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPagesCount = new System.Windows.Forms.Label();
            this.btnPreviousPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.radEmpty = new System.Windows.Forms.RadioButton();
            this.radLow = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.grbStore = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLowQuantity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStore = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Items = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expirment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLost = new System.Windows.Forms.Button();
            this.btnWithDrawl = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.pnlPagenation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.grbStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnlPagenation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(3, 437);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(658, 56);
            this.groupBox2.TabIndex = 269;
            this.groupBox2.TabStop = false;
            // 
            // pnlPagenation
            // 
            this.pnlPagenation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.pnlPagenation.Controls.Add(this.txtPageNum);
            this.pnlPagenation.Controls.Add(this.btnFirstPage);
            this.pnlPagenation.Controls.Add(this.btnLastPage);
            this.pnlPagenation.Controls.Add(this.label2);
            this.pnlPagenation.Controls.Add(this.lblPagesCount);
            this.pnlPagenation.Controls.Add(this.btnPreviousPage);
            this.pnlPagenation.Controls.Add(this.btnNextPage);
            this.pnlPagenation.Location = new System.Drawing.Point(200, 11);
            this.pnlPagenation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPagenation.Name = "pnlPagenation";
            this.pnlPagenation.Size = new System.Drawing.Size(452, 36);
            this.pnlPagenation.TabIndex = 246;
            // 
            // txtPageNum
            // 
            this.txtPageNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPageNum.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.txtPageNum.Location = new System.Drawing.Point(282, 3);
            this.txtPageNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPageNum.Name = "txtPageNum";
            this.txtPageNum.Size = new System.Drawing.Size(64, 29);
            this.txtPageNum.TabIndex = 245;
            this.txtPageNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPageNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPageNum_KeyDown);
            this.txtPageNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPageNum_KeyPress);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.FlatAppearance.BorderSize = 0;
            this.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.Location = new System.Drawing.Point(396, 2);
            this.btnFirstPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnFirstPage.Size = new System.Drawing.Size(54, 32);
            this.btnFirstPage.TabIndex = 244;
            this.btnFirstPage.Text = "<<";
            this.btnFirstPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirstPage.UseVisualStyleBackColor = false;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.FlatAppearance.BorderSize = 0;
            this.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.Location = new System.Drawing.Point(179, 2);
            this.btnLastPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLastPage.Size = new System.Drawing.Size(54, 32);
            this.btnLastPage.TabIndex = 243;
            this.btnLastPage.Text = ">>";
            this.btnLastPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLastPage.UseVisualStyleBackColor = false;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(68, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 228;
            this.label2.Text = "عدد الصفحات";
            // 
            // lblPagesCount
            // 
            this.lblPagesCount.BackColor = System.Drawing.Color.White;
            this.lblPagesCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPagesCount.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagesCount.Location = new System.Drawing.Point(2, 3);
            this.lblPagesCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPagesCount.Name = "lblPagesCount";
            this.lblPagesCount.Size = new System.Drawing.Size(63, 30);
            this.lblPagesCount.TabIndex = 241;
            this.lblPagesCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousPage
            // 
            this.btnPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnPreviousPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousPage.FlatAppearance.BorderSize = 0;
            this.btnPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPreviousPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousPage.ForeColor = System.Drawing.Color.White;
            this.btnPreviousPage.Location = new System.Drawing.Point(356, 2);
            this.btnPreviousPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPreviousPage.Name = "btnPreviousPage";
            this.btnPreviousPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPreviousPage.Size = new System.Drawing.Size(37, 32);
            this.btnPreviousPage.TabIndex = 239;
            this.btnPreviousPage.Text = "<";
            this.btnPreviousPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPreviousPage.UseVisualStyleBackColor = false;
            this.btnPreviousPage.Click += new System.EventHandler(this.btnPreviousPage_Click);
            // 
            // btnNextPage
            // 
            this.btnNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnNextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextPage.FlatAppearance.BorderSize = 0;
            this.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextPage.ForeColor = System.Drawing.Color.White;
            this.btnNextPage.Location = new System.Drawing.Point(236, 2);
            this.btnNextPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnNextPage.Size = new System.Drawing.Size(37, 32);
            this.btnNextPage.TabIndex = 238;
            this.btnNextPage.Text = ">";
            this.btnNextPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(73, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 242;
            this.label3.Text = "حجم الصفحة";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(8, 16);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.numericUpDown1.Size = new System.Drawing.Size(59, 29);
            this.numericUpDown1.TabIndex = 240;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // radEmpty
            // 
            this.radEmpty.AutoSize = true;
            this.radEmpty.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmpty.Location = new System.Drawing.Point(227, 138);
            this.radEmpty.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radEmpty.Name = "radEmpty";
            this.radEmpty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radEmpty.Size = new System.Drawing.Size(209, 23);
            this.radEmpty.TabIndex = 273;
            this.radEmpty.Text = "عرض الأصناف التي نفذت من المخزن";
            this.radEmpty.UseVisualStyleBackColor = true;
            this.radEmpty.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radLow
            // 
            this.radLow.AutoSize = true;
            this.radLow.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLow.Location = new System.Drawing.Point(30, 111);
            this.radLow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radLow.Name = "radLow";
            this.radLow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radLow.Size = new System.Drawing.Size(200, 23);
            this.radLow.TabIndex = 272;
            this.radLow.Text = "عرض الأصناف الأقل من الحد الأدنى";
            this.radLow.UseVisualStyleBackColor = true;
            this.radLow.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(413, 111);
            this.radAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radAll.Name = "radAll";
            this.radAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radAll.Size = new System.Drawing.Size(242, 23);
            this.radAll.TabIndex = 271;
            this.radAll.TabStop = true;
            this.radAll.Text = "عرض جميع الأصناف الموجودة في المخزن";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblSearch.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.lblSearch.Location = new System.Drawing.Point(240, 77);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSearch.Size = new System.Drawing.Size(185, 21);
            this.lblSearch.TabIndex = 276;
            this.lblSearch.Text = "اكتب اسم أو رقم الصنف للبحث";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.BackColor = System.Drawing.Color.White;
            this.txtFilter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(3, 72);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFilter.Size = new System.Drawing.Size(658, 29);
            this.txtFilter.TabIndex = 275;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // grbStore
            // 
            this.grbStore.Controls.Add(this.label7);
            this.grbStore.Controls.Add(this.txtQuantity);
            this.grbStore.Controls.Add(this.label5);
            this.grbStore.Controls.Add(this.label4);
            this.grbStore.Controls.Add(this.txtLowQuantity);
            this.grbStore.Controls.Add(this.txtName);
            this.grbStore.Controls.Add(this.txtNum);
            this.grbStore.Controls.Add(this.label1);
            this.grbStore.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStore.Location = new System.Drawing.Point(668, 54);
            this.grbStore.Name = "grbStore";
            this.grbStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbStore.Size = new System.Drawing.Size(278, 246);
            this.grbStore.TabIndex = 277;
            this.grbStore.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(214, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "الكمية ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(16, 141);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(151, 26);
            this.txtQuantity.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "الكمية الادنى";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "اسم الصنف";
            // 
            // txtLowQuantity
            // 
            this.txtLowQuantity.Location = new System.Drawing.Point(16, 190);
            this.txtLowQuantity.Name = "txtLowQuantity";
            this.txtLowQuantity.Size = new System.Drawing.Size(151, 26);
            this.txtLowQuantity.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(16, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(16, 40);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(151, 26);
            this.txtNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الصنف";
            // 
            // dgvStore
            // 
            this.dgvStore.AllowUserToAddRows = false;
            this.dgvStore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStore.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvStore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStore.ColumnHeadersHeight = 35;
            this.dgvStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.N,
            this.Num,
            this.Items,
            this.StoreQuantity,
            this.LowQuantity,
            this.Expirment});
            this.dgvStore.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStore.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStore.Location = new System.Drawing.Point(5, 167);
            this.dgvStore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvStore.MultiSelect = false;
            this.dgvStore.Name = "dgvStore";
            this.dgvStore.ReadOnly = true;
            this.dgvStore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStore.RowHeadersVisible = false;
            this.dgvStore.RowHeadersWidth = 102;
            this.dgvStore.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.dgvStore.RowTemplate.DividerHeight = 2;
            this.dgvStore.RowTemplate.Height = 35;
            this.dgvStore.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStore.Size = new System.Drawing.Size(656, 275);
            this.dgvStore.TabIndex = 278;
            this.dgvStore.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvStore_CellFormatting);
            this.dgvStore.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStore_ColumnHeaderMouseClick);
            this.dgvStore.Click += new System.EventHandler(this.dgvStore_Click);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // N
            // 
            this.N.DataPropertyName = "N";
            this.N.HeaderText = "ت";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            // 
            // Num
            // 
            this.Num.DataPropertyName = "Num";
            this.Num.HeaderText = "الرقم";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            // 
            // Items
            // 
            this.Items.DataPropertyName = "Items";
            this.Items.HeaderText = "البيان";
            this.Items.Name = "Items";
            this.Items.ReadOnly = true;
            // 
            // StoreQuantity
            // 
            this.StoreQuantity.DataPropertyName = "StoreQuantity";
            this.StoreQuantity.HeaderText = "الكمية";
            this.StoreQuantity.Name = "StoreQuantity";
            this.StoreQuantity.ReadOnly = true;
            // 
            // LowQuantity
            // 
            this.LowQuantity.DataPropertyName = "LowQuantity";
            this.LowQuantity.HeaderText = "أدني كمية";
            this.LowQuantity.Name = "LowQuantity";
            this.LowQuantity.ReadOnly = true;
            // 
            // Expirment
            // 
            this.Expirment.DataPropertyName = "Expirment";
            this.Expirment.HeaderText = "الصلاحية";
            this.Expirment.Name = "Expirment";
            this.Expirment.ReadOnly = true;
            // 
            // btnLost
            // 
            this.btnLost.BackColor = System.Drawing.Color.White;
            this.btnLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLost.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnLost.FlatAppearance.BorderSize = 3;
            this.btnLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLost.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLost.ForeColor = System.Drawing.Color.Navy;
            this.btnLost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLost.ImageIndex = 32;
            this.btnLost.Location = new System.Drawing.Point(674, 327);
            this.btnLost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLost.Name = "btnLost";
            this.btnLost.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLost.Size = new System.Drawing.Size(272, 46);
            this.btnLost.TabIndex = 280;
            this.btnLost.Text = "التالف و المفقود";
            this.btnLost.UseVisualStyleBackColor = false;
            this.btnLost.Click += new System.EventHandler(this.btnLost_Click);
            // 
            // btnWithDrawl
            // 
            this.btnWithDrawl.BackColor = System.Drawing.Color.White;
            this.btnWithDrawl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWithDrawl.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnWithDrawl.FlatAppearance.BorderSize = 3;
            this.btnWithDrawl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithDrawl.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithDrawl.ForeColor = System.Drawing.Color.Navy;
            this.btnWithDrawl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWithDrawl.ImageIndex = 32;
            this.btnWithDrawl.Location = new System.Drawing.Point(674, 384);
            this.btnWithDrawl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnWithDrawl.Name = "btnWithDrawl";
            this.btnWithDrawl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnWithDrawl.Size = new System.Drawing.Size(272, 46);
            this.btnWithDrawl.TabIndex = 281;
            this.btnWithDrawl.Text = "سحب من المخزن";
            this.btnWithDrawl.UseVisualStyleBackColor = false;
            this.btnWithDrawl.Click += new System.EventHandler(this.btnWithDrawl_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label8.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Image = global::MedicalLabs.Properties.Resources.to_do_list;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(669, 9);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 65);
            this.label8.TabIndex = 279;
            this.label8.Text = "بيانات الاصناف";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.label6.Font = new System.Drawing.Font("Hacen Saudi Arabia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Image = global::MedicalLabs.Properties.Resources.to_do_list;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(658, 60);
            this.label6.TabIndex = 274;
            this.label6.Text = "قائمة الأصناف في المخزن";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 498);
            this.Controls.Add(this.btnWithDrawl);
            this.Controls.Add(this.btnLost);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvStore);
            this.Controls.Add(this.grbStore);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radEmpty);
            this.Controls.Add(this.radLow);
            this.Controls.Add(this.radAll);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmStore";
            this.Text = "FrmStore";
            this.Load += new System.EventHandler(this.FrmStore_Load);
            this.VisibleChanged += new System.EventHandler(this.FrmStore_VisibleChanged);
            this.HandleCreated += new System.EventHandler(this.FrmStore_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmStore_Resize);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlPagenation.ResumeLayout(false);
            this.pnlPagenation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.grbStore.ResumeLayout(false);
            this.grbStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.Panel pnlPagenation;
        internal System.Windows.Forms.TextBox txtPageNum;
        internal System.Windows.Forms.Button btnFirstPage;
        internal System.Windows.Forms.Button btnLastPage;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblPagesCount;
        internal System.Windows.Forms.Button btnPreviousPage;
        internal System.Windows.Forms.Button btnNextPage;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.NumericUpDown numericUpDown1;
        internal System.Windows.Forms.RadioButton radEmpty;
        internal System.Windows.Forms.RadioButton radLow;
        internal System.Windows.Forms.RadioButton radAll;
        internal System.Windows.Forms.Label lblSearch;
        internal System.Windows.Forms.TextBox txtFilter;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbStore;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLowQuantity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvStore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantity;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Items;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LowQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expirment;
        internal System.Windows.Forms.Button btnLost;
        internal System.Windows.Forms.Button btnWithDrawl;
    }
}