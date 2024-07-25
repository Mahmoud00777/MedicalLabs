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
    public partial class FrmWithDrawl : Form
    {
        public FrmWithDrawl()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataSet dsSearch = new DataSet();
        DataTable dt = new DataTable();

        

        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT * FROM TblItem";
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds))
            {
                dt = ds.Tables[0].Copy();

                cmbName.DataSource = dt;
                cmbName.DisplayMember = "Name";
                cmbName.ValueMember = "Id";
                cmbName.SelectedValue = -1;
                //*******************************
                cmbSName.DataSource = ds.Tables[0];
                cmbSName.DisplayMember = "Name";
                cmbSName.ValueMember = "Id";
                cmbSName.SelectedValue = -1;
            }
        }
        public void clear()
        {
            FunctionsClass.clear(grbItem);
            getFillData();  
        }
        private void FrmWithDrawl_Load(object sender, EventArgs e)
        {
            getFillData();

        }
        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNum.Text == null)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                DataRow[] row = ds.Tables[0].Select("Num=" + txtNum.Text.Trim());
                if (row.Length > 0)
                {
                    cmbName.SelectedValue = row[0][0];
                    txtQuantity.Text = row[0][6].ToString();
                }
                else
                {
                    MessageBox.Show("لايوجد رقم الصنف الذي ادخلته", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void cmbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbName.SelectedValue == null)
                return;

            DataRow[] row = dt.Select("Id=" + cmbName.SelectedValue);
            if (row.Length > 0)
            {
                txtNum.Text = row[0][1].ToString();
                txtQuantity.Text = row[0][6].ToString();
               
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grbItem))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Convert.ToInt32(txtWDQuantity.Text) > Convert.ToInt32(txtQuantity.Text))
            {
                MessageBox.Show("قيمة الكمية المطلوبة اكبر من كمية المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@ItemId",cmbName.SelectedValue),
                new SqlParameter("@Date",dtpTime.Value),
                new SqlParameter("@Quantity",txtWDQuantity.Text.Trim()),
                new SqlParameter ("@UserId",VariablesClass.userId)};

            sql.cmdExecute("SaveWithDrawl", 1, param);
            clear();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLConClass sql = new SQLConClass();

            if (chkDate.Checked == true & chkName.Checked == false)
            {
                SQLConClass.sqlQuery = "SELECT TblWithDrawl.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS Item,[Date],Quantity,UserName FROM TblWithDrawl,TblUser,TblItem WHERE TblWithDrawl.UserId=TblUser.Id AND TblWithDrawl.ItemId=TblItem.Id AND [Date] BETWEEN @dtpFrom AND @dtpTo ORDER BY [Date] DESC";
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@dtpFrom", dtpFrom.Value), new SqlParameter("@dtpTo", dtpTo.Value) };
                dsSearch = sql.selectData(SQLConClass.sqlQuery, 0, param);
            }
            else if (chkDate.Checked == false & chkName.Checked == true)
            {
                if (cmbSName.SelectedValue == null)
                    return;

                SQLConClass.sqlQuery = "SELECT TblWithDrawl.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS Item,[Date],Quantity,UserName FROM TblWithDrawl,TblUser,TblItem WHERE TblWithDrawl.UserId=TblUser.Id AND TblWithDrawl.ItemId=TblItem.Id AND TblItem.Id=@Id ORDER BY [Date] DESC";
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", cmbSName.SelectedValue) };
                dsSearch = sql.selectData(SQLConClass.sqlQuery, 0, param);

            }
            else
            {
                if (cmbSName.SelectedValue == null)
                    return;

                SQLConClass.sqlQuery = "SELECT TblWithDrawl.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS Item,[Date],Quantity,UserName FROM TblWithDrawl,TblUser,TblItem WHERE TblWithDrawl.UserId=TblUser.Id AND TblWithDrawl.ItemId=TblItem.Id AND [Date] BETWEEN @dtpFrom AND @dtpTo AND TblItem.Id=@Id ORDER BY [Date] DESC";
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", cmbSName.SelectedValue),
                                                            new SqlParameter("@dtpFrom",dtpFrom.Value)
                                                             ,new SqlParameter("@dtpTo",dtpTo.Value)  };

                dsSearch = sql.selectData(SQLConClass.sqlQuery, 0, param);

            }
            if (FunctionsClass.dshasTablesAndData(dsSearch))
            {
                dgvItem.DataSource = dsSearch.Tables[0];
                dgvItem.ClearSelection();
            }
        }
    }
}
