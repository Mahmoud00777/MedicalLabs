namespace MedicalLabs.Forms
{
    partial class FrmTechnical
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
            this.dgvTechnical = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ت = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TechnicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Specialize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTechnical = new System.Windows.Forms.GroupBox();
            this.btnDelete = new MedicalLabs.Class.MyButton();
            this.btnٍSave = new MedicalLabs.Class.MyButton();
            this.btnClear = new MedicalLabs.Class.MyButton();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSpecialize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).BeginInit();
            this.grbTechnical.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTechnical
            // 
            this.dgvTechnical.AllowUserToAddRows = false;
            this.dgvTechnical.AllowUserToDeleteRows = false;
            this.dgvTechnical.AllowUserToResizeColumns = false;
            this.dgvTechnical.AllowUserToResizeRows = false;
            this.dgvTechnical.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTechnical.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTechnical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnical.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ت,
            this.TechnicalName,
            this.Specialize,
            this.Address,
            this.Phone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTechnical.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTechnical.Location = new System.Drawing.Point(3, 228);
            this.dgvTechnical.Name = "dgvTechnical";
            this.dgvTechnical.ReadOnly = true;
            this.dgvTechnical.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTechnical.RowHeadersVisible = false;
            this.dgvTechnical.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTechnical.Size = new System.Drawing.Size(794, 264);
            this.dgvTechnical.TabIndex = 0;
            this.dgvTechnical.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTechnical_ColumnHeaderMouseClick);
            this.dgvTechnical.Click += new System.EventHandler(this.dgvTechnical_Click);
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
            // TechnicalName
            // 
            this.TechnicalName.DataPropertyName = "TechnicalName";
            this.TechnicalName.HeaderText = "الاسم";
            this.TechnicalName.Name = "TechnicalName";
            this.TechnicalName.ReadOnly = true;
            // 
            // Specialize
            // 
            this.Specialize.DataPropertyName = "Specialize";
            this.Specialize.HeaderText = "التخصص";
            this.Specialize.Name = "Specialize";
            this.Specialize.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "العنوان";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "رقم الهاتف";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // grbTechnical
            // 
            this.grbTechnical.Controls.Add(this.btnDelete);
            this.grbTechnical.Controls.Add(this.btnٍSave);
            this.grbTechnical.Controls.Add(this.btnClear);
            this.grbTechnical.Controls.Add(this.txtPhone);
            this.grbTechnical.Controls.Add(this.txtAddress);
            this.grbTechnical.Controls.Add(this.txtSpecialize);
            this.grbTechnical.Controls.Add(this.label4);
            this.grbTechnical.Controls.Add(this.label3);
            this.grbTechnical.Controls.Add(this.label2);
            this.grbTechnical.Controls.Add(this.txtName);
            this.grbTechnical.Controls.Add(this.label1);
            this.grbTechnical.Location = new System.Drawing.Point(8, 12);
            this.grbTechnical.Name = "grbTechnical";
            this.grbTechnical.Size = new System.Drawing.Size(783, 210);
            this.grbTechnical.TabIndex = 1;
            this.grbTechnical.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Hacen Saudi Arabia XL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelete.Image = global::MedicalLabs.Properties.Resources.delete_folder__1_;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(306, 162);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(163, 42);
            this.btnDelete.TabIndex = 52;
            this.btnDelete.Text = "حذف";
            this.btnDelete.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnٍSave
            // 
            this.btnٍSave.BackColor = System.Drawing.Color.Transparent;
            this.btnٍSave.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnٍSave.BorderColor = System.Drawing.Color.Transparent;
            this.btnٍSave.BorderRadius = 0;
            this.btnٍSave.BorderSize = 2;
            this.btnٍSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnٍSave.FlatAppearance.BorderSize = 3;
            this.btnٍSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnٍSave.Font = new System.Drawing.Font("Hacen Saudi Arabia XL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnٍSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnٍSave.Image = global::MedicalLabs.Properties.Resources.file;
            this.btnٍSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnٍSave.Location = new System.Drawing.Point(572, 162);
            this.btnٍSave.Name = "btnٍSave";
            this.btnٍSave.Size = new System.Drawing.Size(163, 42);
            this.btnٍSave.TabIndex = 51;
            this.btnٍSave.Text = "حفظ";
            this.btnٍSave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnٍSave.UseVisualStyleBackColor = false;
            this.btnٍSave.Click += new System.EventHandler(this.btnٍSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderColor = System.Drawing.Color.Transparent;
            this.btnClear.BorderRadius = 0;
            this.btnClear.BorderSize = 2;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.FlatAppearance.BorderSize = 3;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Hacen Saudi Arabia XL", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.Image = global::MedicalLabs.Properties.Resources.refresh;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(20, 162);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 42);
            this.btnClear.TabIndex = 50;
            this.btnClear.Text = "جديد";
            this.btnClear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(18)))), ((int)(((byte)(130)))));
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(264, 101);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(171, 21);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(264, 25);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(171, 21);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddress_KeyDown);
            // 
            // txtSpecialize
            // 
            this.txtSpecialize.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialize.Location = new System.Drawing.Point(530, 101);
            this.txtSpecialize.Name = "txtSpecialize";
            this.txtSpecialize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSpecialize.Size = new System.Drawing.Size(171, 21);
            this.txtSpecialize.TabIndex = 5;
            this.txtSpecialize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSpecialize_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "رقم الهاتف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "التخصص";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(530, 24);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(171, 21);
            this.txtName.TabIndex = 1;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Hacen Saudi Arabia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(725, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "الاسم";
            // 
            // FrmTechnical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 495);
            this.Controls.Add(this.grbTechnical);
            this.Controls.Add(this.dgvTechnical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTechnical";
            this.Text = "FrmTechnical";
            this.Load += new System.EventHandler(this.FrmTechnical_Load);
            this.HandleCreated += new System.EventHandler(this.FrmTechnical_HandleCreated);
            this.Resize += new System.EventHandler(this.FrmTechnical_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).EndInit();
            this.grbTechnical.ResumeLayout(false);
            this.grbTechnical.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTechnical;
        private System.Windows.Forms.GroupBox grbTechnical;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSpecialize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private Class.MyButton btnDelete;
        private Class.MyButton btnٍSave;
        private Class.MyButton btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ت;
        private System.Windows.Forms.DataGridViewTextBoxColumn TechnicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Specialize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}