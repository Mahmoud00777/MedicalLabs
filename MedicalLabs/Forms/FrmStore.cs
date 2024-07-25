using MedicalLabs.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalLabs.Forms
{
    public partial class FrmStore : Form
    {
        public FrmStore()
        {
            InitializeComponent();
        }
        ResizeControls r = new ResizeControls();
        DataSet dsStore = new DataSet();
        DataTable dtStore = new DataTable();
        int cr = -1,pageSize, pageNum = 1, pagesCount, rowsCount;
        void getFillData()
        {
            txtPageNum.Text = pageNum.ToString();
            pageSize = Settings.Default.PageSize;

            SQLConClass sqlCon = new SQLConClass();
            SQLConClass.sqlQuery = "Select Id, ROW_NUMBER() OVER (ORDER BY (SELECT 1)) AS N ,CONVERT(NVARCHAR,[Num],100) AS Num, [Name]+' - '+Descripe AS Items,StoreQuantity,LowQuantity,Expirment FROM TblItem  WHERE Del=0 ";
            if (radLow.Checked == true)
                SQLConClass.sqlQuery += " and StoreQuantity<=LowQuantity and StoreQuantity<>0";
            else if (radEmpty.Checked == true)
                SQLConClass.sqlQuery += " and StoreQuantity=0";

            SQLConClass.sqlQuery += " ORDER BY [Name] OFFSET " + pageSize * (pageNum - 1) + " ROWS FETCH NEXT " + pageSize + " ROWS ONLY";

            SQLConClass.sqlQuery += " SELECT COUNT(Id) FROM TblItem WHERE Del=0";
            if (radLow.Checked == true)
                SQLConClass.sqlQuery += " and StoreQuantity<=LowQuantity and StoreQuantity<>0";
            else if (radEmpty.Checked == true)
                SQLConClass.sqlQuery += " and StoreQuantity=0";

            dsStore = sqlCon.selectData(SQLConClass.sqlQuery, 0, default);
            if (FunctionsClass.dsHasTables(dsStore))
            {
                dtStore = dsStore.Tables[0].Copy();
                dsStore.Tables[0].Clear();
                dgvStore.DataSource = dtStore;
                dgvStore.ClearSelection();
                rowsCount = (int)dsStore.Tables[1].Rows[0][0];
                clearData();
                getPagesCount();
            }
        }
        void clearData()
        {
            txtFilter.Text = "";
            txtFilter.Focus();
            dgvStore.ClearSelection();
            FunctionsClass.clear(grbStore);

            
        }
        void radChecked(RadioButton sender)
        {
            if (sender.Checked == true)
            {
                pageNum = 1;
                getFillData();
            }
        }
        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            radChecked((RadioButton)sender);

        }
        private void FrmStore_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmStore_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void FrmStore_Load(object sender, EventArgs e)
        {
            getFillData();
            dgvStore.ColumnHeadersDefaultCellStyle.Font = new Font("Hacen Saudi Arabia",10,FontStyle.Regular);
            dgvStore.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvStore.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(13, 18, 130);
        }
        private void dgvStore_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError(dgvStore) == true)
                return;

           
            txtNum.Text = dgvStore.Rows[dgvStore.CurrentRow.Index].Cells[2].Value.ToString();
            txtName.Text = dgvStore.Rows[dgvStore.CurrentRow.Index].Cells[3].Value.ToString();
            txtQuantity.Text = dgvStore.Rows[dgvStore.CurrentRow.Index].Cells[4].Value.ToString();
            txtLowQuantity.Text = dgvStore.Rows[dgvStore.CurrentRow.Index].Cells[5].Value.ToString();


        }
        private void dgvStore_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dtStore = FunctionsClass.columnHeaderMouseClick((DataGridView)sender, dtStore);
            clearData();
        }
        private void dgvStore_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (Convert.ToInt32(dgvStore.Rows[e.RowIndex].Cells[4].Value) == 0)
            {
                e.CellStyle.BackColor = Color.FromArgb(244, 61, 67);
                e.CellStyle.SelectionBackColor = Color.Red;
                e.CellStyle.SelectionForeColor = Color.Yellow;
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            }
            else if (Convert.ToInt32(dgvStore.Rows[e.RowIndex].Cells[4].Value) <= Convert.ToInt32(dgvStore.Rows[e.RowIndex].Cells[5].Value))
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 255, 192);
                e.CellStyle.SelectionBackColor = Color.Yellow;
                e.CellStyle.SelectionForeColor = Color.Red;
            }
        }
        private void lblSearch_Click(object sender, EventArgs e)
        {
            txtFilter.Focus();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Trim() == "")
                lblSearch.Visible = true;
            else
                lblSearch.Visible = false;

            dtStore.DefaultView.RowFilter = " Items Like '%" + txtFilter.Text.Trim() + "%' OR Num Like '%" + txtFilter.Text.Trim() + "%'";
            dgvStore.ClearSelection();
        }
        private void FrmStore_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                getFillData();
            }
            else
            {
                clearData();
            }
        }

        //********************************Pagenation*******************************
        void getPagesCount()
        {
            if (rowsCount % pageSize == 0 & rowsCount != 0)
                pagesCount = rowsCount / pageSize;
            else
                pagesCount = rowsCount / pageSize + 1;

            lblPagesCount.Text = pagesCount.ToString();
            txtPageNum.Text = pageNum.ToString();
        }
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            checkPageSize();

            if (pageNum > 1)
                pageNum -= 1;

            getFillData();
        }
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            checkPageSize();

            if (pageNum < pagesCount)
                pageNum += 1;

            getFillData();
        }
        private void btnFirstPage_Click(object sender, EventArgs e)
        {
            pageNum = 1;
            getFillData();
        }
        private void btnLastPage_Click(object sender, EventArgs e)
        {
            checkPageSize();

            pageNum = pagesCount;

            getFillData();
        }

        private void btnWithDrawl_Click(object sender, EventArgs e)
        {
            FrmWithDrawl frmWithDrawl = new FrmWithDrawl();
            frmWithDrawl.ShowDialog();
            getFillData();
        }

        private void btnLost_Click(object sender, EventArgs e)
        {
            FrmLostAndDamaged frmLostAndDamaged = new FrmLostAndDamaged();
            frmLostAndDamaged.ShowDialog();
            getFillData();
        }

        private void txtPageNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtPageNum.Text == string.Empty) return;

            if (e.KeyCode == Keys.Enter)
            {
                checkPageSize();

                if (Convert.ToInt32(txtPageNum.Text) > Convert.ToInt32(lblPagesCount.Text))
                    pageNum = Convert.ToInt32(lblPagesCount.Text);
                else if (Convert.ToInt32(txtPageNum.Text) <= 0)
                    pageNum = 1;
                else
                    pageNum = Convert.ToInt32(txtPageNum.Text);

                getFillData();
            }
        }
        void checkPageSize()
        {
            if (pageSize != Settings.Default.PageSize)
            {
                pageNum = 1;
                getFillData();
            }
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.PageSize = (int)numericUpDown1.Value;
            Settings.Default.Save();
        }
        private void txtPageNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !FunctionsClass.isPositiveIntNum(e);
        }
    }
}
