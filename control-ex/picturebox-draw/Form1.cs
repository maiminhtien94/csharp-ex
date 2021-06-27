using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace picturebox_draw
{
    public partial class Form1 : Form
    {
        struct Coordinate
        {
            public double X;
            public double Y;

            public Coordinate(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }
        public double hs_a=0, hs_b=0;
        Coordinate A =new Coordinate (100, 30 );
        Coordinate B = new Coordinate(20, 200);
        

        public Form1()
        {
            InitializeComponent();
            Graphics g = ptDraw.CreateGraphics();
            Pen myPen = new Pen(Color.Yellow, 2);
            g.DrawLine(myPen, (float)(A.X), (float)(A.Y), (float)(B.X), (float)(B.Y));
            equation_line();
            Console.WriteLine("A (" + A.X + "," + A.Y + ")");
            Console.WriteLine("B (" + B.X + "," + B.Y + ")");
            Console.WriteLine("a=" + hs_a);
            Console.WriteLine("b=" + hs_b);
            Console.WriteLine("(107,15) check:" + ((107 * hs_a + hs_b)-15));
        }

        public void equation_line()
        { 
            hs_a=(A.Y - B.Y)/(A.X-B.X);
            hs_b = (B.Y * A.X - B.X * A.Y) / (A.X - B.X); 
        }

        public void tinhtiendoanthang()
        {
            
            A.X = A.X + 20;
            B.X = B.X + 20;
            equation_line();

            Console.WriteLine("A_offset (" + A.X + "," + A.Y+")");
            Console.WriteLine("B_offset (" + B.X + "," + B.Y+")");
            Console.WriteLine("hs:" + hs_a);
            Console.WriteLine("hs:" + hs_b);
            Console.WriteLine("Ay check:" + (A.X * hs_a + hs_b));
            Console.WriteLine("By check:" + (B.X * hs_a + hs_b));

        }

        private void btCircle_Click(object sender, EventArgs e)
        {
            
            Graphics g = ptDraw.CreateGraphics();
            Pen myPen = new Pen(Color.Yellow, 2);
            if ((A.X < ptDraw.Size.Width && B.X < ptDraw.Size.Width) && (A.Y < ptDraw.Size.Height && B.Y < ptDraw.Size.Height))
            {
                tinhtiendoanthang();
                g.DrawLine(myPen, (float)(A.X), (float)(A.Y), (float)(B.X), (float)(B.Y));
            }
        }

    }
}
