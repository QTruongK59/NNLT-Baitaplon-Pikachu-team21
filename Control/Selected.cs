using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pikachu_team21
{
    class Selected
    {
        public PictureBox selection1;
        public PictureBox selection2;
       
        public Selected()
        {
            selection1 = null;
            selection2 = null;
        }

        public void UnSelected()
        {
            selection1 = null;
            selection2 = null;
        }
        public void ResetSelected()
        {
            if (selection1 != null)
            {
                selection1.BackColor = System.Drawing.Color.LemonChiffon;
                selection1.BorderStyle = BorderStyle.FixedSingle;
            }
            if (selection2 != null)
            {
                selection2.BackColor = System.Drawing.Color.LemonChiffon;
                selection2.BorderStyle = BorderStyle.FixedSingle;
            }
        }
        public void SetSelection(PictureBox pictureBox)
        {
            if (selection1 == null)
            {
                selection1 = pictureBox;
            }
            else if (selection2 == null)
            {
                selection2 = pictureBox;
            }



            if (selection1 != null && selection2 != null)
            {
                if (selection1.Image == selection2.Image)
                {
                    selection1.Visible = false;
                    selection2.Visible = false;
                    UnSelected();
                }
                else
                {
                    ResetSelected();
                    UnSelected();
                }
            }
        }
    }
}
