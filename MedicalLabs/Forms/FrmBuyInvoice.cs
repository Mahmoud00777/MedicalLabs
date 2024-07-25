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
    public partial class FrmBuyInvoice : Form
    {
        public FrmBuyInvoice()
        {
            InitializeComponent();
        }
        ResizeControls r = new ResizeControls();
        bool selectAllText;
        DataSet ds = new DataSet();
        DataSet dsItem = new DataSet();
        DataSet dsStore = new DataSet();
        int cr = -1;

        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT * FROM TblItem SELECT * FROM TblResource ";
            ds = sql.selectData(SQLConClass.sqlQuery,0,null);
            if (FunctionsClass.dsHasTables(ds))
            {
                cmbItemName.DataSource = ds.Tables[0];
                cmbItemName.DisplayMember = "Name";
                cmbItemName.ValueMember = "Id";
                cmbItemName.SelectedValue = -1;
                //************************************
                cmbCustomerName.DataSource = ds.Tables[1];
                cmbCustomerName.DisplayMember = "Name";
                cmbCustomerName.ValueMember = "Id";
                cmbCustomerName.SelectedValue = -1;
            }

        }
        void clearItem()
        {
            dgvItems.ClearSelection(); cr = -1;
            FunctionsClass.clear(grpItem);
            txtInvoiceQuantity.Clear();
        }
        void displayData()
        {
            txtItemNum.Text = dgvItems.Rows[cr].Cells[2].Value.ToString();
            cmbItemName.Text = dgvItems.Rows[cr].Cells[3].Value.ToString().Substring(0, dgvItems.Rows[cr].Cells[3].Value.ToString().IndexOf("-"));
            txtItemDescribe.Text = dgvItems.Rows[cr].Cells[9].Value.ToString();
            txtItemUnit.Text = dgvItems.Rows[cr].Cells[11].Value.ToString();
            txtItemPrice.Text = dgvItems.Rows[cr].Cells[5].Value.ToString();
            dtpExp.Value =(DateTime)dgvItems.Rows[cr].Cells[7].Value;

            txtInvoiceQuantity.Text = dgvItems.Rows[cr].Cells[4].Value.ToString();
        }
        void total()
        {
            double total = 0;
            txtTotal.Text = total.ToString();

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                total = total + Convert.ToDouble(row.Cells[6].Value);
            }
            txtTotal.Text = total.ToString("0.000");
            discount();
        }
        void discount()
        {
            if (txtTotal.Text.Trim() == string.Empty)
            {
                txtNet.Clear();
                return;
            }

            double percent;
            double discount;
            double.TryParse(txtdiscount.Text, out discount);


            if (chkDiscount.Checked == true)
                percent = discount;
            else if (Convert.ToDouble(txtTotal.Text) != 0)
                percent = discount / Convert.ToDouble(txtTotal.Text) * 100;
            else
                percent = 0;

            if (percent > Settings.Default.DiscountPercent)
            {
                MessageBox.Show("لقد تجاوزت نسبة التخفيض المحددة من المسؤول", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtdiscount.Clear();
                txtdiscount.Focus();
            }
            else
            {
                double discountVal = Convert.ToDouble(txtTotal.Text) * percent / 100;
                txtNet.Text = (Convert.ToDouble(txtTotal.Text) - discountVal).ToString("0.000");
            }

        }
        void sequence()
        {
            dgvItems.Tag = 1;
            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.Cells[1].Value = dgvItems.Tag;
                dgvItems.Tag = Convert.ToInt32(dgvItems.Tag) + 1;
            }
        }
        void setNewQuantity()
        {
            var row = dgvItems.Rows[cr];
            row.Cells[6].Value = (Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value)).ToString();

            total();
        }
        private void FrmBuyInvoice_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmBuyInvoice_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void FrmBuyInvoice_Load(object sender, EventArgs e)
        {
            getFillData();
            dtpDate.CustomFormat=Settings.Default.DateFormat;
            dtpExp.CustomFormat = Settings.Default.DateFormat;
            //dgvItems.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 18, 130);
            dgvItems.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);
        }
        private void txtItemNum_TextChanged(object sender, EventArgs e)
        {
            if (txtItemNum.Text.Trim() == string.Empty)
                clearItem();
        }
        private void dtpExp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvItems.Rows[cr].Cells[7].Value = dtpExp.Value;
            }
        }   
        private void txtItemNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtItemNum.Text.Trim() == string.Empty)
                return;

            if (e.KeyCode == Keys.Enter)
            {
                // جلب بيانات الصنف من الجدول
                SQLConClass sqlCon = new SQLConClass();
                SQLConClass.sqlQuery = "SELECT TblItem.Id,Num,[Name],Expirment,Descripe,Unit,StoreQuantity,LowQuantity,PurchesPrice FROM TblItem,TblUnit WHERE TblUnit.Id=TblItem.UnitID AND Num=@Num";
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Num", txtItemNum.Text.Trim()) };

                dsItem = sqlCon.selectData(SQLConClass.sqlQuery, 0, param);


                if (!FunctionsClass.dshasTablesAndData(dsItem))
                {
                    MessageBox.Show("رقم الصنف غير موجود", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtItemNum.SelectAll();
                    txtItemNum.Focus();
                    return;
                }

                // dgv البحث هل الصنف موجود في 
                // ******************************************************************
                foreach (DataGridViewRow row in dgvItems.Rows)
                {
                    if (Convert.ToInt64(txtItemNum.Text.Trim()) == Convert.ToInt64(row.Cells[2].Value))
                    {

                        row.Cells[4].Value = Convert.ToInt32(row.Cells[4].Value) + 1;
                        row.Cells[6].Value = Convert.ToDouble(row.Cells[4].Value) * Convert.ToDouble(row.Cells[5].Value);
                        row.Selected = true;
                        dgvItems.FirstDisplayedScrollingRowIndex = row.Index;
                        cr = row.Index;
                        displayData();
                        total();



                        txtItemNum.Focus();
                        txtItemNum.SelectAll();
                        return;
                    }
                }
                // ******************************************************************
                // اضافة صف جديد بكمية مبدئية 1 
                {
                    var row = dsItem.Tables[0].Rows[0];

                    dgvItems.Rows.Add(row[0], dgvItems.Rows.Count + 1, row[1], row[2] + "-" + row[4], 1, row[8], Convert.ToDouble(row[8]) * 1, DateTime.Now, row[6], row[4], row[7], row[5]);
                }

                cr = dgvItems.Rows.Count - 1; // آخر صف
                dgvItems.Rows[cr].Selected = true;
                dgvItems.FirstDisplayedScrollingRowIndex = cr;
                displayData();
                total(); // حساب إجمالي الفاتورة

                txtItemNum.SelectAll();
                txtItemNum.Focus();
            }
        }
        private void cmbItemName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            
            if (cmbItemName.SelectedValue == null)
            {
                MessageBox.Show("اسم الصنف عير موجود", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearItem();
                txtItemNum.Clear();
                return;
            }

            DataRow[] itemRows = ds.Tables[0].Select("Id=" + cmbItemName.SelectedValue);
            if (itemRows.Length > 0)
            {
                txtItemNum.Text = itemRows[0][1].ToString();
                txtItemNum.Focus();


                
                SendKeys.SendWait("{ENTER}");
                return;
            }
        }
        private void cmbItemName_TextChanged(object sender, EventArgs e)
        {
            if (cmbItemName.Text.Trim() == string.Empty)
            {
                clearItem();
                txtItemNum.Clear();
            }
        }
        private void cmbItemName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                cmbItemName_SelectionChangeCommitted(sender, e);
        }
        private void dgvItems_Click(object sender, EventArgs e)
        {

            if (FunctionsClass.checkDgvError(dgvItems))
                return;

            cr = dgvItems.CurrentRow.Index;
            displayData();
            txtInvoiceQuantity.Focus();
            txtInvoiceQuantity.SelectAll();
        }
        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.isPositiveRealNum((TextBox)sender, e);
        }
        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            if (txtTotal.Text == string.Empty)
                txtNet.Clear();
        }
        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            discount();
            txtdiscount.SelectAll();
            txtdiscount.Focus();
        }
        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            discount();
        }
        private void txtItemNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.isPositiveIntNum(e); // txtInvoiceQuantity
        }
        private void txtNet_TextChanged(object sender, EventArgs e)
        {
            if (txtNet.Text == string.Empty)
            {
                lblNet.Text = string.Empty;
                return;
            }

            double num;
            double.TryParse(txtNet.Text, out num);

            lblNet.Text = NumbersClass.NoToTxt(num, "دينار", "درهم", true).ToString();
        }
        private void txtInvoNum_TextChanged(object sender, EventArgs e)
        {
            if (txtInvoNum.Text.Trim() == "")
                lblBarcode.Text = "";
            else
                lblBarcode.Text = string.Format(txtInvoNum.Text, "*000000*");
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FunctionsClass.clear(grpItem);
            txtItemNum.Clear(); // txtItemNum.Tag = 1;
            FunctionsClass.clear(grpInvoice);
            FunctionsClass.clear(grpQuantity);
            chkDiscount.Checked = false;
            dgvItems.Rows.Clear();
            cr = -1;
            txtItemNum.Focus();
            dtpDate.Value = DateTime.Now; //timer1
            dsItem.Clear();
            getFillData();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtInvoNum.Text != string.Empty)
            {
                FunctionsClass.msgTool("تم حفظ الفاتورة مسبقاً", 2);
                return;
            }

            if (dgvItems.Rows.Count == 0)
            {
                FunctionsClass.msgTool("لا يمكن حفظ فاتورة فارغة", 2);
                return;
            }

            if (cmbCustomerName.Text == string.Empty)
            {
                MessageBox.Show("الرجاء اختيار اسم العميل", "خطأ إدخال", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbCustomerName.Focus();
                return;
            }
            
            if (cmbCustomerName.SelectedIndex == -1 & cmbCustomerName.Text != string.Empty)
            {
                if (MessageBox.Show("اسم العميل غير محفوظ هل تريد حفظه في المنظومة ؟", "ادخال بيانات", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //btnSaveCustomer_Click(sender, e);
                    return;
                }

                else
                    return;
            }

            var dt = new DataTable();
            dt.Columns.AddRange(new DataColumn[4] {
                new DataColumn("itemId", typeof(int)),
                new DataColumn("ItemQuantity", typeof(int)),
                new DataColumn("ItemPrice", typeof(double)),
                new DataColumn("Expirment",typeof(DateTime))
            });


            foreach (DataGridViewRow row in dgvItems.Rows)
                dt.Rows.Add(row.Cells[0].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[7].Value);

            DateTime dateAndTime = Convert.ToDateTime(dtpDate.Value.Date + dtpTime.Value.TimeOfDay);

            SQLConClass sqlCon = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {
                new SqlParameter("@InvoDate", dateAndTime),
                new SqlParameter("@InvoDiscount", Convert.ToDouble(txtTotal.Text) - Convert.ToDouble(txtNet.Text)),
                new SqlParameter("@ResourceId", cmbCustomerName.SelectedValue),
                new SqlParameter("@UserId", VariablesClass.userId),
                new SqlParameter("@ChkBuy",chkBuy.Checked),
                new SqlParameter("@Content", dt) };
            dsStore = sqlCon.cmdExecuteData("InsertBuyInvoice", param);

            switch (VariablesClass.Save)
            {
                case 1:
                    {
                        txtInvoNum.Text = Convert.ToInt64(dsStore.Tables[0].Rows[0][0]).ToString("000000");
                        break;
                    }

            }
        }
        private void btnUpdateQuantity_Click(object sender, EventArgs e)
        {
            int invoiceQuantity;
            int.TryParse(txtInvoiceQuantity.Text, out invoiceQuantity);
            if (cr != -1 & invoiceQuantity > 0)
            {
                dgvItems.Rows[cr].Cells[4].Value = Convert.ToInt32(txtInvoiceQuantity.Text);
                setNewQuantity();
                
                selectAll(txtInvoiceQuantity);
            }

        }
        private void btnAddQuantity_Click(object sender, EventArgs e)
        {
            int invoiceQuantity;
            int.TryParse(txtInvoiceQuantity.Text, out invoiceQuantity);
            if (cr != -1 & invoiceQuantity > 0)
            {
                dgvItems.Rows[cr].Cells[4].Value = Convert.ToDouble(dgvItems.Rows[cr].Cells[4].Value) + Convert.ToDouble(txtInvoiceQuantity.Text);
                txtInvoiceQuantity.Text = dgvItems.Rows[cr].Cells[4].Value.ToString();
                setNewQuantity();
                
                selectAll(txtInvoiceQuantity);
            }
        }
        private void btnSubtractQuantity_Click(object sender, EventArgs e)
        {
            int invoiceQuantity;
            int.TryParse(txtInvoiceQuantity.Text, out invoiceQuantity);
            if (cr != -1 & invoiceQuantity > 0)
            {
              
                if (Convert.ToInt32(txtInvoiceQuantity.Text) >= Convert.ToInt32(dgvItems.Rows[cr].Cells[4].Value))
                {
                    dgvItems.Rows.Remove(dgvItems.Rows[cr]);
                    FunctionsClass.clear(grpItem);
                    FunctionsClass.clear(grpQuantity);
                    cr = -1;
                    sequence();
                }
                else
                {
                    dgvItems.Rows[cr].Cells[4].Value = Convert.ToInt32(dgvItems.Rows[cr].Cells[4].Value) - Convert.ToInt32(txtInvoiceQuantity.Text);
                    txtInvoiceQuantity.Text = dgvItems.Rows[cr].Cells[4].Value.ToString();

                    setNewQuantity();
                    selectAll(txtInvoiceQuantity);
                }
                total();
            }

        }
        //-------------------------TouchScreen--------------------------------------
        Control focusedControl;
        private void txtItemNum_Enter(object sender, EventArgs e)
        {
            focusedControl = (Control)sender;
        }
        private void txtItemNum_Click(object sender, EventArgs e)
        {
            selectAll((TextBox)sender);
        }
        void selectAll(TextBox sender)
        {
            sender.Focus();
            sender.SelectAll();
            selectAllText = true;
        }
        private void b1_Click(object sender, EventArgs e)
        {
            TouchScreenButton(((Button)sender).Text);
        }
        void TouchScreenButton(string number)
        {
            if (focusedControl != null)
            {
                if (selectAllText == true)
                {
                    focusedControl.Text = number;
                    selectAllText = false;
                }
                else
                    focusedControl.Text += number;
            }
        }
        private void bC_Click(object sender, EventArgs e)
        {
            if (focusedControl != null)
                if (selectAllText == true)
                    focusedControl.Text = "";
                else if (focusedControl.Text.Length > 0)
                    focusedControl.Text = focusedControl.Text.Substring(0, focusedControl.Text.Length - 1);
        }
        private void bEnter_Click(object sender, EventArgs e)
        {
            if (focusedControl != null)
                if (focusedControl.Name == "txtItemNum")
                {
                    focusedControl.Focus();
                    SendKeys.Send("{ENTER}");
                }
        }

        private void FrmBuyInvoice_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible == true)
            {
                getFillData();
            }
            else
            {
                btnNew_Click( sender,  e);
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            FrmBuyReceipt frmBuyReceipt = new FrmBuyReceipt();
            frmBuyReceipt.ShowDialog();
        }


        //--------------------------------------------------------------------
    }
}
