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
    public partial class FrmCategorey : Form
    {
        public FrmCategorey()
        {
            InitializeComponent();
        }

        DataSet dsCategorey = new DataSet();
        int cr = -1, categoreyId;

        private void FrmCategorey_Load(object sender, EventArgs e)
        {
            fillDgvData();
            setDgvHeader();
        }
        private void dgvCategorey_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;

            cr = dgvCategorey.CurrentRow.Index;
            displayData();
        }
        private void txtCategoreyName_TextChanged(object sender, EventArgs e)
        {
            if (categoreyId == 0)
                dsCategorey.Tables[0].DefaultView.RowFilter = "Categorey like '%" + txtCategoreyName.Text + "%'";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
            fillDgvData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (categoreyId != 0)
                return;
            save();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (categoreyId == 0)
                return;
            save();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (categoreyId == 0)
            {
                MessageBox.Show("الرجاء تحديد عنصر من القائمة", "حذف بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل تريد حذف التصنيف" + Environment.NewLine + Environment.NewLine + txtCategoreyName.Text.Trim(), "حذف بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sql =  new SQLConClass();
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id",categoreyId) };
                sql.cmdExecute("DeleteCategorey",1,param);

                btnClear.PerformClick();

            }
        } 

        //**************************FUNCTION**********************************************************
        public void setDgvHeader()
        {
            if (!FunctionsClass.dsHasTables(dsCategorey))
                return;
            dgvCategorey.Columns[0].Visible = false;
            dgvCategorey.Columns[1].Width = 50;
            dgvCategorey.Columns[2].HeaderText = "مجموعة";
        }
        public void fillDgvData()
        {
            SQLConClass.sqlQuery = "SELECT Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت,Categorey FROM TblCategorey ORDER BY Categorey";
            SQLConClass sql = new SQLConClass();
            dsCategorey = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(dsCategorey))
            {
                dgvCategorey.DataSource = dsCategorey.Tables[0];
                dgvCategorey.ClearSelection();
            }
            else
                this.Close();
        }
        public void displayData()
        {
            categoreyId = (int)dgvCategorey.Rows[cr].Cells[0].Value;
            txtCategoreyName.Text = dgvCategorey.Rows[cr].Cells[2].Value.ToString();
            txtCategoreyName.Focus();
        }
        public void clearData()
        {
            cr = -1;
            categoreyId = 0;
            txtCategoreyName.Clear();
            dgvCategorey.ClearSelection();
            txtCategoreyName.Focus();
        }
        public void save()
        {
            if (txtCategoreyName.Text == null)
                return;

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id",categoreyId)
                                                        , new SqlParameter("@Categorey",txtCategoreyName.Text.Trim()) };

            sql.cmdExecute("SaveCategorey",1,param);
            fillDgvData();
            selectData();

        }
        public void selectData()
        {
            DataRow[] dataRow = dsCategorey.Tables[0].Select("Categorey='"+txtCategoreyName.Text.Trim()+"'");
            if (dataRow.Length > 0)
            {
                cr = Convert.ToInt32(dataRow[0][1]) - 1;
                dgvCategorey.Rows[cr].Selected = true;
                dgvCategorey.FirstDisplayedScrollingRowIndex = cr;
                displayData();
            }

        }
        //******************************************************************************************








    }
}
