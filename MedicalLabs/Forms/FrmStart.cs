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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }
        int number;
        private void FrmStart_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            number++;
            if (number == 3)
            {
                this.Hide();
                FrmMain frmMain = new FrmMain();
                frmMain.ShowDialog();
            }
        }
    }
}
