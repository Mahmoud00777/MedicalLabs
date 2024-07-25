using MedicalLabs.Classes;
using MedicalLabs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalLabs.Forms
{
    public partial class FrmDelElements : Form
    {
        public FrmDelElements()
        {
            InitializeComponent();
        }

        DataSet dsElement = new DataSet();
        int Id;
        ResizeControls r = new ResizeControls();

        private void FrmDelElements_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;
        }
        private void FrmDelElements_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmDelElements_FormClosing(object sender, FormClosingEventArgs e)
        {
            FunctionsClass.userTrafficRegister(this.Name, false);
            VariablesClass.mainActive = true;
        }
        //--------------------------------------------------------------------
        private void FrmDelElements_Load(object sender, EventArgs e)
        {

            radInvoice.Checked = true;
            setFormSize();
            dgvDelElements.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10);
        }
        void setFormSize()
        {
            this.Size = Settings.Default.FrmMainSize - new Size(0, 55);
            this.Location = Settings.Default.FrmMainLocation;
            this.Top += 30;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtFilter.Text = "";
            txtFilter.Focus();
            dgvDelElements.ClearSelection();
            Id = 0;
        }
        private void radInvoice_CheckedChanged(object sender, EventArgs e)
        {
            if (radInvoice.Checked)
            {
                SQLConClass sqlCon = new SQLConClass();
                SQLConClass.sqlQuery = "SELECT TblInvo.Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N,CONVERT(NVARCHAR,InvoNum,50) InvoNum,[Date],TblPatient.PatientName,TblUser.userName FROM TblInvo,TblPatient,TblUser WHERE TblInvo.PatientId=TblPatient.Id And TblInvo.userId=TblUser.Id And TblInvo.Del='TRUE'";
                dsElement = sqlCon.selectData(SQLConClass.sqlQuery, 0, default);
                if (FunctionsClass.dsHasTables(dsElement))
                {
                    dgvDelElements.DataSource = dsElement.Tables[0];
                    dgvDelElements.Columns[0].Visible = false;
                    dgvDelElements.Columns[1].HeaderText = "ت";
                    dgvDelElements.Columns[1].Width = 30;
                    dgvDelElements.Columns[2].HeaderText = "رقم الفاتورة";
                    dgvDelElements.Columns[2].Width = 100;
                    dgvDelElements.Columns[3].HeaderText = "التاريخ";
                    dgvDelElements.Columns[4].HeaderText = "اسم العميل";
                    dgvDelElements.Columns[5].HeaderText = "المستخدم";

                }
                lblFind.Text = "اكتب اسم العميل أو رقم الفاتورة للبحث";
                btnRefresh.PerformClick();
            }
        }
        private void radCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radCustomer.Checked == true)
            {
                var sqlCon = new SQLConClass();
                SQLConClass.sqlQuery = "SELECT Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N ,CONVERT(NVARCHAR,Id,50) PatientId,PatientName,Gender,Phone,PatientBirthdate FROM TblPatient WHERE Del=1";
                dsElement = sqlCon.selectData(SQLConClass.sqlQuery, 0, default);
                if (FunctionsClass.dsHasTables(dsElement))
                {
                    dgvDelElements.DataSource = dsElement.Tables[0];
                    dgvDelElements.Columns[0].Visible = false;
                    dgvDelElements.Columns[1].HeaderText = "ت";
                    dgvDelElements.Columns[1].Width = 30;
                    dgvDelElements.Columns[2].HeaderText = "رقم التسجيل";
                    dgvDelElements.Columns[3].Width = 200;
                    dgvDelElements.Columns[3].HeaderText = "اسم المريض";
                    dgvDelElements.Columns[4].HeaderText = "الجنس";
                    dgvDelElements.Columns[5].HeaderText = "رقم الهاتف";
                    dgvDelElements.Columns[6].HeaderText = "تاريخ ميلاد";
                }
                lblFind.Text = "اكتب اسم المريض أو رقم التسجيل للبحث";
                btnRefresh.PerformClick();
            }
        }
        private void radItem_CheckedChanged(object sender, EventArgs e)
        {
            if (radItem.Checked == true)
            {
                //dsElement = new DataSet();
                SQLConClass sqlCon = new SQLConClass();
                SQLConClass.sqlQuery = "SELECT TblAnalysis.Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N ,AnalysisName,Price FROM TblAnalysis WHERE TblAnalysis.Del='true'";
                dsElement = sqlCon.selectData(SQLConClass.sqlQuery, 0, default);
                if (dsElement.Tables.Count > 0)
                {

                    dgvDelElements.DataSource = dsElement.Tables[0];
                    dgvDelElements.Columns[0].Visible = false;
                    dgvDelElements.Columns[1].Width = 30;
                    dgvDelElements.Columns[1].HeaderText = "ت";
                    dgvDelElements.Columns[2].HeaderText = "اسم تحليل";
                    dgvDelElements.Columns[3].HeaderText = "سعر";
                    

                    // ------------هذا الكود---------------------------
                    //((DataGridViewImageColumn)dgvDelElements.Columns["Pic"]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
                lblFind.Text = "اكتب اسم التحليل";
                btnRefresh.PerformClick();
            }
        }
        private void radCategory_CheckedChanged(object sender, EventArgs e)
        {
            //if (radCategory.Checked == true)
            //{
            //    SQLConClass sqlCon = new SQLConClass();
            //    SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N ,Category FROM TblCategories WHERE Del=1";
            //    dsElement = sqlCon.selectData(SQLConClass.sqlQuery, 0, default);
            //    if (dsElement.Tables.Count == 1)
            //    {
            //        dgvDelElements.DataSource = dsElement.Tables[0];
            //        dgvDelElements.Columns[0].Visible = false;
            //        dgvDelElements.Columns[1].HeaderText = "ت";
            //        dgvDelElements.Columns[2].Width = 450;
            //        dgvDelElements.Columns[2].HeaderText = "اسم المجموعة";
            //    }
            //    lblFind.Text = "اكتب اسم المجموعة للبحث";
            //    btnRefresh.PerformClick();
            //}
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (radInvoice.Checked)
                dsElement.Tables[0].DefaultView.RowFilter = " PatientName Like '%" + txtFilter.Text.Trim() + "%' OR InvoNum Like '%" + txtFilter.Text.Trim() + "%'";
            else if (radCustomer.Checked)
                dsElement.Tables[0].DefaultView.RowFilter = " PatientName Like '%" + txtFilter.Text.Trim() + "%' OR PatientId Like '%" + txtFilter.Text.Trim() + "%'";
            else if (radItem.Checked)
                dsElement.Tables[0].DefaultView.RowFilter = " AnalysisName Like '%" + txtFilter.Text.Trim() + "%'";
            

            dgvDelElements.ClearSelection();
        }
        private void dgvDelElements_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError(dgvDelElements))
                return;
            Id = (int)dgvDelElements.Rows[dgvDelElements.CurrentRow.Index].Cells[0].Value;
        }
        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "استرجاع بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل انت متأكد تريد استرجاع العنصر المحدد", "استرجاع بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sqlCon = new SQLConClass();
                if (radInvoice.Checked)
                {
                    SQLConClass.sqlQuery = "UPDATE TblInvo SET Del=0 WHERE Id=" + Id;
                    sqlCon.cmdExecute(SQLConClass.sqlQuery, 0, default);
                    radInvoice_CheckedChanged(sender, e);
                }
                else if (radCustomer.Checked)
                {
                    SQLConClass.sqlQuery = "UPDATE TblPatient SET Del=0 WHERE Id=" + Id;
                    sqlCon.cmdExecute(SQLConClass.sqlQuery, 0, null);
                    radCustomer_CheckedChanged(sender, e);
                    FrmPatient frmPatient = Application.OpenForms.OfType<FrmPatient>().FirstOrDefault();
                    if (frmPatient != null)
                        frmPatient.getFillData(); // public In Form Customer
                }
                else if (radItem.Checked)
                {
                    SQLConClass.sqlQuery = "UPDATE TblAnalysis SET Del='FALSE' WHERE Id=" + Id;

                    if (sqlCon.cmdExecute(SQLConClass.sqlQuery, 0, default) == 0)
                        FunctionsClass.msgTool("لم يتم الحفظ، يجب استرجاع مجموعة الصنف ", 0);

                    radItem_CheckedChanged(sender, e);
                    FrmAnalysis frmAnalysis = Application.OpenForms.OfType<FrmAnalysis>().FirstOrDefault();
                    if (frmAnalysis != null)
                        frmAnalysis.getFillData();
                }
                
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
