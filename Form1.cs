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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //private void DrowLine(int X1, int Y1, int X2, int Y2)
        //{
        //    Pen pen = new Pen(Color.Blue, 5);
        //    PointF pnt1 = new PointF(X1, Y1);
        //    PointF pnt2 = new PointF(X2, Y2);
        //    //pnlGraph.CreateGraphics().DrawLine(pen, pnt1, pnt2);
        //}


        private Form activeForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnDDA_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DDAfrm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBresenham());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmMidPoint());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCohan());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmScale());
        }
    }
}
