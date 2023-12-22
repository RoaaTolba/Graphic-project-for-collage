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
        void DrawPixels(int x, int y, int X1, int Y1)
        {


            //picC.SetPixel(Brushes.White, x + X1, y + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, x + X1, -1 * y + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, -1 * x + X1, y + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, -1 * x + X1, -1 * y + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, y + X1, x + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, -1 * y + X1, x + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, y + X1, -1 * x + Y1, 5, 5);
            //picC.SetPixel(Brushes.White, -1 * y + X1, -1 * x + Y1, 5, 5);

            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, x + X1, y + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, x + X1, -1 * y + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, -1 * x + X1, y + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, -1 * x + X1, -1 * y + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, y + X1, x + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, -1 * y + X1, x + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, y + X1, -1 * x + Y1, 5, 5);
            pnlGraph.CreateGraphics().FillEllipse(Brushes.White, -1 * y + X1, -1 * x + Y1, 5, 5);
            // pnlGraph.CreateGraphics().FillClosedCurve(Brushes.White, -1 * y + X1, -1 * x + Y1, 5, 5);
        }


        private void MidPoint(int X1, int Y1, int r)
        {
            int P = 1 - r;
            int x = 0;
            int y = r;
            while (x <= y)
            {
                DrawPixels(x, y, X1, Y1);
                if (P < 0)
                {
                    P = P + (2 * (x - y) + 5);
                    x++;
                }
                else
                {
                    P += (2 * (x - y)) + 5;
                    x++;
                    y--;
                }
            }

        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int X1 = int.Parse(txtX1.Text);
                int Y1 = int.Parse(txtY1.Text);
                int r = int.Parse(txtRadius.Text);
                MidPoint(X1, Y1, r);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex);
            }
        }
    }
}
