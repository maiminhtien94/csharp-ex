using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace drawing_picture_box
{
    public struct XY
    {
        public double X;
        public double Y;
    };
    public partial class Form1 : Form
    {
        Point LineM = new Point(100, 350);
        Point LineN = new Point(50, 250);
        public Form1()
        {
            InitializeComponent();
        }

        public XY ConvertCoord(XY coord,XY origin,double angleDeg) {
            XY result;
            double angle=(360-angleDeg)*Math.PI/180;
            result.X = origin.X + (coord.X - origin.X) * Math.Cos(angle) - (coord.Y - origin.Y) * Math.Sin(angle);
            result.Y = origin.Y + (coord.X - origin.X) * Math.Sin(angle) + (coord.Y - origin.Y) * Math.Cos(angle);
            return result;
        }

        private void btnline_Click(object sender, EventArgs e)
        {
            Point LineA = new Point(20, 200);
            Point LineB = new Point(50, 70);

            Graphics g = ptdraw.CreateGraphics();
            Pen myPen = new Pen(Color.Yellow, 2);
            g.DrawLine(myPen, LineA, LineB);
        }

        private void btncircle_Click(object sender, EventArgs e)
        {
            Graphics g = ptdraw.CreateGraphics();
            Rectangle rect = new Rectangle(80, 80, 50, 50);
            g.DrawEllipse(Pens.Red, rect);

        }

        private void btRectangle_Click(object sender, EventArgs e)
        {
            Point LineA = new Point(20, 200);
            Point LineB = new Point(50, 70);
            Graphics g = ptdraw.CreateGraphics();
            Pen myPen = new Pen(Color.Yellow, 2);
            g.DrawRectangle(myPen, 20, 50, 200, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ptdraw.Refresh();
            Bitmap canvas = new Bitmap(ptdraw.Width,ptdraw.Height);
            Graphics g = Graphics.FromImage(canvas);
            g.DrawLine(Pens.Yellow, new Point(0, 150), new Point(100, 50));
            g.DrawLine(Pens.Green, LineM, LineN);
            ptdraw.Image = canvas;

            
        }

        private void btnelip_Click(object sender, EventArgs e)
        {
            Graphics g = ptdraw.CreateGraphics();
            g.DrawEllipse(Pens.Gray, 20, 30, 120, 230);
        }

        private void btnstring_Click(object sender, EventArgs e)
        {
            

            // Create string to draw.
            String drawString = "Sample Text";
             
            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
             
            // Create point for upper-left corner of drawing.
            float x = 150.0F;
            float y =  50.0F;
             
            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            Graphics g = ptdraw.CreateGraphics();         
            // Draw string to screen.
            g.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
        }

        private void btRotate_Click(object sender, EventArgs e)
        {
            Graphics g = ptdraw.CreateGraphics();
            Pen myPen = new Pen(Color.Green, 2);
            XY coord_temp;
            XY origin;

            origin.X = origin.Y = 0;
            coord_temp.X = LineM.X;
            coord_temp.Y = LineM.Y;
            coord_temp = ConvertCoord(coord_temp, origin, 10);
            LineM.X=(int)coord_temp.X;
            LineM.Y=(int)coord_temp.Y;
            coord_temp.X = LineN.X;
            coord_temp.Y = LineN.Y;
            coord_temp = ConvertCoord(coord_temp, origin, 10);
            LineN.X = (int)coord_temp.X;
            LineN.Y = (int)coord_temp.Y;
            g.DrawLine(myPen, LineM, LineN);
        }
    }
}
