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
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        int cr = -1, employeeId = 0;

        public void getfillData()
        {

            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS EmployeeName,JobTitle,JobStart,Birthday,Phone,Email,[Address],pic FROM TblEmployees WHERE Del=0";
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds))
            {
                dgvEmployee.DataSource = ds.Tables[0];
                dgvEmployee.ClearSelection();
            }

        }
        public void displayData()
        {
            employeeId = (int)dgvEmployee.Rows[cr].Cells[0].Value;
            txtUserName.Text = dgvEmployee.Rows[cr].Cells[2].Value.ToString();
            txtUserJob.Text = dgvEmployee.Rows[cr].Cells[3].Value.ToString();
            dtpStart.Value = (DateTime)dgvEmployee.Rows[cr].Cells[4].Value;
            dtpBirth.Value = (DateTime)dgvEmployee.Rows[cr].Cells[5].Value;
            txtUserPhone.Text = dgvEmployee.Rows[cr].Cells[6].Value.ToString();
            txtUserEmail.Text = dgvEmployee.Rows[cr].Cells[7].Value.ToString();
            txtAddress.Text = dgvEmployee.Rows[cr].Cells[8].Value.ToString();
            if (dgvEmployee.Rows[cr].Cells[9].Value is DBNull)
            {
                picUser.Image = null;
                picUser.BackgroundImage = Properties.Resources.user;
            }
            else
            {
                picUser.Image = FunctionsClass.byteToImage((byte[])dgvEmployee.Rows[cr].Cells[9].Value);
                picUser.BackgroundImage = null;
            }

        }
        private void dgvEmployee_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;
            cr = dgvEmployee.CurrentRow.Index;
            displayData();

        }
        private void FrmEmployee_Load(object sender, EventArgs e)
        {
            getfillData();
        }
        private void cmsDeletePic_Click(object sender, EventArgs e)
        {
            picUser.Image = null;
            picUser.BackgroundImage = Properties.Resources.user;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (employeeId == 0)
                return;

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id",employeeId)};

            sql.cmdExecute("DeleteEmployee", 1, param);
            getfillData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grpUserInfo))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id",employeeId),
                                                        new SqlParameter("@Name",txtUserName.Text.Trim()),
                                                        new SqlParameter("@JobTitle",txtUserJob.Text.Trim()),
                                                        new SqlParameter("@JobStart",dtpStart.Value),
                                                        new SqlParameter("@Birth",dtpBirth.Value),
                                                        new SqlParameter("@Phone",txtUserPhone.Text.Trim()),
                                                        new SqlParameter("@Email",txtUserEmail.Text.Trim()),
                                                        new SqlParameter("@Address",txtAddress.Text.Trim()),
                                                        new SqlParameter("@Pic", (picUser.Image==null)?null: FunctionsClass.imageToByte(picUser))};

            sql.cmdExecute("SaveEmployee",1,param);

            getfillData();
            btnNew_Click(sender, e);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FunctionsClass.clear(grpUserInfo);
            picUser.Image = Properties.Resources.user;
            dgvEmployee.ClearSelection();
            employeeId = 0;
            getfillData();
        }
        private void picUser_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                openFileDialog1.Filter = "(Image Files)|*.jpg;*.png;*.bmp;*.gif;*.ico|Jpg, | *.jpg|Png, | *.png|Bmp, | *.bmp|Gif, | *.gif|Ico | *.ico";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    picUser.Image = Image.FromFile(openFileDialog1.FileName);
                    picUser.BackgroundImage = null;
                }
            }
        }
    }
}
