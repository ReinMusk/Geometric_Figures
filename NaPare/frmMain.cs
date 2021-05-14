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
        private Bitmap draw;
        private Graphics paper;

        public frmMain()
        {
            InitializeComponent();
            draw = new Bitmap(centerPanel.Width, centerPanel.Height);
            paper = Graphics.FromImage(draw);

        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            var frmCircle = new frmCircle();

            if (frmCircle.ShowDialog(this) == DialogResult.OK)
            {
                var pen = new Pen(Color.Blue, 4);
                paper.DrawEllipse(pen, 200, 200, 100, 100);
                centerPanel.Refresh();
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            var frmLine = new frmLine();

            if (frmLine.ShowDialog(this) == DialogResult.OK)
            {
                var pen = new Pen(Color.Blue, 4);
                paper.DrawLine(pen, new Point(200, 100), new Point(100, 350));
                centerPanel.Refresh();
            }
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            var frmTriangle = new frmTriangle();

            if (frmTriangle.ShowDialog(this) == DialogResult.OK)
            {
                var pen = new Pen(Color.Blue, 5);

                Point[] points = { new Point(20, 20), new Point(110, 20), new Point(60, 110) };
                paper.DrawPolygon(pen, points);
                centerPanel.Refresh();

            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            var frmSquare = new frmSquare();

            if (frmSquare.ShowDialog(this) == DialogResult.OK)
            {
                var pen = new Pen(Color.Blue, 5);
                paper.DrawRectangle(pen, 130, 130, 180, 180);
                centerPanel.Refresh();
            }
        }

        private void centerPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var pen = new Pen(Color.Green, 5);

            if (rdoCircle.Checked)
            {
                paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
            }

            if (rdoLine.Checked)
            {
                int secX = e.X + 50 / 2;
                int firstX = e.X - 50 / 2;
                paper.DrawLine(pen, new Point(firstX, e.Y), new Point(secX, e.Y));
            }

            if (rdoTriangle.Checked)
            {
                paper.DrawLine(pen, new Point(e.X, e.Y), new Point(e.X + 50, e.Y));
                paper.DrawLine(pen, new Point(e.X, e.Y), new Point(e.X, e.Y + 70));
                paper.DrawLine(pen, new Point(e.X + 50, e.Y), new Point(e.X, e.Y + 70));
            }

            if (rdoSquare.Checked)
            {
                pen = new Pen(Color.Blue, 5);
                paper.DrawRectangle(pen, e.X, e.Y, 100, 100);
            }
            centerPanel.Refresh();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var img = new Bitmap("c:\\users\\public\\pictures\\test220.png");
            draw.Dispose();
            draw = new Bitmap(img);
            paper = Graphics.FromImage(draw);
            centerPanel.Refresh();
            img.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            draw.Save("c:\\users\\public\\pictures\\220.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
        }
    }
}