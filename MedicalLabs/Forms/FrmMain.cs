using MedicalLabs.Classes;
using MedicalLabs.Forms;
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

namespace MedicalLabs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        bool down;
        Point position;
        int conMonitorCount = 0;
        //*********************************FUNCTIUON************************************************
        private void hideOpenForms()
        {
            foreach (Button b in pnlMenu.Controls)
            {
                if (b.BackColor != Color.FromArgb(13, 18, 130))
                {
                    b.BackColor = Color.FromArgb(13, 18, 130);
                    b.Font = new Font("Hacen Saudi Arabia", 10, FontStyle.Regular);
                    b.FlatAppearance.BorderSize = 0;
                    b.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;

                }
            }


            foreach (Form f in Application.OpenForms)
            {

                if (f.Name != "FrmMain")
                {
                    f.Visible = false;
                    FunctionsClass.userTrafficRegister(f.Name, false);
                }
            }

        }
        private void OpenForm(Form f, Button b)
        {
            if (f.Visible == true) // إختبار إذا كان الفورم مفتوح
            {
                hideOpenForms();
                VariablesClass.mainActive = true;  // جزء خاص بمراقبة حركة المستحدمين
            }
            else
            {
                hideOpenForms();
                f.TopLevel = false;
                f.Parent = pnlMain;
                f.BringToFront();
                f.Visible = true;
                f.Size = pnlMain.Size;
                f.Dock = DockStyle.Fill;
                FunctionsClass.userTrafficRegister(f.Name, true); // جزء خاص بمراقبة حركة المستحدمين
                FunctionsClass.setPermissions(); // جزء خاص بتخصيص الصلاحيات
                b.BackColor = Color.FromArgb(28, 130, 173);
                b.Font = new Font("Hacen Saudi Arabia", 12, FontStyle.Bold);
                b.FlatAppearance.BorderSize = 1;
                b.FlatAppearance.BorderColor = Color.White;
                b.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            }


        }
        void setFormSize()
        {
            if (Settings.Default.FrmMainWindowState == (int)FormWindowState.Maximized)
                this.WindowState = FormWindowState.Maximized;
            else
            {
                this.Size = Settings.Default.FrmMainSize;
                this.Location = Settings.Default.FrmMainLocation;
            }
        }
        void saveFormSize()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                Settings.Default.FrmMainSize = this.Size;
                Settings.Default.FrmMainLocation = this.Location;
            }

            Settings.Default.FrmMainWindowState = (int)this.WindowState;
            Settings.Default.Save();
        }
        //*******************************************************************************************
        private void FrmMain_Load(object sender, EventArgs e)
        {
            setFormSize();
            tslDateTime.Text = DateTime.Now.ToString();
            tslUser.Text = VariablesClass.userName + " - " +VariablesClass.userJob;
            
        }
        private void FrmMain_Shown(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            tslUser.Text = VariablesClass.userName + " - " + VariablesClass.userJob;
        }
        private void btnInvoice_Click(object sender, EventArgs e)
        {
            FrmInvoice frmInvoice = Application.OpenForms.OfType<FrmInvoice>().FirstOrDefault();
            if (frmInvoice == null)
                frmInvoice = new FrmInvoice();
            OpenForm(frmInvoice, btnInvoice);
        }
        private void btnResult_Click(object sender, EventArgs e)
        {
            FrmResult frmResult = Application.OpenForms.OfType<FrmResult>().FirstOrDefault();
            if (frmResult == null)
                frmResult = new FrmResult();
            OpenForm(frmResult,btnResult);
        }
        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            FrmAnalysis frmAnalysis = Application.OpenForms.OfType<FrmAnalysis>().FirstOrDefault();
            if (frmAnalysis == null)
                frmAnalysis = new FrmAnalysis();
            OpenForm(frmAnalysis, btnAnalysis);
        }
        private void btnPaient_Click(object sender, EventArgs e)
        {
            FrmPatient frmPatient = Application.OpenForms.OfType<FrmPatient>().FirstOrDefault();
            if (frmPatient == null)
                frmPatient = new FrmPatient();
            OpenForm(frmPatient, btnPaient);

        }
        private void btnTechnical_Click(object sender, EventArgs e)
        {
            FrmTechnical frmTechnical = Application.OpenForms.OfType<FrmTechnical>().FirstOrDefault();
            if (frmTechnical == null)
                frmTechnical = new FrmTechnical();
            OpenForm(frmTechnical, btnTechnical);
        }
        private void btnStore_Click(object sender, EventArgs e)
        {
            FrmStore frmStore = Application.OpenForms.OfType<FrmStore>().FirstOrDefault();
            if (frmStore == null)
                frmStore = new FrmStore();
            OpenForm(frmStore, btnStore);
        }
        private void btnBuyInvoice_Click(object sender, EventArgs e)
        {
             FrmBuyInvoice frmBuyInvoice = Application.OpenForms.OfType<FrmBuyInvoice>().FirstOrDefault();
            if (frmBuyInvoice == null)
                frmBuyInvoice = new FrmBuyInvoice();
            OpenForm(frmBuyInvoice, btnBuyInvoice);
        }
        private void btnItem_Click(object sender, EventArgs e)
        {
            FrmItem frmItem = Application.OpenForms.OfType<FrmItem>().FirstOrDefault();
            if (frmItem == null)
                frmItem = new FrmItem();
            OpenForm(frmItem, btnItem);
        }
        private void btnReports_Click(object sender, EventArgs e)
        {
            FrmInvoReports frmInvoReports = Application.OpenForms.OfType<FrmInvoReports>().FirstOrDefault();
            if (frmInvoReports == null)
                frmInvoReports = new FrmInvoReports();
            OpenForm(frmInvoReports, btnReports);
        }
        private void btnResource_Click(object sender, EventArgs e)
        {
            FrmCustomer frmCustomer = Application.OpenForms.OfType<FrmCustomer>().FirstOrDefault();
            if (frmCustomer == null)
                frmCustomer = new FrmCustomer();
            OpenForm(frmCustomer, btnResource);
        }
        private void btnChart_Click(object sender, EventArgs e)
        {
            FrmCharts frmCharts = Application.OpenForms.OfType<FrmCharts>().FirstOrDefault();
            if (frmCharts == null)
                frmCharts = new FrmCharts();
            OpenForm(frmCharts, btnChart);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMain frmMain = new FrmMain();
            frmMain.ShowDialog();   
        }
        private void tslSettings_Click(object sender, EventArgs e)
        {
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }
        private void tslUsers_Click(object sender, EventArgs e)
        {
            FrmUsers frmUsers = new FrmUsers();
            frmUsers.ShowDialog();
        }
        private void tslMonitor_Click(object sender, EventArgs e)
        {
            FrmMonitor frmMonitor =new FrmMonitor();
            frmMonitor.ShowDialog();
        }
        private void tslTreasury_Click(object sender, EventArgs e)
        {
            
        }
        private void tslEmployee_Click(object sender, EventArgs e)
        {
            FrmEmployee frmEmployee = new FrmEmployee();
            frmEmployee.ShowDialog();
        }
        private void tslInventory_Click(object sender, EventArgs e)
        {

        }
        private void tslDel_Click(object sender, EventArgs e)
        {
            FrmDelElements frmDelElements = new FrmDelElements();
            frmDelElements.ShowDialog();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            tslDateTime.Text = DateTime.Now.ToString();

            // -----------------------msgTool----------------------
            if (Convert.ToInt32(timer1.Tag) >= 1)
                timer1.Tag = (int)(timer1.Tag) + 1;

            if (Convert.ToInt32(timer1.Tag) == 5)
            {
                timer1.Tag = 0;
                tslMessage.Visible = false;
                statusStrip1.BackColor = Color.FromArgb(13, 18, 130);
            }

            // ---------------------FrmInvoice--------------------------------
            FrmInvoice frmInvoice = Application.OpenForms.OfType<FrmInvoice>().FirstOrDefault();
            if (frmInvoice != null)
            {
                frmInvoice.dtpDate.Value = DateTime.Now;
                frmInvoice.dtpTime.Value = DateTime.Now;
            }
            //-----------------------------------------------------
            // ------------------Is Main active ?-------------------------------
            if (VariablesClass.mainActive == true)
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f.Name != "FrmMain" & f.Visible == true)
                    {
                        FunctionsClass.userTrafficRegister(f.Name, true);
                        VariablesClass.mainActive = false;
                        return;
                    }
                }
                FunctionsClass.userTrafficRegister("FrmMain", true);
                VariablesClass.mainActive = false;
            }

            // -------------------User Connect & Network Monitor-----------------------------

            FrmLogin frmLogin = Application.OpenForms.OfType<FrmLogin>().FirstOrDefault();
            if (frmLogin == null) // Login بعد اغلاق 
            {
                conMonitorCount += 1;
                if (conMonitorCount == 15)
                {
                    UserConnectMonitor();
                    conMonitorCount = 0;
                }
            }
            // -----------------------------------------------

        }
        private void UserConnectMonitor()
        {
            if (VariablesClass.userId == 0)
                return;

            try
            {
                ConClass.cmd = new SqlCommand("UserConnectMonitor", ConClass.con);    // يقوم بتسجيل اخر توقيت لاتصال المستخدم بالشبكة هل مازال متصل أو لا وإذا لم يتصل خلال زمن معين يتم فصل الإتصال عنه
                ConClass.cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter param;
                param = new SqlParameter("@userId", VariablesClass.userId);
                ConClass.cmd.Parameters.Add(param);

                ConClass.cmd.Parameters.Add("@MsgCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                ConClass.cmd.Parameters.Add("@UserLockedOut", SqlDbType.Int).Direction = ParameterDirection.Output;

                ConClass.con.Open();
                ConClass.cmd.ExecuteNonQuery();
                ConClass.con.Close();


                int UserLockedOut = Convert.ToInt32(ConClass.cmd.Parameters["@UserLockedOut"].Value);
                if (UserLockedOut == 1)
                {
                    MessageBox.Show("تم ايقافك عن العمل على المنظومة من قبل المسؤول", "ايقاف", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    timer1.Enabled = false;
                    Environment.Exit(0);
                    //this.Close();
                }


                // عدد الرسائل الغير مقروءة والتنبيه لها
               // int MsgCount = Convert.ToInt32(ConClass.cmd.Parameters["@MsgCount"].Value);
                // FrmMessenger frmMessenger = Application.OpenForms.OfType<FrmMessenger>().FirstOrDefault();
               // int count;
             //   int.TryParse(lbLTotalMsgCount.Text, out count);

                //if (MsgCount != 0 & frmMessenger == null & MsgCount != count)
                //{

                //    System.Media.SoundPlayer player;
                //    player = new System.Media.SoundPlayer(Resources.ns);
                //    player.Play();
                //    //  player.PlayLooping();
                //    lbLTotalMsgCount.Text = MsgCount.ToString();
                //}
                //else if (MsgCount == 0)
                //    lbLTotalMsgCount.Text = "";
            }

            catch (Exception ex)
            {
                ConClass.con.Close();
                timer1.Enabled = false;
                MessageBox.Show("خطأ في تحديث بيانت اتصال المستخدم" + ex.Message, "خطأ إتصال بقواعد البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timer1.Enabled = true;

                // msgTool("خطأ في تحديث بيانت اتصال المستخدم", 0)
            }

        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("هل تريد إغلاق المنظومة", "تأكيد طلب إغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (Settings.Default.AutoBackup == true)
                    // backupDatabase();

                    saveFormSize();
            }

            else
                e.Cancel = true;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
