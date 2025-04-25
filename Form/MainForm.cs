using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pikachu_team21;

namespace Pikachu_team21
{
    public partial class frmMain : Form
    {
        private MatrixGenerator matrixGenerator;
        private Cell cell;

        public void Form_Load()
        {

            int[,] dataMatrix = matrixGenerator.CreateDisplayMatrix(9, 16);
            GameMatrix.Display(panel3, dataMatrix);
            List<Cell> cells = matrixGenerator.SetMatrixCell(dataMatrix.GetLength(0) - 2, dataMatrix.GetLength(1) - 2);
        }
        public Panel GetPanel()
        {
            return panel3;
        }
        public frmMain()
        {
            InitializeComponent();
            matrixGenerator = new MatrixGenerator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSetting setting = new frmSetting();
            setting.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            frmOutSave outSave = new frmOutSave();
            outSave.ShowDialog();
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form_Load();
        }

        private void btnRepeat_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Form_Load();
        }
    }
}
