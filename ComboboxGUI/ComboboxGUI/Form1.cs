using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboboxGUI
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  

        private void cblist_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            MessageBox.Show("SelectedItem: " + cb.SelectedItem.ToString());
        }

        private void cblist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            MessageBox.Show("SelectedIndex: "+cb.SelectedIndex.ToString());
        }
        public List<Food> cb_items ;
        private void btLoadItems_Click(object sender, EventArgs e)
        {
            cb_items=new List<Food>(){
                new Food(){Name="Tao",Price= 200000},
                new Food(){Name="Xoai",Price= 100000},
                new Food(){Name="Cam",Price= 700000}
            };
            cblist.DataSource = cb_items;
            cblist.DisplayMember = "Name";
        }
    }
    public class Food{
        public string Name {get;set;}
        public int Price {get;set;}
    }
}
