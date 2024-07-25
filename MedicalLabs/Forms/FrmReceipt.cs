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
    public partial class FrmReceipt : Form
    {
        public FrmReceipt()
        {
            InitializeComponent();
        }
        DataSet dsCustomer = new DataSet(); DataSet dsRecInvo = new DataSet(); DataSet dsNum = new DataSet();
        DataSet dsAccountS = new DataSet();
        Double invo, rec;

        private void FrmReceipt_Load(object sender, EventArgs e)
        {
            getCustomers();
            txtReceipter.Text = VariablesClass.userName;

        }
        public void getCustomers()
        {
            SQLConClass sql = new SQLConClass();
            dsCustomer = sql.selectData("SELECT Id,PatientName FROM TblPatient WHERE Del=0  ORDER BY PatientName ", 0, null);
            if (FunctionsClass.dshasTablesAndData(dsCustomer))
            {
                cmbCustomer.DataSource = dsCustomer.Tables[0];
                cmbCustomer.DisplayMember = "PatientName";
                cmbCustomer.ValueMember = "Id";
                cmbCustomer.SelectedIndex = -1;

                DataTable dt = dsCustomer.Tables[0].Copy();
                cmbPatient.DataSource = dt;
                cmbPatient.DisplayMember = "PatientName";
                cmbPatient.ValueMember = "Id";
                cmbPatient.SelectedIndex = -1;
            }
        }
        private void cmbCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedValue == null)
            {
                MessageBox.Show("اسم الصنف عير موجود", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", cmbCustomer.SelectedValue) };
            dsRecInvo = sql.selectData("PatientRecINVO", 1, param);
            if (FunctionsClass.dshasTablesAndData(dsRecInvo))
            {
                txtTotal.Text = dsRecInvo.Tables[0].Rows[0][0].ToString();
                txtReceipt.Text = dsRecInvo.Tables[1].Rows[0][0].ToString();
                Double.TryParse(txtTotal.Text,out invo);
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
        private void btnNew_Click(object sender, EventArgs e)
        {
            FunctionsClass.clear(grbRecive);
            invo = 0;
            rec = 0;
            cmbCustomer.SelectedValue = -1;
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
            SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Type],[Date],InvoNum,InvoValue,ReceiptNum,ReceiptValue FROM TblSalesAccountStatement WHERE PatientId=@Id";
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
            dsAccountS.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbCustomer.SelectedIndex == -1)
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
                new SqlParameter("@PatientId", cmbCustomer.SelectedValue),
                new SqlParameter("@UserID", VariablesClass.userId),
                new SqlParameter("@Value", txtValueReceipt.Text.Trim()),
                new SqlParameter("@Note", txtNote.Text.Trim())
            };
            SQLConClass sql = new SQLConClass();
            dsNum = sql.cmdExecuteData("InsertReceipts", param);
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

            cmbCustomer_SelectionChangeCommitted(sender, e);
        }































    }
}
