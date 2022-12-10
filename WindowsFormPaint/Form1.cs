using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPaint
{
    public partial class Paint : Form
    {
        Bitmap picture;
        int x1, y1;
        int x2, y2;
        string mode;
        public Paint()
        {
            InitializeComponent();
            mode = "pen";
            picture = new Bitmap(1920, 1080);
            x1 = y1 = 0;
            checkBox1.Checked = true;
        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x2 = e.X; y2 = e.Y;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(colorDialog1.Color, trackBar.Value);
            //System.Drawing.SolidBrush Brush = new System.Drawing.SolidBrush(colorDialog1.Color);
            Graphics g = Graphics.FromImage(picture);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            if (mode == "react")
            {
                int x, y;
                x = x2;
                y = y2;
                if (x > e.X) x = e.X;
                if (y > e.Y) y = e.Y;
                if (e.Button == MouseButtons.Left)
                    g.DrawRectangle(pen, x, y, Math.Abs(e.X - x2), Math.Abs(e.Y - y2));
                //if (e.Button == MouseButtons.Right)
                    //g.FillRectangle(Brush, new Rectangle(x, y, Math.Abs(e.X - x2), Math.Abs(e.Y - y2)));
            }
            /*
            if (mode == "fsd")
            {
                if (e.Button == MouseButtons.Left)
                    g.DrawEllipse(pen, x2, y2, e.X - x2, e.Y - y2);
                if (e.Button == MouseButtons.Right)
                    g.FillEllipse(Brush, new Rectangle(x2, y2, e.X - x2, e.Y - y2));
            }
            if (mode == "Line")
            {
                if (e.Button == MouseButtons.Left)
                    pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Flat;
                if (e.Button == MouseButtons.Right)
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                }
                g.DrawLine(pen, x2, y2, e.X, e.Y);
            }
            */
            pictureBox1.Image = picture;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Pen pen = new Pen(colorDialog1.Color, trackBar.Value);
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Graphics g = Graphics.FromImage(picture);
            g.SmoothingMode = SmoothingMode.HighQuality;
            //BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(g, Rectangle.Round(g.VisibleClipBounds));
            if (e.Button == MouseButtons.Left)
            {
                if (mode == "pen")
                {
                    g.DrawLine(pen, x1, y1, e.X, e.Y);
                }
                if (mode == "eraser")
                {
                    pen.Color = checkBox2.BackColor;
                    g.DrawLine(pen, x1, y1, e.X, e.Y);
                }
                /*
                if (mode == "react")
                {
                    int x, y;
                    x = x2;
                    y = y2;
                    if (x > e.X) x = e.X;
                    if (y > e.Y) y = e.Y;
                    bg.Graphics.DrawRectangle(pen, x, y, Math.Abs(e.X - x2), Math.Abs(e.Y - y2));
                }
                */
                //bg.Render(g);
                //pictureBox1.Image = picture;
            }
            if (e.Button == MouseButtons.Right)
            {
                if (mode == "pen")
                {
                    g.DrawLine(pen, x1, y1, e.X, e.Y);
                }
                /*
                if (mode == "Rect")
                {
                    int x, y;
                    x = x2;
                    y = y2;
                    if (x > e.X) x = e.X;
                    if (y > e.Y) y = e.Y;
                    bg.Graphics.FillRectangle(Brush, new Rectangle(x, y, Math.Abs(e.X - x2), Math.Abs(e.Y - y2)));
                }
                if (mode == "Ellipse")
                {
                    bg.Graphics.FillEllipse(Brush, new Rectangle(x2, y2, e.X - x2, e.Y - y2));
                }
                if (mode == "Line")
                {
                    pen.StartCap = System.Drawing.Drawing2D.LineCap.Flat;
                    pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    bg.Graphics.DrawLine(pen, x2, y2, e.X, e.Y);
                }
                */
                pictureBox1.Image = picture;
            }
            
            pictureBox1.Refresh();
            x1 = e.X;
            y1 = e.Y;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { checkBox2.Checked = false; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { checkBox1.Checked= false; }
        }
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void palitraButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (checkBox1.Checked)
                {
                    checkBox1.BackColor = colorDialog1.Color;
                }
                else
                {
                    checkBox2.BackColor = colorDialog1.Color;
                }
            }
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            mode = "eraser";
        }

        private void pipetkaButton_Click(object sender, EventArgs e)
        {
            mode = "pipetka";
        }

        private void textButton_Click(object sender, EventArgs e)
        {
            mode = "text";
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            mode= "line";
        }

        private void reactangleButton_Click(object sender, EventArgs e)
        {
            mode= "react";
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            mode = "circle";
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            mode = "pen";
        }
    }
}
