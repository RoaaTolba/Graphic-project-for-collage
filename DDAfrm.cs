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
    public partial class DDAfrm : Form
    {
        public DDAfrm()
        {
            InitializeComponent();
        }

        private void DDAline(int X1,int Y1,int X2,int Y2)
        {
            Pen pen = new Pen(Color.White, 5);

            int dx=X2- X1;
            int dy=Y2- Y1;
            int step;

            if (Math.Abs(dx) > Math.Abs(dy))
                step = Math.Abs(dx);
            else
                step = Math.Abs(dy);

            float xIncrement = (float)dx / step;
            float yIncrement = (float)dy / step;

            float x = X1;
            float y = Y1;

            for (int i = 0; i < step; i++)
            {
                x+= xIncrement;
                y+= yIncrement;
                pnlGraph.CreateGraphics().FillRectangle(Brushes.White, x, y, 5, 5);
            }

            //PointF pnt1 = new PointF(X1, Y1);
            //PointF pnt2 = new PointF(x,y);
            //pnlGraph.CreateGraphics().DrawLine(pen , pnt1,pnt2);

        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int X1 = int.Parse(txtX1.Text);
                int Y1 = int.Parse(txtY1.Text);
                int X2 = int.Parse(txtX2.Text);
                int Y2 = int.Parse(txtY2.Text);

                DDAline(X1, Y1, X2, Y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: "+ex);
            }


            


        }
    }
}
