using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myflix
{
    public partial class Form1 : Form
    {
        List<string> _items = new List<string>();
        public Form1()
        {
            InitializeComponent();
            _items.Add("Bible Black");
            _items.Add("Boku No Pico");
            _items.Add("Broke Back Mountain");
            _items.Add("Pico X Chico");
            _items.Add("The Apprentece Feat. Donald Trump");
            _items.Add("Corn Hub's Greatest and Finest");
            listBox1.DataSource = _items;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ((listBox1.SelectedItems.Count * 1.99).ToString("C"));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
