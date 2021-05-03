using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaPare
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }




        private void btnCircle_Click(object sender, EventArgs e)
        {
            var frmCircle = new frmCircle();

            if(frmCircle.ShowDialog(this) == DialogResult.OK)
            {
                var paper = centerPanel.CreateGraphics();
                var pen = new Pen(Color.Blue, 4);
                paper.DrawEllipse(pen, 200, 200, 100, 100);
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            var frmLine = new frmLine();

            if (frmLine.ShowDialog(this) == DialogResult.OK)
            {
                var paper = centerPanel.CreateGraphics();
                var pen = new Pen(Color.Blue, 4);
                paper.DrawLine(pen, new Point(200,100), new Point(100,350));
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var frmTriangle = new frmTriangle();

            if (frmTriangle.ShowDialog(this) == DialogResult.OK)
            {
                var paper = centerPanel.CreateGraphics();
                var pen = new Pen(Color.Blue, 5);

                Point[] points = { new Point(20, 20), new Point(110, 20), new Point(60, 110) };
                paper.DrawPolygon(pen, points);
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            var frmSquare = new frmSquare();

            if (frmSquare.ShowDialog(this) == DialogResult.OK)
            {
                var paper = centerPanel.CreateGraphics();
                var pen = new Pen(Color.Blue, 5);
                paper.DrawRectangle(pen, 130, 130, 180, 180);
            }
        }

        private void centerPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var paper = centerPanel.CreateGraphics();
            var pen = new Pen(Color.Green, 5);

            if (rdoCircle.Checked)
            {
                paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
            }

            if (rdoLine.Checked)
            {
                paper.DrawLine(pen, new Point(e.X, 100), new Point(e.Y, 100));
            }

            if (rdoTriangle.Checked)
            {
                Point[] points = { new Point(e.X, e.Y), new Point(e.X, e.Y), new Point(e.X, e.Y) };
                paper.DrawPolygon(pen, points);
            }

            if (rdoSquare.Checked)
            {
                paper = centerPanel.CreateGraphics();
                pen = new Pen(Color.Blue, 5);
                paper.DrawRectangle(pen, e.X, e.Y, 100, 100);
            }
        }

        private void btnPen_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
