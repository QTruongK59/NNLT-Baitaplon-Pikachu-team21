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
    public partial class frmOutSave: Form
    {
        public frmOutSave()
        {
            InitializeComponent();
        }

        private void frmOutSave_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tau nhớ mi rùi nha!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmOut frmOut = new frmOut();
            frmOut.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lần sau chơi lại là phải chơi từ đầu đó!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmOut frmOut = new frmOut();
            frmOut.Show();
        }
    }
}
