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
        private Color color = Color.Black;
        private int lineSize = 1;

        public frmMain()
        {
            InitializeComponent();
            draw = new Bitmap(centerPanel.Width, centerPanel.Height);
            paper = Graphics.FromImage(draw);
        }

        private void centerPanel_MouseClick(object sender, MouseEventArgs e)
        {
            var pen = new Pen(color, lineSize);

            if (rdoCircle.Checked)
            {
                paper.DrawEllipse(pen, e.X, e.Y, 50, 50);
            }

            else if (rdoLine.Checked)
            {
                int secX = e.X + 50 / 2;
                int firstX = e.X - 50 / 2;
                paper.DrawLine(pen, new Point(firstX, e.Y), new Point(secX, e.Y));
            }

            else if (rdoTriangle.Checked)
            {
                paper.DrawLine(pen, new Point(e.X, e.Y), new Point(e.X + 50, e.Y));
                paper.DrawLine(pen, new Point(e.X, e.Y), new Point(e.X, e.Y + 70));
                paper.DrawLine(pen, new Point(e.X + 50, e.Y), new Point(e.X, e.Y + 70));
            }

            else if (rdoSquare.Checked)
            {
                paper.DrawRectangle(pen, e.X, e.Y, 100, 100);
            }

            centerPanel.Refresh();
        }

        private void centerPanel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(draw, new Point(0, 0));
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var img = new Bitmap("C:\\Users\\ReinMusk\\Desktop\\test220.png");
            draw.Dispose();
            draw = new Bitmap(img);
            paper = Graphics.FromImage(draw);
            centerPanel.Refresh();
            img.Dispose();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            draw.Save("C:\\Users\\ReinMusk\\Desktop\\test220.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // clear
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
                btnColor.BackColor = colorDialog1.Color;
            }
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lineSize = Convert.ToInt32(txtSize.Text);
            }
            catch { Exception ex; }   
        }
    }
}