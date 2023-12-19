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
    public partial class frmBresenham : Form
    {
        public frmBresenham()
        {
            InitializeComponent();
        }
        private void BresenhamLine(int X1, int Y1, int X2, int Y2)
        {
            Pen pen = new Pen(Color.White, 5);

            double dx = X2 - X1;
            double dy = Y2 - Y1;
            double Pk = (2*dy) - dx;

            int flag = 0;
            int x=X1, y=Y1;


            //PointF pnt1 = new PointF(X1, Y1);
            //PointF pnt2 = new PointF(x, y);
            while (x < X2)
            {
                x++;
                if (Pk < 0)
                    Pk = Pk + (2 * dy);
                   
                else
                {
                    Pk = Pk + (2 *( dy -dx));
                    y++;
                }
               // pnt1 = new PointF(X1, Y1);
                pnlGraph.CreateGraphics().FillRectangle(Brushes.White,x,y,5,5);

                //pnlGraph.CreateGraphics().DrawLine(pen, pnt1, pnt2);
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

                BresenhamLine(X1, Y1, X2, Y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex);
            }
            

        }

    }
}

