using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class GameMatrix
    {
        public const int MAX_POKEMON = 46;
        public static int soPokemon = 36;
        public static List<PictureBox> listPictureBox = new List<PictureBox>();
        public static List<Bitmap> images = LoadImages();

        public static Bitmap ConvertToBitmap(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms);
            }
        }

        public int ChangeSoPokemon(int k)
        {
            frmMain mainForm = new frmMain();
            if (k > 0 && k < MAX_POKEMON)
            {
                soPokemon = k;
            }
            else
            {
                soPokemon = 36;
                MessageBox.Show("Số Pokemon không hợp lệ. Số Pokemon sẽ được đặt về mặc định là 36");
            }
            return soPokemon;
        }

        private static List<Bitmap> LoadImages()
        {
            List<Bitmap> image = new List<Bitmap>();
            for (int i = 1; i <= MAX_POKEMON; i++)
            {
                string resourceName = $"pic{i}";
                var resource = Properties.Resources.ResourceManager.GetObject(resourceName);
                if (resource is byte[] byteArray)
                {
                    image.Add(ConvertToBitmap(byteArray));
                }
            }
            return image;
        }

        public static void Display(Panel panel, int[,] displayMatrix)
        {
            Random random = new Random();
            Size size = new Size(35, 35);
            int rows = displayMatrix.GetLength(0);
            int cols = displayMatrix.GetLength(1);

            panel.Controls.Clear();
            GameMatrix.listPictureBox.Clear();

            int[] imageUsageCount = new int[GameMatrix.soPokemon];
            int totalCells = rows * cols;

            for (int row = 1; row < rows - 1; row++)
            {
                for (int col = 1; col < cols - 1; col++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        Size = size,
                        Location = new Point(col * size.Width, row * size.Height),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.LemonChiffon,
                        Visible = true,
                        Tag = new Point(col, row)
                    };

                    int randomIndex;
                    do
                    {
                        randomIndex = random.Next(GameMatrix.soPokemon);
                    } while (imageUsageCount[randomIndex] >= totalCells / GameMatrix.soPokemon);
                    imageUsageCount[randomIndex]++;
                    pictureBox.Image = GameMatrix.images[randomIndex];
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    pictureBox.Click += (sender, e) => Event.PictureBox_Click(sender, e);
                    pictureBox.MouseEnter += (sender, e) => Event.PictureBox_MouseEnter(sender, e);
                    pictureBox.MouseLeave += (sender, e) => Event.PictureBox_MouseLeave(sender, e);

                    panel.Controls.Add(pictureBox);
                    GameMatrix.listPictureBox.Add(pictureBox);
                }
            }
        }

        public static void Shuffle(Panel panel)
        {
            
            if (listPictureBox.Count == 0) return;
            panel.Controls.Clear();

            Random random = new Random();
            int count = listPictureBox.Count;
            for (int i = 0; i < count; i++)
            {
                int j = random.Next(count);
                PictureBox temp = listPictureBox[i];
                listPictureBox[i] = listPictureBox[j];
                listPictureBox[j] = temp;
            }
            for (int i = 0; i < count; i++)
            {
                panel.Controls.Add(listPictureBox[i]);
            }
        }
    }
}
