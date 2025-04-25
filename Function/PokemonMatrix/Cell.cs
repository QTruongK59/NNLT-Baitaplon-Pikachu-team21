using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Cell
    {
        private Point location;
        private PictureBox pictureBox;
        private bool isSelected;
        private bool isFocus;

        Cell() { }
        public Cell(Point location, PictureBox pictureBox)
        {
            this.location = location;
            this.pictureBox = pictureBox;
        }

        public Point GetLocation()
        {
            return location;
        }

        public void SetLocation(int x, int y)
        {
            this.location.X = x;
            this.location.Y = y;
        }
        public void IsSelected(bool isSelected) { this.isSelected = isSelected;}
        public void IsFocus(bool isFocus) { this.isFocus = isFocus; }
    }
}
