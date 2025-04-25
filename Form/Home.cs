using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    public partial class frmHome: Form
    {
        public frmHome()
        {
            InitializeComponent();
        }
        public void UpdateLabel(string text)
        {
            if (text == "") text = "NONAME";
            lblWelcome.Text = "CHIẾN THÔI\n" + text + " CUTE ƠI!!!";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmLevel01 lvform = new frmLevel01();
            lvform.Show();
            this.Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmOutSave outSave = new frmOutSave();
            outSave.Show();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            frmGuide frmGuide = new frmGuide();
            frmGuide.Show();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            frmTop frmTop = new frmTop();
            frmTop.Show();
        }
    }
}
