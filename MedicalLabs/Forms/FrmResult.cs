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
    public partial class FrmResult : Form
    {
        public FrmResult()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataSet dsInvo = new DataSet();
        DataSet dsSearch = new DataSet();
        DataSet dsReport = new DataSet();
        int cr = -1;
        ResizeControls r = new ResizeControls();


        private void FrmResult_Load(object sender, EventArgs e)
        {
            getFillData();
            dtpFrom.CustomFormat = Settings.Default.DateFormat;
            dtpTo.CustomFormat = Settings.Default.DateFormat;
            dgvInvoices.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);
            dgvSubAnalysis.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);


        }
        //*****************************FUNCTION***********************************
        public void getFillData()
        {
            SQLConClass.sqlQuery = "SELECT TblInvo.Id,[Date],InvoNum,PatientName,TechnicalName FROM TblInvo,TblPatient,TblTechnical WHERE TblInvo.PatientId=TblPatient.Id AND TblInvo.TechnicalId=TblTechnical.Id AND TblInvo.Del=0 ORDER BY [Date] DESC  ";
            SQLConClass.sqlQuery += "SELECT * FROM TblPatient WHERE Del=0 ORDER BY PatientName";
            SQLConClass sql = new SQLConClass();
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds))
            {
                dgvInvoices.DataSource = ds.Tables[0];
                dgvInvoices.ClearSelection();
                cmbPatient.DataSource = ds.Tables[1];
                cmbPatient.DisplayMember = "PatientName";
                cmbPatient.ValueMember = "Id";
                cmbPatient.SelectedValue = -1;
            }
        }
        public void clear()
        {
            FunctionsClass.clear(grbDate);
            FunctionsClass.clear(grbPatient);
            dsInvo.Clear();
            dsReport.Clear();
            getFillData();
            VariablesClass.dtResults.Clear();
            VariablesClass.invoId = 0;

        }
        //************************************************************************
        private void dgvInvoices_Click(object sender, EventArgs e)
        {
            cr = dgvInvoices.CurrentRow.Index;
            VariablesClass.invoId = (int)dgvInvoices.Rows[cr].Cells[0].Value;
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT TblResult.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,SubAnalysisName,Result,[Range],Unit FROM TblResult,TblSubAnalysis,TblUnit WHERE TblSubAnalysis.Id=TblResult.SubAnalysisId AND TblUnit.Id=TblSubAnalysis.UnitId AND InvoId=@InvoId";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@InvoId", VariablesClass.invoId) };
            dsInvo = sql.selectData(SQLConClass.sqlQuery, 0, param);
            if (FunctionsClass.dsHasTables(dsInvo))
            {
                dgvSubAnalysis.DataSource = dsInvo.Tables[0];
                dgvSubAnalysis.ClearSelection();
            }



        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvSubAnalysis.Rows.Count == 0)
            {
                FunctionsClass.msgTool("لا توجد نتائج تم إدخالها", 2);
                return;
            }

            var dtResults = new DataTable();    
            dtResults.Columns.AddRange(new DataColumn[3]
                                                         {
                                                             new DataColumn("InvoId",typeof(int)),
                                                             new DataColumn("SubAnalysisId",typeof(int)),
                                                             new DataColumn("Result",typeof(string))

                                                         });
            foreach (DataGridViewRow row in dgvSubAnalysis.Rows)
                dtResults.Rows.Add(row.Cells[0].Value, 1, row.Cells[3].Value);


            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Content", dtResults),
                                                        new SqlParameter("InvoId",VariablesClass.invoId)
                                                       };
            sql.cmdExecute("SaveResult", 1, param);


        }
        private void FrmResult_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                getFillData();
            }
            else
            {
                ds.Clear();
                dsInvo.Clear();
                VariablesClass.dtResults.Clear();
            }
        }
        private void FrmResult_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmResult_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void cmbPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
                return;

            DataRow[] row = ds.Tables[1].Select("Id=" + cmbPatient.SelectedValue);
            if (row.Length > 0)
            {
                txtGender.Text = row[0][4].ToString();
                DateTime dateTime = (DateTime)row[0][3];
                txtAge.Text = (DateTime.Now.Year - dateTime.Year).ToString();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLConClass sql = new SQLConClass();

            if (chkPatient.Checked == true & chkDate.Checked == false)
            {
                if (cmbPatient.SelectedValue == null)
                    return;


                SqlParameter[] param = new SqlParameter[] {new SqlParameter("@PatientId",cmbPatient.SelectedValue)
                                                            };

                dsSearch = sql.selectData("FindInvoPatient", 1, param);


            }
            else if (chkDate.Checked == true & chkPatient.Checked == false)
            {
                DateTime dateTimeFrom = Convert.ToDateTime(dtpFrom.Value.Date + dtTimeFrom.Value.TimeOfDay);
                DateTime dateTimeTo = Convert.ToDateTime(dtpTo.Value.Date + dtTimeTo.Value.TimeOfDay);

                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@FromDate", dateTimeFrom),
                                                            new SqlParameter("@ToDate", dateTimeTo)
                                                            };

                dsSearch = sql.selectData("FindInvoDate", 1, param);
            }
            else if (chkDate.Checked == true & chkPatient.Checked == true)
            {
                if (cmbPatient.SelectedValue == null)
                    return;

                DateTime dateTimeFrom = Convert.ToDateTime(dtpFrom.Value.Date + dtTimeFrom.Value.TimeOfDay);
                DateTime dateTimeTo = Convert.ToDateTime(dtpTo.Value.Date + dtTimeTo.Value.TimeOfDay);
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@FromDate", dateTimeFrom),
                                                            new SqlParameter("@ToDate", dateTimeTo),
                                                            new SqlParameter("@PatientId",cmbPatient.SelectedValue)
                                                            };


                dsSearch = sql.selectData("FindInvoPatientDate", 1, param);
            }
            if (!FunctionsClass.dshasTablesAndData(dsSearch))
            {
                MessageBox.Show("لا توجد فواتير لهذا المريض", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvInvoices.DataSource = dsSearch.Tables[0];




        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            if (VariablesClass.invoId == 0)
            {
                MessageBox.Show("لاتوجد نتائج للطباعة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", VariablesClass.invoId) };
            dsReport = sql.selectData("ViewResult", 1, param);

            var f = new FrmPrint();
            var c = new Reports.CrtResult();

            c.SetDataSource(dsReport.Tables[0]);
            f.crystalReportViewer1.ReportSource = c;

            c.SetParameterValue("Name", "المنظومة مختبرات الطبية");
            c.SetParameterValue("UserName", VariablesClass.userName);
            c.SetParameterValue("Patient", dsReport.Tables[1].Rows[0][0]);
            c.SetParameterValue("Gender", dsReport.Tables[1].Rows[0][1]);
            DateTime dateTime = (DateTime)dsReport.Tables[1].Rows[0][2];
            int age = DateTime.Now.Year - dateTime.Year;
            c.SetParameterValue("Age", age);


            f.crystalReportViewer1.Refresh();
            f.crystalReportViewer1.Zoom(100);
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (rdResult.Checked == true)
            {
                dgvSubAnalysis.Rows[cr].Cells[3].Value = txtResult.Text;
            }
            else if (rdChoseResult.Checked == true)
            {
                dgvSubAnalysis.Rows[cr].Cells[3].Value = cmbResult.Text;
            }
        }
        private void txtResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cr == -1)
                {
                    MessageBox.Show("الرجاء إختيار التحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvSubAnalysis.Rows[cr].Cells[3].Value = txtResult.Text;
                txtResult.SelectAll();
            }
        }
        private void cmbResult_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cr == -1)
                {
                    MessageBox.Show("الرجاء إختيار التحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvSubAnalysis.Rows[cr].Cells[3].Value = cmbResult.Text;
            }
        }
        private void dgvSubAnalysis_Click(object sender, EventArgs e)
        {
            cr = dgvSubAnalysis.CurrentRow.Index;
        }
        private void cmbResult_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cr == -1)
            //{
            //    MessageBox.Show("الرجاء إختيار التحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //dgvSubAnalysis.Rows[cr].Cells[3].Value = cmbResult.Text;

        }
        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cr == -1)
            {
                MessageBox.Show("الرجاء إختيار التحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvSubAnalysis.Rows[cr].Cells[3].Value = cmbResult.Text;
        }
        private void dgvSubAnalysis_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //cr = dgvSubAnalysis.CurrentRow.Index;
                cr++;
            }
        }
    }
}
