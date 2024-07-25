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
    public partial class FrmAnalysis : Form
    {
        public FrmAnalysis()

        {
            InitializeComponent();
        }

        DataSet dsAnalysis = new DataSet();
        DataSet dsId = new DataSet();
        DataTable dtGroup = new DataTable();
        DataTable dtAnalysis = new DataTable();
        int cr = -1, analysisId, subAnalysisId, groupId;
        ResizeControls r = new ResizeControls();

        //****************************FUNCTION***********************************************
        public void getFillData()
        {
            SQLConClass sql = new SQLConClass();
            SQLConClass.sqlQuery = "SELECT TblAnalysis.Id , ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت ,AnalysisName,Price FROM TblAnalysis WHERE  TblAnalysis.Del=0 ";
            SQLConClass.sqlQuery += "SELECT TblSubAnalysis.Id AS Id1,ROW_NUMBER() OVER (ORDER BY (SELECT 1)) ت1,AnalysisName AS AnalysisName1,TblAnalysis.Id AS Num1 ,SubAnalysisName,Unit,[Range],TblUnit.Id AS UnitId FROM TblSubAnalysis,TblAnalysis,TblUnit WHERE TblAnalysis.Id=TblSubAnalysis.AnalysisId AND TblSubAnalysis.UnitId=TblUnit.Id ";
            SQLConClass.sqlQuery += "SELECT Id,AnalysisName FROM TblAnalysis WHERE Del=0 ORDER BY AnalysisName ";
            SQLConClass.sqlQuery += "SELECT * FROM TblUnit WHERE [Type]=1 ORDER BY Unit ";
            SQLConClass.sqlQuery += "SELECT * FROM TblGroup ORDER BY GroupName ";
            SQLConClass.sqlQuery += "SELECT TblGroupAnalysis.Id ,GroupName,TblGroup.Id AS GroupId,AnalysisName,TblAnalysis.Id AS AnalysisId  FROM TblGroupAnalysis,TblAnalysis,TblGroup WHERE TblAnalysis.Id=TblGroupAnalysis.AnalysisId AND TblGroup.Id=TblGroupAnalysis.GroupId ";
            dsAnalysis = sql.selectData(SQLConClass.sqlQuery, 0, null);

            if (FunctionsClass.dsHasTables(dsAnalysis))
            {
                dgvAnalysis.DataSource = dsAnalysis.Tables[0];
                dgvSubAnalysis.DataSource = dsAnalysis.Tables[1];
                dgvAnalysis.ClearSelection();
                dgvSubAnalysis.ClearSelection();
                fillCmb();
            }

        }
        public void fillCmb()
        {
            cmbAnalysisA.DataSource = dsAnalysis.Tables[2];
            cmbAnalysisA.ValueMember = "Id";
            cmbAnalysisA.DisplayMember = "AnalysisName";
            cmbAnalysisA.SelectedValue = -1;
            //**************************************************
            dtAnalysis = dsAnalysis.Tables[2].Copy();
            cmbAnalysis.DataSource = dtAnalysis;
            cmbAnalysis.ValueMember = "Id";
            cmbAnalysis.DisplayMember = "AnalysisName";
            cmbAnalysis.SelectedValue = -1;
            //**************************************************
            cmbUnit.DataSource = dsAnalysis.Tables[3];
            cmbUnit.ValueMember = "Id";
            cmbUnit.DisplayMember = "Unit";
            cmbUnit.SelectedValue = -1;
            //**************************************************

            cmbAnalysis2.DataSource = dsAnalysis.Tables[2];
            cmbAnalysis2.ValueMember = "Id";
            cmbAnalysis2.DisplayMember = "AnalysisName";
            cmbAnalysis2.SelectedValue = -1;
            //**************************************************
            cmbGroup.DataSource = dsAnalysis.Tables[4];
            cmbGroup.ValueMember = "Id";
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.SelectedValue = -1;
            //**************************************************
            dtGroup = dsAnalysis.Tables[4].Copy();
            lstGroup.DataSource = dtGroup;
            lstGroup.ValueMember = "Id";
            lstGroup.DisplayMember = "GroupName";
            lstGroup.SelectedValue = -1;
            lstGroup.ClearSelected();
        }
        public void displayDataAnaylsis()
        {
            analysisId = (int)dgvAnalysis.Rows[cr].Cells[0].Value;
            cmbAnalysisA.Text = dgvAnalysis.Rows[cr].Cells[2].Value.ToString();
            txtPrice.Text = dgvAnalysis.Rows[cr].Cells[3].Value.ToString();

        }
        public void saveAnalysis()
        {
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", analysisId),
                                                        new SqlParameter("AnalysisName", cmbAnalysisA.Text.Trim()),
                                                        new SqlParameter("Price", txtPrice.Text.Trim()) };

            dsId = sql.cmdExecuteData("SaveAnalysis", param);
            if (FunctionsClass.dsHasTables(dsId))
            {
                getFillData();

            }


        }
        public void clear()
        {
            FunctionsClass.clear(grbAnalysis);
            cr = -1;
            analysisId = 0;
            dgvAnalysis.ClearSelection();
        }
        //----------------------------------------------------------------------------------
        public void displayDataSub()
        {
            subAnalysisId = (int)dgvSubAnalysis.Rows[cr].Cells[0].Value;
            txtSubAnName.Text = dgvSubAnalysis.Rows[cr].Cells[4].Value.ToString();
            txtRange.Text = dgvSubAnalysis.Rows[cr].Cells[6].Value.ToString();
            cmbAnalysis.SelectedValue = dgvSubAnalysis.Rows[cr].Cells[3].Value;
            cmbUnit.SelectedValue = dgvSubAnalysis.Rows[cr].Cells[7].Value;

        }
        public void saveSub()
        {
            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@Id",subAnalysisId),
                                                       new SqlParameter("@SubAnalysisName",txtSubAnName.Text.Trim()),
                                                       new SqlParameter("@AnalysisId",cmbAnalysis.SelectedValue) ,
                                                       new SqlParameter("@Range",txtRange.Text),
                                                       new SqlParameter("@UnitId",cmbUnit.SelectedValue)};
            dsId = sql.cmdExecuteData("SaveSubAnalysis", param);
            if (FunctionsClass.dsHasTables(dsId))
            {
                getFillData();

            }



        }
        public void clearSub()
        {
            FunctionsClass.clear(grbSubAnalysis);
            cr = -1;
            subAnalysisId = 0;
            dgvSubAnalysis.ClearSelection();
            getFillData();
        }

        //***********************************************************************************
        private void FrmAnalysis_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                getFillData();

            }
            else
            {
                dsAnalysis.Clear();
                clear();
                clearSub();
            }
        }
        //------------------------------FrmAnalysis-------------------------------------------
        private void cmbAnalysisA_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbAnalysisA.SelectedValue == null)
            {
                return;
            }

            DataRow[] row = dsAnalysis.Tables[0].Select("Id=" + cmbAnalysisA.SelectedValue);
            if (row.Length > 0)
            {
                cr = Convert.ToInt32(row[0][0]) - 1;
                dgvAnalysis.Rows[cr].Selected = true;
                dgvAnalysis.FirstDisplayedScrollingRowIndex = cr;
                txtPrice.Text = row[0][3].ToString();
            }
        }
        
        private void cmbAnalysisA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbAnalysisA_SelectionChangeCommitted(sender, e);
                txtPrice.Focus();
            }
        }
        private void FrmAnalysis_Resize(object sender, EventArgs e)
        {
            r.ResizeControl();
        }
        private void FrmAnalysis_HandleCreated(object sender, EventArgs e)
        {
            r.Container = this;

        }
        private void FrmAnalysis_Load(object sender, EventArgs e)
        {
            getFillData();
            cmbAnalysisA.Focus();
            cmbAnalysisA.Select();
        }
        private void picSave_Click(object sender, EventArgs e)
        {
            if (cmbAnalysisA.Text == String.Empty || txtPrice.Text == String.Empty)
            {
                MessageBox.Show("الرجاء إدخال كافة بيانات التحليل", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveAnalysis();
            clear();
        }
        private void picSave_MouseEnter(object sender, EventArgs e)
        {
            picSave.SetBounds(picSave.Left - 10, picSave.Top - 10, picSave.Width + 20, picSave.Height + 20);
        }
        private void picSave_MouseLeave(object sender, EventArgs e)
        {
            picSave.SetBounds(picSave.Left + 10, picSave.Top + 10, picSave.Width - 20, picSave.Height - 20);

        }
        private void picDelete_MouseEnter(object sender, EventArgs e)
        {
            picDelete.SetBounds(picDelete.Left - 10, picDelete.Top - 10, picDelete.Width + 20, picDelete.Height + 20);
        }
        private void picNew_MouseEnter(object sender, EventArgs e)
        {
            picNew.SetBounds(picNew.Left - 10, picNew.Top - 10, picNew.Width + 20, picNew.Height + 20);
        }
        private void picNew_MouseLeave(object sender, EventArgs e)
        {
            picNew.SetBounds(picNew.Left + 10, picNew.Top + 10, picNew.Width - 20, picNew.Height - 20);
        }
        private void picDelete_MouseLeave(object sender, EventArgs e)
        {
            picDelete.SetBounds(picDelete.Left + 10, picDelete.Top + 10, picDelete.Width - 20, picDelete.Height - 20);
        }
        private void picDelete_Click(object sender, EventArgs e)
        {
            if (analysisId == 0)
            {
                MessageBox.Show("رجاء تحديد تحليل مراد حذفه", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد تريد حذف هذا التحليل", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", analysisId) };
                SQLConClass sql = new SQLConClass();
                sql.cmdExecute("DeleteAnalysis", 1, param);
                getFillData();
                clear();
            }

        }
        private void picNew_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void dgvAnalysis_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;
            cr = dgvAnalysis.CurrentRow.Index;
            displayDataAnaylsis();
        }

        //-------------------------------------------------------------------------------------


        //--------------------------------FrmSubAnalysis---------------------------------------
        private void cmbAnalysis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //if (cmbAnalysis.SelectedValue == null)
            //{
            //    return;
            //}
            //DataRow[] row = dsAnalysis.Tables[1].Select("Id1=" + cmbAnalysis.SelectedValue);
            //if (row.Length > 0)
            //{
            //    txtSubAnName.Text = row[0][4].ToString();
            //    cmbUnit.Text = row[0][5].ToString();
            //    txtRange.Text = row[0][6].ToString();
            //}
        }
        private void picSaveSub_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grbSubAnalysis))
            {
                MessageBox.Show("الرجاء إدخال كافة بيانات التحليل", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveSub();
            clearSub();
        }
        private void picDeleteSub_Click(object sender, EventArgs e)
        {
            if (subAnalysisId == 0)
            {
                MessageBox.Show("رجاء تحديد تحليل مراد حذفه", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد تريد حذف هذا التحليل", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sql = new SQLConClass();
                SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", subAnalysisId) };
                sql.cmdExecute("DeleteSubAnalysis", 1, param);
                clearSub();
            }

        }
        private void picNewSub_Click(object sender, EventArgs e)
        {
            clearSub();
        }
        private void dgvSubAnalysis_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkDgvError((DataGridView)sender))
                return;
            cr = dgvSubAnalysis.CurrentRow.Index;
            displayDataSub();
        }
        private void chkAnalysis_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbAnalysis.SelectedValue != null)
            {
                if (chkAnalysis.Checked == true)
                {
                    txtSubAnName.Text = cmbAnalysis.Text;
                    cmbUnit.Focus();
                }
                if (chkAnalysis.Checked == false)
                {
                    txtSubAnName.Text = null;
                    txtSubAnName.Focus();
                }
            }

        }
        private void picSaveSub_MouseEnter(object sender, EventArgs e)
        {
            picSaveSub.SetBounds(picSaveSub.Left - 10, picSaveSub.Top - 10, picSaveSub.Width + 20, picSaveSub.Height + 20);
        }
        private void picSaveSub_MouseLeave(object sender, EventArgs e)
        {
            picSaveSub.SetBounds(picSaveSub.Left + 10, picSaveSub.Top + 10, picSaveSub.Width - 20, picSaveSub.Height - 20);
        }
        private void picDeleteSub_MouseEnter(object sender, EventArgs e)
        {
            picDeleteSub.SetBounds(picDeleteSub.Left - 10, picDeleteSub.Top - 10, picDeleteSub.Width + 20, picDeleteSub.Height + 20);

        }
        private void picDeleteSub_MouseLeave(object sender, EventArgs e)
        {
            picDeleteSub.SetBounds(picDeleteSub.Left + 10, picDeleteSub.Top + 10, picDeleteSub.Width - 20, picDeleteSub.Height - 20);

        }
        private void picNewSub_MouseEnter(object sender, EventArgs e)
        {
            picNewSub.SetBounds(picNewSub.Left - 10, picNewSub.Top - 10, picNewSub.Width + 20, picNewSub.Height + 20);

        }
        private void picNewSub_MouseLeave(object sender, EventArgs e)
        {
            picNewSub.SetBounds(picNewSub.Left + 10, picNewSub.Top + 10, picNewSub.Width - 20, picNewSub.Height - 20);

        }

        //--------------------------------------------------------------------------------------
        //---------------------------------FrmGroup-----------------------------------------------------
        private void lstGroup_Click(object sender, EventArgs e)
        {
            if (lstGroup.SelectedValue == null)
                return;


            lstAnalysis.DataSource = null;
            txtGroup.Text = lstGroup.Text;

            DataRow[] row = dsAnalysis.Tables[5].Select("GroupId=" + lstGroup.SelectedValue, "AnalysisName ASC");
            if (row.Length > 0)
            {

                lstAnalysis.DataSource = row.CopyToDataTable();
                lstAnalysis.ValueMember = "AnalysisId";
                lstAnalysis.DisplayMember = "AnalysisName";
            }
            lstAnalysis.ClearSelected();

        }
        private void lstAnalysis_Click(object sender, EventArgs e)
        {
            if (lstAnalysis.SelectedValue == null)
                return;
            groupId = (int)lstAnalysis.SelectedValue;
            cmbGroup.SelectedValue = lstGroup.SelectedValue;
            cmbAnalysis2.SelectedValue = lstAnalysis.SelectedValue;
        }
        private void btnUpdateGroup_Click(object sender, EventArgs e)
        {
            if (lstGroup.SelectedValue == null || txtGroup.Text == String.Empty)
                return;

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id",lstGroup.SelectedValue)
                                                       ,new SqlParameter("@Group", txtGroup.Text.Trim()) };

            SQLConClass.sqlQuery = "IF NOT EXISTS(SELECT * FROM TblGroup WHERE GroupName=@Group AND Id<>@Id)  UPDATE TblGroup SET GroupName=@Group WHERE Id=@Id";
            sql.cmdExecute(SQLConClass.sqlQuery, 0, param);
            getFillData();
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (txtGroup.Text == String.Empty)
                return;

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Group", txtGroup.Text.Trim()) };
            SQLConClass.sqlQuery = "IF NOT EXISTS(SELECT * FROM TblGroup WHERE GroupName=@Group)   INSERT INTO TblGroup(GroupName)VALUES(@Group)";
            sql.cmdExecute(SQLConClass.sqlQuery, 0, param);
            getFillData();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void btnSaveConGroup_Click(object sender, EventArgs e)
        {
            if (FunctionsClass.checkEmptyInput(grpGroup))
            {
                MessageBox.Show("رجاء تعبئة البيانات", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] {new SqlParameter("@Id",cmbAnalysis2.SelectedValue),
                                                       new SqlParameter("@GroupId",cmbGroup.SelectedValue)};

            sql.cmdExecute("SaveContentGroup", 1, param);
            btnNew_Click(sender, e);
            getFillData();


        }
        private void cmbAnalysisA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPrice.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGroup.Clear();
            lstGroup.ClearSelected();
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            FrmUnit frmUnit = Application.OpenForms.OfType<FrmUnit>().FirstOrDefault();
            if (frmUnit == null)
                frmUnit = new FrmUnit();
            frmUnit.ShowDialog();
            getUnits();
        }
        void getUnits()
        {
            SQLConClass.sqlQuery = "SELECT * FROM TblUnit WHERE Type=1 ORDER BY Unit ";
            SQLConClass sqlCon = new SQLConClass();
            DataSet DSUnit = new DataSet();
            DSUnit = sqlCon.selectData(SQLConClass.sqlQuery, 0, null);
            if (FunctionsClass.dsHasTables(DSUnit))
            {
                cmbUnit.DataSource = DSUnit.Tables[0];
                cmbUnit.DisplayMember = "Unit";
                cmbUnit.ValueMember = "Id";
                cmbUnit.SelectedIndex = -1;
            }
        }



        private void btnDelConGroup_Click(object sender, EventArgs e)
        {
            if (groupId == 0)
            {
                MessageBox.Show("الرجاء إختيار البيانات التي تريد حذفها", "ادخال بيانات", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (MessageBox.Show("هل أنت متأكد تريد حذف هذا التحليل", "تأكيد حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SQLConClass sql = new SQLConClass();
                SqlParameter[] param = new SqlParameter[] {new SqlParameter("@Id",cmbAnalysis2.SelectedValue),
                                                       new SqlParameter("@GroupId",cmbGroup.SelectedValue)};

                sql.cmdExecute("DeleteGroupContent", 1, param);
                btnNew_Click(sender, e);
                getFillData();
            }

        }
        private void btnDelGroup_Click(object sender, EventArgs e)
        {
            if (lstGroup.SelectedValue == null)
                return;

            SQLConClass sql = new SQLConClass();
            SqlParameter[] param = new SqlParameter[] { new SqlParameter("@Id", lstGroup.SelectedValue) };

            sql.cmdExecute("DeleteGroup", 1, param);
            getFillData();

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            FunctionsClass.clear(grpGroup);
            lstGroup.ClearSelected();
            lstAnalysis.DataSource = null;
            groupId = 0;
            txtGroup.Clear();
        }
        //--------------------------------------------------------------------------------------
    }
}
