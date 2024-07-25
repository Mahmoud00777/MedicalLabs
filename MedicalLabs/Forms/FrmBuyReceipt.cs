using MedicalLabs.Classes;
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
    public partial class FrmBuyReceipt : Form
    {
        public FrmBuyReceipt()
        {
            InitializeComponent();
        }
        DataSet dsDelegate = new DataSet(); DataSet dsRecInvo = new DataSet(); DataSet dsNum = new DataSet();
        DataSet dsAccountS = new DataSet();
        Double invo, rec;

        private void FrmBuyReceipt_Load(object sender, EventArgs e)
        {
            getCustomers();
            txtReceipter.Text = VariablesClass.userName;

        }
        private void cmbDelegate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbDelegate.SelectedValue == null)
            {
                MessageBox.Show("اسم الصنف عير موجود", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", cmbDelegate.SelectedValue) };
            dsRecInvo = sql.selectData("ResourceReceipt", 1, param);
            if (FunctionsClass.dshasTablesAndData(dsRecInvo))
            {
                txtTotal.Text = dsRecInvo.Tables[0].Rows[0][0].ToString();
                txtReceipt.Text = dsRecInvo.Tables[1].Rows[0][0].ToString();
                Double.TryParse(txtTotal.Text, out invo);
                Double.TryParse(txtReceipt.Text, out rec);
                txtValue.Text = (invo - rec).ToString();

            }
        }
        private void txtValueReceipt_TextChanged(object sender, EventArgs e)
        {
            if (txtValueReceipt.Text == string.Empty)
            {
                txtNet.Text = string.Empty;
                return;
            }

            double num;
            double.TryParse(txtValueReceipt.Text, out num);

            txtNet.Text = NumbersClass.NoToTxt(num, "دينار", "درهم", true).ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbDelegate.SelectedValue == null)
            {
                MessageBox.Show("اسم العميل غير موجود رجاء إدخال ", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtValueReceipt.Text == String.Empty)
            {
                MessageBox.Show("رجاء إدخال قيمة الواصل  ", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SqlParameter[] param = new SqlParameter[] {

                new SqlParameter("@ResourceId", cmbDelegate.SelectedValue),
                new SqlParameter("@UserID", VariablesClass.userId),
                new SqlParameter("@Value", txtValueReceipt.Text.Trim()),
                new SqlParameter("@Note", txtNote.Text.Trim())
            };
            SQLConClass sql = new SQLConClass();
            dsNum = sql.cmdExecuteData("InsertBuyReceipte", param);
            switch (VariablesClass.Save)
            {
                case 1:
                    {
                        txtNum.Text = Convert.ToInt64(dsNum.Tables[0].Rows[0][0]).ToString("000000");
                        break;
                    }
                case 2:
                    {
                        FunctionsClass.msgTool(" هذا الزبون لا يملك فواتير  ", 0);
                        break;
                    }
                case 0:
                    {
                        FunctionsClass.msgTool(" لم يتم حفظ الواصل   ", 0);
                        break;
                    }
            }

            cmbDelegate_SelectionChangeCommitted(sender, e);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FunctionsClass.clear(grbRecive);
            invo = 0;
            rec = 0;
            cmbDelegate.SelectedValue = -1;
            txtTotal.Text = "";
            txtReceipt.Text = "";
            txtValue.Text = "";
        }
        private void cmbPatient_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedValue == null)
            {
                MessageBox.Show("اسم الصنف عير موجود", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", cmbPatient.SelectedValue) };
            SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Type],[Date],InvoNum,InvoValue,ReceiptNum,ReceiptValue FROM TblBuyAccountStatement WHERE ResourcetId=@Id";
            dsAccountS = sql.selectData(SQLConClass.sqlQuery, 0, param);
            if (FunctionsClass.dshasTablesAndData(dsAccountS))
            {

                dgvAcconutStatment.DataSource = dsAccountS.Tables[0];
                dgvAcconutStatment.ClearSelection();
            }
        }
        private void btnNew1_Click(object sender, EventArgs e)
        {
            cmbPatient.SelectedValue = -1;
            dgvAcconutStatment.ClearSelection();
        }
        public void getCustomers()
        {
            SQLConClass sql = new SQLConClass();
            dsDelegate = sql.selectData("SELECT Id,[Name] FROM TblResource WHERE Del=0  ORDER BY [Name] ", 0, null);
            if (FunctionsClass.dshasTablesAndData(dsDelegate))
            {
                cmbDelegate.DataSource = dsDelegate.Tables[0];
                cmbDelegate.DisplayMember = "Name";
                cmbDelegate.ValueMember = "Id";
                cmbDelegate.SelectedIndex = -1;

                DataTable dt = dsDelegate.Tables[0].Copy();
                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "Name";
                cmbPatient.ValueMember = "Id";
                cmbPatient.SelectedIndex = -1;
            }
        }
    }
}
