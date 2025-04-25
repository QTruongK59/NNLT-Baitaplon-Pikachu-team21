using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Event
    {
        public static Selected selected = new Selected();
        public static EventHandler PictureBox_Click 
        {
            get
            {
                return (sender, e) =>
                {
                    if (sender is PictureBox pictureBox)
                    {
                        ChangeBorderColorStatic(sender, Color.Red);
                        selected.SetSelection(pictureBox);
                    }
                };
            }

        }

        public static EventHandler PictureBox_MouseEnter
        {
            get
            {
                return (sender, e) =>
                {
                    if (sender is PictureBox pictureBox)
                    {
                        ChangeBackgroundColorStatic(sender, Color.AliceBlue);
                    }
                };
            }
        }

        public static EventHandler PictureBox_MouseLeave
        {
            get
            {
                return (sender, e) =>
                {
                    if (sender is PictureBox pictureBox)
                    {
                        ChangeBackgroundColorStatic(sender, Color.LemonChiffon);
                    }
                };
            }
        }
        private static void ChangeBackgroundColorStatic(object sender, Color color)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = color;
            }
        }

        private static void ChangeBorderColorStatic(object sender, Color color)
        {
            if (sender is PictureBox pictureBox)
            {
                pictureBox.BackColor = color;
                pictureBox.BorderStyle = BorderStyle.Fixed3D;
            }
        } 
    };
}

