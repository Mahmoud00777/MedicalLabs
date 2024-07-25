using MedicalLabs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalLabs.Forms
{
    public partial class FrmInvoice : Form
    {
        public FrmInvoice()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet(); DataSet dsAnalysis = new DataSet(); DataSet dsInvoNum = new DataSet();
        DataSet dsReport = new DataSet();
        ResizeControls r = new ResizeControls();
        int cr = -1;
        //*************************FUNCTION*******************************************************
        public void getFillData()
        {
            SQLConClass.sqlQuery = "SELECT TblAnalysis.Id,AnalysisName,Price FROM TblAnalysis WHERE  TblAnalysis.Del=0 ORDER BY AnalysisName  ";
            SQLConClass.sqlQuery += "SELECT * FROM TblPatient WHERE Del=0 ORDER BY PatientName ";
            SQLConClass.sqlQuery += "SELECT Id,TechnicalName FROM TblTechnical WHERE Del=0 ORDER BY TechnicalName  ";
            SQLConClass.sqlQuery += "SELECT * FROM TblSource WHERE Del=0 ORDER BY SourceName ";
            SQLConClass.sqlQuery += "SELECT * FROM TblGroup ";
            SQLConClass.sqlQuery += "SELECT TblAnalysis.Id AS AnalysisId ,TblGroup.Id ,GroupName,AnalysisName,Price FROM TblGroupAnalysis,TblGroup,TblAnalysis WHERE TblGroup.Id=TblGroupAnalysis.GroupId AND TblAnalysis.Id=TblGroupAnalysis.AnalysisId ";

            SQLConClass sql = new SQLConClass();
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);

            if (FunctionsClass.dshasTablesAndData(ds))
                fillCmb();
            else
                this.Close();
        }
        public void fillCmb()
        {

            //*******************************************
            cmbAnalysis.DataSource = ds.Tables[0];
            cmbAnalysis.ValueMember = "Id";
            cmbAnalysis.DisplayMember = "AnalysisName";
            cmbAnalysis.SelectedValue = -1;
            //*******************************************
            cmbPatient.DataSource = ds.Tables[1];
            cmbPatient.ValueMember = "Id";
            cmbPatient.DisplayMember = "PatientName";
            cmbPatient.SelectedValue = -1;
            //*******************************************
            cmbTechnical.DataSource = ds.Tables[2];
            cmbTechnical.ValueMember = "Id";
            cmbTechnical.DisplayMember = "TechnicalName";
            cmbTechnical.SelectedValue = -1;
            //*******************************************
            cmbSource.DataSource = ds.Tables[3];
            cmbSource.ValueMember = "Id";
            cmbSource.DisplayMember = "SourceName";
            cmbSource.SelectedValue = 1;
            //*******************************************
            cmbGroup.DataSource = ds.Tables[4];
            cmbGroup.ValueMember = "Id";
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.SelectedValue = -1;
        }
        void total()
        {
            double total = 0;
            txtTotal.Text = total.ToString();

            foreach (DataGridViewRow row in dgvInvo.Rows)
            {
                total = total + Convert.ToDouble(row.Cells[3].Value);
            }
            txtTotal.Text = total.ToString("0.000");
            discount();

        }
        void sequence()
        {
            dgvInvo.Tag = 1;
            foreach (DataGridViewRow row in dgvInvo.Rows)
            {
                row.Cells[1].Value = dgvInvo.Tag;
                dgvInvo.Tag = Convert.ToInt32(dgvInvo.Tag) + 1;
            }
        }
        public void clear()
        {
            cr = -1;
            dgvInvo.ClearSelection();
            FunctionsClass.clear(grbInfo);
            FunctionsClass.clear(grpInvoice);
        }
        void discount()
        {
            if (txtTotal.Text.Trim() == string.Empty)
            {
                txtNet.Clear();
                return;
            }

            double percent;
            double discount;
            double.TryParse(txtdiscount.Text, out discount);


            if (chkDiscount.Checked == true)
                percent = discount;
            else if (Convert.ToDouble(txtTotal.Text) != 0)
                percent = discount / Convert.ToDouble(txtTotal.Text) * 100;
            else
                percent = 0;

            if (percent > Settings.Default.DiscountPercent)
            {
                MessageBox.Show("لقد تجاوزت نسبة التخفيض المحددة من المسؤول", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdiscount.Clear();
                txtdiscount.Focus();
            }
            else
            {
                double discountVal = Convert.ToDouble(txtTotal.Text) * percent / 100;
                txtNet.Text = (Convert.ToDouble(txtTotal.Text) - discountVal).ToString("0.000");
            }

        }
        //***************************************************************************************
        private void FrmInvoice_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmInvoice_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void FrmInvoice_Load(object sender, EventArgs e)
        {
            getFillData();
            dgvInvo.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);

        }
        private void cmbAnalysis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbAnalysis_SelectionChangeCommitted( sender,  e);
        }
        private void cmbAnalysis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbAnalysis.SelectedValue == null)
                return;

            dsAnalysis.Clear();
            SQLConClass.sqlQuery = "SELECT Id,AnalysisName,Price FROM TblAnalysis WHERE Del=0 AND Id=@Id ";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", cmbAnalysis.SelectedValue) };
            SQLConClass sql = new SQLConClass();
            dsAnalysis = sql.selectData(SQLConClass.sqlQuery, 0, param);

            var row = dsAnalysis.Tables[0].Rows[0];

            // ******************************************************************
            foreach (DataGridViewRow rowDgv in dgvInvo.Rows)
            {
                if (Convert.ToInt64(row[0]) == Convert.ToInt64(rowDgv.Cells[0].Value))
                {
                    MessageBox.Show("هذا التحليل موجود في الفاتورة", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            // ******************************************************************

            dgvInvo.Rows.Add(row[0], dgvInvo.Rows.Count + 1, row[1], row[2]);
            dgvInvo.ClearSelection();
            total();


        }
        private void cmbGroup_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbGroup.SelectedValue == null)
                return;

            DataRow[] row = ds.Tables[5].Select("Id=" + cmbGroup.SelectedValue);
            if (row.Length > 0)
            {
                DataTable dt = new DataTable();
                dt = row.CopyToDataTable();

                for (int i = 0; i <= dt.Rows.Count - 1; i++)
                {
                    dgvInvo.Rows.Add(dt.Rows[i][0], dgvInvo.Rows.Count + 1, dt.Rows[i][3], dt.Rows[i][4]);
                    dgvInvo.ClearSelection();

                }
                total();
            }

        }
        private void btnSubtractAnalysis_Click(object sender, EventArgs e)
        {
            if (cr != -1)
            {
                dgvInvo.Rows.Remove(dgvInvo.Rows[cr]);
                clear();
                sequence();
                total();
            }

        }
        private void dgvInvo_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;
            cr = dgvInvo.CurrentRow.Index;
        }
        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            discount();
            txtdiscount.SelectAll();
            txtdiscount.Focus();
        }
        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            discount();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInvoNum.Text != string.Empty)
            {
                FunctionsClass.msgTool("تم حفظ الفاتورة مسبقاً", 2);
                return;
            }

            if (dgvInvo.Rows.Count == 0)
            {
                FunctionsClass.msgTool("لا يمكن حفظ فاتورة فارغة", 2);
                return;
            }

            if (cmbPatient.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختيار اسم المريض", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPatient.Focus();
                return;
            }

            if (cmbTechnical.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختيار اسم فني تحليل", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPatient.Focus();
                return;
            }

            if (cmbSource.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختيار مصدر تحليل", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbPatient.Focus();
                return;
            }

            var dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[2]
            {
                new DataColumn("AnalysisId",typeof(int)),
                new DataColumn("Price",typeof(float))

            });

            foreach (DataGridViewRow row in dgvInvo.Rows)
                dt.Rows.Add(row.Cells[0].Value, row.Cells[3].Value);

            DateTime dateAndTime = Convert.ToDateTime(dtpDate.Value.Date + dtpTime.Value.TimeOfDay);
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@InvoDate",dateAndTime),
                new SqlParameter("@InvoDiscount", Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtNet.Text)),
                new SqlParameter("@PatientId",cmbPatient.SelectedValue),
                new SqlParameter("@TechnicalId",cmbTechnical.SelectedValue),
                new SqlParameter("@SourceId",cmbSource.SelectedValue),
                new SqlParameter("@UserId",VariablesClass.userId),
                new SqlParameter("@ChkBuy",chkBuy.Checked),
                new SqlParameter("@Content",dt)
            };

            dsInvoNum = sql.cmdExecuteData("InsertInvoice", param);

            switch (VariablesClass.Save)
            {
                case 1:
                    {
                        txtInvoNum.Text = Convert.ToInt64(dsInvoNum.Tables[0].Rows[0][0]).ToString("000000");
                        break;
                    }

            }



        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            dgvInvo.Rows.Clear();
            ds.Clear();
            dsAnalysis.Clear();
            dsInvoNum.Clear();
            chkDiscount.Checked = false;
            dtpDate.Value = DateTime.Now;
            cr = -1;
            chkBuy.Checked = true;
            FunctionsClass.clear(grbInfo);
            FunctionsClass.clear(grpInvoice);
            FunctionsClass.clear(grbPatient);
            getFillData();
        }
        private void FrmInvoice_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                getFillData();
            }
            else
            {
                ds.Clear();
                dsAnalysis.Clear();
                clear();
            }
        }
        private void cmbPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
            {
                return;
            }
            DataRow[] row = ds.Tables[1].Select("Id=" + cmbPatient.SelectedValue);
            if (row.Length >= 0)
            {
                txtGender.Text = row[0][4].ToString();
                DateTime dateTime = (DateTime)row[0][3];
                txtAge.Text = (DateTime.Now.Year - dateTime.Year).ToString();
                cmbAnalysis.Focus();
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvInvo.Rows.Count == 0)
            {
                MessageBox.Show("لاتوجد فاتورة للطباعة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", dsInvoNum.Tables[1].Rows[0][0]) };
            dsReport = sql.selectData("ViewInvo", 1, param);

            var f = new FrmPrint();
            var c = new Reports.CrtInvoice();

            c.SetDataSource(dsReport.Tables[0]);
            f.crystalReportViewer1.ReportSource = c;

            c.SetParameterValue("My Parameter", "المنظومة مختبرات الطبية");
            c.SetParameterValue("Patient", cmbPatient.Text.Trim());
            c.SetParameterValue("Age", txtAge.Text.Trim());
            c.SetParameterValue("Gender", txtGender.Text.Trim());
            c.SetParameterValue("UserName", VariablesClass.userName);

            f.crystalReportViewer1.Refresh();
            f.crystalReportViewer1.Zoom(100);
            f.WindowState = FormWindowState.Maximized;
            f.Show();

        }
        private void btnReceipt_Click(object sender, EventArgs e)
        {
            FrmReceipt frmReceipt = new FrmReceipt();
            frmReceipt.ShowDialog();
        }
        private void FrmInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNew.PerformClick();
            }
            else if (e.KeyCode == Keys.F2)
            {
                btnSave.PerformClick();
            }
            else if (e.KeyCode == Keys.F3)
            {
                btnPrint.PerformClick();
            }
            else if (e.KeyCode == Keys.F4)
            {
                btnReceipt.PerformClick();
            }
        }
        private void cmbPatient_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbPatient_SelectionChangeCommitted( sender,  e);
        }
    }

}
