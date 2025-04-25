using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class MatrixGenerator
    {
        protected int[,] baseMatrix;

        public int[,] GetBaseMatrix()
        {
            return baseMatrix;
        }
        public int[,] CreateDisplayMatrix(int rows, int cols)
        {
            baseMatrix = new int[rows+2, cols+2];
            return baseMatrix;
        }

        protected List<Cell> cells = new List<Cell>();

        public List<Cell> SetMatrixCell(int rows, int cols)
        {
            int k = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Point cellPos = new Point(i,j);
                    Cell cell = new Cell(cellPos, GameMatrix.listPictureBox[k]);
                    k++;
                    cells.Add(cell);
                }
            }
            return cells;
        }

        public List<Cell> GetCells() 
        {
            return cells;
        }
        
    }
}
