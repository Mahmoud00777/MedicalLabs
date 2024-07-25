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
    public partial class FrmLostAndDamaged : Form
    {
        public FrmLostAndDamaged()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        DataSet dsSearch = new DataSet();
        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT * FROM TblItem  SELECT * FROM TblCause";
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds))
            {
                cmbName.DataSource = ds.Tables[0];
                cmbName.DisplayMember = "Name";
                cmbName.ValueMember = "Id";
                cmbName.SelectedValue = -1;
                //***********************************
                cmbCause.DataSource = ds.Tables[1];
                cmbCause.DisplayMember = "CauseName";
                cmbCause.ValueMember = "Id";
                cmbCause.SelectedValue = -1;
                //**********************************
                cmbSCause.DataSource = ds.Tables[1];
                cmbSCause.DisplayMember = "CauseName";
                cmbSCause.ValueMember = "Id";
                cmbSCause.SelectedValue = -1;
            }
        }
        public void clear()
        {
            FunctionsClass.clear(grbItem);
            getFillData();
        }
        private void FrmLostAndDamaged_Load(object sender, EventArgs e)
        {
            getFillData();

        }
        private void cmbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbName.SelectedValue == null)
                return;

            DataRow[] row = ds.Tables[0].Select("Id=" + cmbName.SelectedValue);
            if (row.Length > 0)
            {
                txtNum.Text = row[0][1].ToString();
                txtQantity.Text = row[0][6].ToString();
                txtPurchs.Text = row[0][8].ToString();
            }
        }
        private void txtNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtNum.Text == null)
            {
                return;
            }

            if (e.KeyCode == Keys.Enter)
            {
                DataRow[] row = ds.Tables[0].Select("Num=" + txtNum.Text);
                if (row.Length > 0)
                {
                    cmbName.SelectedValue = row[0][0];
                    txtQantity.Text = row[0][6].ToString();
                    txtPurchs.Text = row[0][8].ToString();
                }
                else
                {
                    MessageBox.Show("لايوجد رقم الصنف الذي ادخلته", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grbItem))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Convert.ToInt32(txtLostQuantity.Text) > Convert.ToInt32(txtQantity.Text))
            {
                MessageBox.Show("قيمة الكمية مفقودة اكبر من كمية المخزن", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@ItemId",cmbName.SelectedValue),
                new SqlParameter("CauseId",cmbCause.SelectedValue),
                new SqlParameter("@Date",dtpTime.Value),
                new SqlParameter("@Quantity",txtLostQuantity.Text.Trim()),
                new SqlParameter ("@UserId",VariablesClass.userId)};

            sql.cmdExecute("SaveLostItem", 1, param);
            clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SQLConClass sql = new SQLConClass();

            if (chkDate.Checked == true & chkCause.Checked == false)
            {
                SQLConClass.sqlQuery = "SELECT TblLostAndDamage.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS Item,[Date],Quantity,CauseName,UserName  FROM TblLostAndDamage,TblCause,TblUser,TblItem WHERE TblLostAndDamage.CauseId=TblCause.Id AND TblLostAndDamage.UserId=TblUser.Id AND TblLostAndDamage.ItemId=TblItem.Id AND [Date] BETWEEN @dtpFrom AND @dtpTO ORDER BY [Date] DESC";
                SqlParameter[] param = new SqlParameter[] {new SqlParameter("@dtpFrom",dtoFrom.Value),new SqlParameter("@dtpTo",dtpTo.Value) };
               dsSearch = sql.selectData(SQLConClass.sqlQuery, 0, param);
            }
            else if (chkDate.Checked == false & chkCause.Checked == true)
            {
                if (cmbSCause.SelectedValue == null)
                    return;

                SQLConClass.sqlQuery = "SELECT TblLostAndDamage.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS Item,[Date],Quantity,CauseName,UserName  FROM TblLostAndDamage,TblCause,TblUser,TblItem WHERE TblLostAndDamage.CauseId=TblCause.Id AND TblLostAndDamage.UserId=TblUser.Id AND TblLostAndDamage.ItemId=TblItem.Id AND CauseId=@CauseId ORDER BY [Date] DESC";
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@CauseId", cmbSCause.SelectedValue) };
                dsSearch = sql.selectData(SQLConClass.sqlQuery, 0, param);

            }
            else
            {
                if (cmbSCause.SelectedValue == null)
                    return;

                SQLConClass.sqlQuery = "SELECT TblLostAndDamage.Id,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,[Name] AS Item,[Date],Quantity,CauseName,UserName  FROM TblLostAndDamage,TblCause,TblUser,TblItem WHERE TblLostAndDamage.CauseId=TblCause.Id AND TblLostAndDamage.UserId=TblUser.Id AND TblLostAndDamage.ItemId=TblItem.Id AND CauseId=@CauseId AND [Date] BETWEEN @dtpFrom AND @dtpTO ORDER BY [Date] DESC";
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@CauseId", cmbSCause.SelectedValue),
                                                            new SqlParameter("@dtpFrom",dtoFrom.Value)
                                                             ,new SqlParameter("@dtpTo",dtpTo.Value)  };

                dsSearch = sql.selectData(SQLConClass.sqlQuery, 0, param);

            }
            if (FunctionsClass.dshasTablesAndData(dsSearch))
            {
                dgvSearch.DataSource = dsSearch.Tables[0];
                dgvSearch.ClearSelection();
            }

        }
    }
}
