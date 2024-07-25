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
    public partial class FrmItem : Form
    {
        public FrmItem()
        {
            InitializeComponent();
        }
        ResizeControls r = new ResizeControls();
        DataSet ds = new DataSet();
        DataSet dsItem = new DataSet();
        int itemId = 0;

        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT * FROM TblItem WHERE  Del=0 ORDER BY Name ";
            SQLConClass.sqlQuery += "SELECT * FROM TblUnit WHERE  [Type]=2 ORDER BY Unit ";
            ds = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(ds))
            {
                lstItem.DataSource = ds.Tables[0];
                lstItem.DisplayMember = "Name";
                lstItem.ValueMember = "Id";
                lstItem.SelectedValue = -1;
                lstItem.ClearSelected();
                //**********************************
                cmbName.DataSource = ds.Tables[0];
                cmbName.DisplayMember = "Name";
                cmbName.ValueMember = "Id";
                cmbName.SelectedValue = -1;
                //*********************************
                cmbUnit.DataSource = ds.Tables[1];
                cmbUnit.DisplayMember = "Unit";
                cmbUnit.ValueMember = "Id";
                cmbUnit.SelectedValue = -1;

            }

        }
        public void clear()
        {
            FunctionsClass.clear(grpItem);
            itemId = 0;
            getFillData();
            lstItem.ClearSelected();

        }
        private void FrmItem_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmItem_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void FrmItem_Load(object sender, EventArgs e)
        {
            getFillData();
        }
        private void lstItem_Click(object sender, EventArgs e)
        {
            if (lstItem.SelectedValue == null)
                return;

            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT * FROM TblItem WHERE Id=" + lstItem.SelectedValue;
            dsItem = sql.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dshasTablesAndData(dsItem))
            {
                DataRow row = dsItem.Tables[0].Rows[0];
                itemId = (int)row[0];
                txtNum.Text = row[1].ToString();
                cmbName.Text = row[2].ToString();
                txtDescribe.Text = row[4].ToString();
                cmbUnit.SelectedValue = row[5];
                txtLowQuantity.Text = row[7].ToString();
                txtPurchasePrice.Text = row[8].ToString();

                txtNum.SelectAll();
                txtNum.Focus();
            }
        }
        private void cmbName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbName.SelectedValue == null)
            {
                MessageBox.Show("الصنف عير موجود", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbName.Text = "";
                return;
            }

            DataRow[] rows = ds.Tables[0].Select("Id=" + cmbName.SelectedValue);
            lstItem.SelectedValue = rows[0][0];
            lstItem_Click(sender, e);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grpItem))
            {
                MessageBox.Show("الرجاء ملئ جميع الحقول", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //**************************************************************************************
            DataRow[] perm = VariablesClass.dtUserPermissions.Select("OperationID=8");
            if ((bool)perm[0]["InsertP"] == false & itemId == 0)
            {
                MessageBox.Show("ليس لديك صلاحية الإضافة", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if ((bool)perm[0]["UpdateP"] == false & itemId != 0)
            {
                MessageBox.Show("ليس لديك صلاحية التعديل", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //***************************************************************************************

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id",itemId),
                new SqlParameter("@Num",txtNum.Text.Trim()),
                new SqlParameter("@Name",cmbName.Text.Trim()),
                new SqlParameter("@Describe",txtDescribe.Text.Trim()),
                new SqlParameter("@UnitId",cmbUnit.SelectedValue),
                new SqlParameter("@LowQuantity", txtLowQuantity.Text.Trim()),
                new SqlParameter("@PurchesSales", txtPurchasePrice.Text.Trim()) };

            sql.cmdExecute("SaveItem", 1, param);
            clear();

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (itemId == 0)
                return;
            if (MessageBox.Show("هل أنت متأكد انك تريد حذف؟", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sql = new SQLConClass();
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", itemId), };
                sql.cmdExecute("DeleteItem", 1, param);
                clear();
            }
            

        }
        private void FrmItem_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                getFillData();
            }
            else
            {
                clear();
            }
        }
    }
}
