using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pikachu_team21
{
    class Neighbor
    {
        public MatrixGenerator generator;
        public Cell up;
        public Cell down;
        public Cell left;
        public Cell right;

        private List<Cell> neighbor;

        public void Find()
        {
            int x;
            int y;
            foreach (Cell cell in generator.GetCells())
            {
                x = this.location.X;
                y = this.location.Y;
                up = this.up.GetCell(x, y - 1);
                down = this.down.GetCell(x, y + 1);
                left = this.left.GetCell(x - 1, y);
                right = this.right.GetCell(x + 1, y);
            }
        }
        public void Get()
        {
            int x;
            int y;
            foreach (Cell cell in generator.GetCells())
            {
                if (Instance == null) continue;
                neighbor.Add(up);
                neighbor.Add(down);
                neighbor.Add(left);
                neighbor.Add(right);
            }
        }
    }
}
