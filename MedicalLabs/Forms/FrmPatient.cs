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
    public partial class FrmPatient : Form
    {
        public FrmPatient()
        {
            InitializeComponent();
        }
        ResizeControls r = new ResizeControls();
        DataSet ds = new DataSet();
        int cr = -1, patientId;
        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,PatientName,Num,PatientBirthdate,Gender,SocialStatus,Phone FROM TblPatient WHERE Del=0 ORDER BY PatientName";
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds)) ;
            {
                dgvPatient.DataSource = ds.Tables[0];
                dgvPatient.ClearSelection();
            }
        }
        private void FrmPatient_Load(object sender, EventArgs e)
        {
            getFillData();
            dgvPatient.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);

        }
        public void displayData()
        {
            patientId = (int)dgvPatient.Rows[cr].Cells[0].Value;
            txtName.Text = dgvPatient.Rows[cr].Cells[2].Value.ToString();
            txtNum.Text = dgvPatient.Rows[cr].Cells[3].Value.ToString();
            dtpAge.Value = (DateTime)dgvPatient.Rows[cr].Cells[4].Value;
            cmbGender.Text = dgvPatient.Rows[cr].Cells[5].Value.ToString();
            cmbSoical.Text = dgvPatient.Rows[cr].Cells[6].Value.ToString();
            txtPhone.Text = dgvPatient.Rows[cr].Cells[7].Value.ToString();
        }
        public void clear()
        {
            FunctionsClass.clear(grbPatient);
            cr = -1;
            patientId = 0;
            dgvPatient.ClearSelection();
            getFillData();
        }
        public void selectedTechnical()
        {
            DataRow[] itemRows = ds.Tables[0].Select("PatientName='" + txtName.Text.Trim() + "'");
            if (itemRows.Length > 0)
            {
                cr = Convert.ToInt32(itemRows[0][1]) - 1;
                dgvPatient.Rows[cr].Selected = true;
                dgvPatient.FirstDisplayedScrollingRowIndex = cr;
                displayData();
            }
        }
        private void FrmPatient_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void dgvPatient_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;
            cr = dgvPatient.CurrentRow.Index;
            displayData();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (patientId == 0)
            {
                MessageBox.Show("الرجاء تحديد المريض المراد حذفه", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("هل أنت متأكد انك تريد حذف؟", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sql = new SQLConClass();
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", patientId) };
                sql.cmdExecute("DeletePatient", 1, param);
                clear();
            }
            

        }
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (FunctionsClass.checkEmptyInput(grbPatient))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //**************************************************************************************
            DataRow[] perm = VariablesClass.dtUserPermissions.Select("OperationID=6");
            if ((bool)perm[0]["InsertP"] == false & patientId == 0)
            {
                MessageBox.Show("ليس لديك صلاحية الإضافة", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if ((bool)perm[0]["UpdateP"] == false & patientId != 0)
            {
                MessageBox.Show("ليس لديك صلاحية التعديل", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //*************************************************************************************




            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@Id",patientId),
                                                       new SqlParameter("@Name",txtName.Text.Trim()),
                                                       new SqlParameter("@Num",txtNum.Text.Trim()),
                                                       new SqlParameter("@BirthDate",dtpAge.Value),
                                                       new SqlParameter("@Gender",cmbGender.Text.Trim()),
                                                       new SqlParameter("@Socail",cmbSoical.Text.Trim()),
                                                       new SqlParameter("@Phone",txtPhone.Text.Trim())};
            sql.cmdExecute("SavePatient", 1, param);
            clear();

        }
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtNum.Focus();
            }
        }
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.isPositiveIntNum(e);
        }
        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpAge.Focus();
            }
        }
        private void dtpAge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbGender.Focus();
            }
        }
        private void cmbGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbSoical.Focus();
            }
        }
        private void cmbSoical_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPhone.Focus();
            }
        }
        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.PerformClick();
            }
        }
        private void FrmPatient_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
    }
}
