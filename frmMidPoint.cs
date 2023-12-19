using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dilevered_project_Graphics
{
    public partial class frmMidPoint : Form
    {
        public frmMidPoint()
        {
            InitializeComponent();
        }
        private void MidPoint(int X1, int Y1, int X2, int Y2)
        {
            double dx = X2 - X1;
            double dy = Y2 - Y1;
            double Di = (2 * dy) - dx;
            double Dd = (2 * dy - dx);

            int x = X1, y = Y1;

            while (x < X2)
            {
                x++;
                if (Di < 0)
                    Di = Di + (2 * dy);

                else
                {
                    Di = Di + Dd;
                    y++;
                }
                pnlGraph.CreateGraphics().FillRectangle(Brushes.White, x, y, 5, 5);

            }


        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int X1 = int.Parse(txtX1.Text);
                int Y1 = int.Parse(txtY1.Text);
                int X2 = int.Parse(txtX2.Text);
                int Y2 = int.Parse(txtY2.Text);

                MidPoint(X1, Y1, X2, Y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex);
            }
        }
    }
}
