using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Pikachu_team21
{
    public partial class frmSetting : Form
    {
        private GameMatrix gameMatrix;
        public static frmSetting Instance { get; private set; }
        public int Value { get; internal set; }

        public int temp { get; internal set; }

        public frmSetting()
        {
            InitializeComponent();
            gameMatrix = new GameMatrix();
            Instance = this;
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.temp = 0;
            Close();
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.temp = 1;
            MessageBox.Show("Uki bạn nha! Apply liền nè!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void frmSetting_Load(object sender, EventArgs e)
        {

        }

        private void updLevel_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void updMusic_SelectedItemChanged(object sender, EventArgs e)
        {
            if (updMusic.SelectedItem.ToString() == "Theme01") 
            {

            }
            if (updMusic.SelectedItem.ToString() == "Theme02")
            {

            }
            if (updMusic.SelectedItem.ToString() == "Theme03")
            {

            }
            if (updMusic.SelectedItem.ToString() == "Theme04")
            {

            }
            if (updMusic.SelectedItem.ToString() == "Theme05")
            {

            }
        }

        private void updVolume_SelectedItemChanged(object sender, EventArgs e)
        {
            if (updVolume.SelectedItem.ToString() == "Siêu nhỏ")
            {

            }
            if (updVolume.SelectedItem.ToString() == "Đủ nghe")
            {

            }
            if (updVolume.SelectedItem.ToString() == "Đau tai")
            {

            }
            if (updVolume.SelectedItem.ToString() == "Cháy loa")
            {

            }

        }

        private void updTime_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void updPokemon_SelectedItemChanged(object sender, EventArgs e)
        {
            Value = gameMatrix.ChangeSoPokemon(int.Parse(updPokemon.SelectedItem.ToString()));
        }
    }
}
