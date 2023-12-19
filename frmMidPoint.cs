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

        private void btnDraw_Click(object sender, EventArgs e)
        {
            try
            {
                int X1 = int.Parse(txtX1.Text);
                int Y1 = int.Parse(txtY1.Text);
                int X2 = int.Parse(txtX2.Text);
                int Y2 = int.Parse(txtY2.Text);

                //DDAline(X1, Y1, X2, Y2);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error: " + ex);
            }
        }
    }
}
