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
    public partial class FrmSubResult : Form
    {
        public FrmSubResult()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int cr = -1;
        private void FrmSubResult_Load(object sender, EventArgs e)
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT TblResult.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,SubAnalysisName,Result,[Range],Unit FROM TblResult,TblSubAnalysis,TblUnit WHERE TblSubAnalysis.Id=TblResult.SubAnalysisId AND TblUnit.Id=TblSubAnalysis.UnitId AND InvoId=@InvoId AND AnalysisId=@AnalysisId";
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@InvoId", VariablesClass.invoId),
                                                         new SqlParameter("@AnalysisId",VariablesClass.analysisId) };
            ds = sql.selectData(SQLConClass.sqlQuery, 0, param);
            if (FunctionsClass.dsHasTables(ds))
            {
                dgvSubAnalysis.DataSource = ds.Tables[0];
                dgvSubAnalysis.ClearSelection();
            }
            txtResult.Focus();
            txtResult.Select();
        }
        private void button1_Click(object sender, EventArgs e)
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
        private void btnSave_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dgvSubAnalysis.Rows)
                VariablesClass.dtResults.Rows.Add(row.Cells[0].Value, 1, row.Cells[3].Value);


            this.Close();
            FunctionsClass.msgTool("تم إدخال النتيجة ", 1);

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
        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvSubAnalysis.Rows[cr].Cells[3].Value = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbResult_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cr == -1)
            {
                MessageBox.Show("الرجاء إختيار التحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbResult.SelectedValue == null)
            {
                return;
            }
            dgvSubAnalysis.Rows[cr].Cells[3].Value = cmbResult.Text;
        }

        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cr == -1)
            {
                MessageBox.Show("الرجاء إختيار التحليل ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cmbResult.SelectedIndex == -1)
            {
                return;
            }
            dgvSubAnalysis.Rows[cr].Cells[3].Value = cmbResult.Text;
        }
    }
}
