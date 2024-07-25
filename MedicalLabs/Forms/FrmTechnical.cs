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
    public partial class FrmTechnical : Form
    {
        public FrmTechnical()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int cr = -1,technicalId;
        ResizeControls r = new ResizeControls();

        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,TechnicalName,Specialize,[Address],Phone FROM TblTechnical WHERE Del=0 ORDER BY TechnicalName ";
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds))
            {
                dgvTechnical.DataSource = ds.Tables[0];
                dgvTechnical.ClearSelection();
            }
        }
        public void displayData()
        {
            technicalId = (int)dgvTechnical.Rows[cr].Cells[0].Value;
            txtName.Text = dgvTechnical.Rows[cr].Cells[2].Value.ToString();
            txtSpecialize.Text = dgvTechnical.Rows[cr].Cells[3].Value.ToString();
            txtAddress.Text = dgvTechnical.Rows[cr].Cells[4].Value.ToString();
            txtPhone.Text= dgvTechnical.Rows[cr].Cells[5].Value.ToString();
        }
        public void selectedTechnical()
        {
            DataRow[] itemRows = ds.Tables[0].Select("TechnicalName='" + txtName.Text.Trim() + "'");
            if (itemRows.Length > 0)
            {
                cr = Convert.ToInt32(itemRows[0][1]) - 1;
                dgvTechnical.Rows[cr].Selected = true;
                dgvTechnical.FirstDisplayedScrollingRowIndex = cr;
                displayData();
            }
        }
        public void clear()
        {
            dgvTechnical.ClearSelection();
            technicalId = 0;
            FunctionsClass.clear(grbTechnical);
            getFillData();
        }
        private void dgvTechnical_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;
            cr = dgvTechnical.CurrentRow.Index;
            displayData();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnٍSave_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grbTechnical))
            {
                MessageBox.Show("الرجاء ملئ حقول البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //***************************************************************
            {
                DataRow[] perm = VariablesClass.dtUserPermissions.Select("OperationID=7");
                if ((bool)perm[0]["InsertP"] == false & technicalId == 0)
                {
                    MessageBox.Show("ليس لديك صلاحية الإضافة", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else if ((bool)perm[0]["UpdateP"] == false & technicalId != 0)
                {
                    MessageBox.Show("ليس لديك صلاحية التعديل", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            //***************************************************************
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@Id",technicalId),
                                                       new SqlParameter("@Name",txtName.Text.Trim()),
                                                       new SqlParameter("@Specailize",txtSpecialize.Text.Trim()),
                                                       new SqlParameter("@Address",txtAddress.Text.Trim()),
                                                       new SqlParameter("@Phone",txtPhone.Text.Trim())};
            sql.cmdExecute("SaveTechnical",1,param);
            clear();
            selectedTechnical();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (technicalId == 0)
            {
                MessageBox.Show("الرجاء تحديد التقني المراد حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد انك تريد حذف؟", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sql = new SQLConClass();
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", technicalId) };
                sql.cmdExecute("DeleteTechnical", 1, param);
                getFillData();
            }

            
        }
        private void FrmTechnical_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmTechnical_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void dgvTechnical_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //ds.Tables[0] = FunctionsClass.columnHeaderMouseClick((DataGridView)sender, ds.Tables[0]);
           // clear();
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnٍSave.PerformClick();
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.isPositiveIntNum(e);
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSpecialize.Focus();
            }
        }
        private void txtSpecialize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAddress.Focus();
            }
        }
        private void txtAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }
        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            getFillData();
            dgvTechnical.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);
            txtName.Focus();
        }
    }
}
