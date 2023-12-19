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
    public partial class frmScale : Form
    {
        public frmScale()
        {
            InitializeComponent();
        }
        private void TranslateLine(int X1,int Y1, int X2, int Y2, int Tx, int Ty)
        {
            // the basic line
            Pen pen = new Pen(Color.White, 5);
            PointF pnt1 = new PointF(X1, Y1);
            PointF pnt2 = new PointF(X2, Y2);
            pnlGraph.CreateGraphics().DrawLine(pen, pnt1, pnt2);


            // the basic line
            Pen pen2 = new Pen(Color.DarkSeaGreen, 5);
            PointF pnt3 = new PointF((X1+Tx), (Y1+Ty));
            PointF pnt4 = new PointF((X2+Tx), (Y2+Ty));
            pnlGraph.CreateGraphics().DrawLine(pen2, pnt3, pnt4);


        }
        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int X1 = int.Parse(txtX1.Text);
                int Y1 = int.Parse(txtY1.Text);
                int X2 = int.Parse(txtX2.Text);
                int Y2 = int.Parse(txtY2.Text);
                int Tx = int.Parse(txtTX.Text);
                int Ty = int.Parse(txtTY.Text);

                TranslateLine(X1, Y1, X2, Y2, Tx, Ty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex);
            }
        }

    }
}
