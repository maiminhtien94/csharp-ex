using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace list_in_list
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            example();
        }

        public void example(){
        
            List<List <int>> cot= new List<List<int>>();
            Random rd = new Random();
            for(int i=0;i<10;i++){
                cot.Add(new List<int>());
                for(int j=0;j<rd.Next(1,10);j++){
                    cot[i].Add(rd.Next(1,10));
                }
                cot[i].Sort(new Comparison<int>((h1, h2) => h2.CompareTo(h1)));
            }
        }
    }
}
