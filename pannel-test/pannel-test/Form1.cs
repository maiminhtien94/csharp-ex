using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pannel_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random btn_random = new Random();
            Button btn = new Button();
            pn_label.Controls.Add(btn);
            btn.Text = "Minh Tien";
            btn.Location = new System.Drawing.Point(btn_random.Next(0, pn_label.Width), btn_random.Next(0, pn_label.Height));
            

        }
    }
}
