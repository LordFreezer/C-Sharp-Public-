using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace florenceFloralCreations
{
    public partial class Form1 : Form      
    {
        List<string> _items = new List<string>();
        List<string> _occations = new List<string>();
        public Form1()
        {
            InitializeComponent();
            _items.Add("Rose");
            _items.Add("Daisy");
            _occations.Add("Cancer");
            _occations.Add("Death");
            _occations.Add("Your death");
            _occations.Add("Birthday");
    
            listBox1.DataSource = _items;
            listBox2.DataSource = _occations;
            label1.Visible = false;
            listBox1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)listBox1.SelectedItem == "Rose")
            {
                label1.Text = "Hope that cancer gets better!";
                label1.Visible = true;
            }
            if ((string)listBox1.SelectedItem == "Daisy")
            {
                label1.Text = "Good choice!";
                label1.Visible = true;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
         
             if ((string)listBox2.SelectedItem == "Cancer")
            {
                listBox1.Visible = true;
            }
          /*  else if ((string)listBox1.SelectedItem == "Death")
            {
                listBox1.Visible = true;
            }
            else if ((string)listBox1.SelectedItem == "Your Death")
            {
                listBox1.Visible = true;
            }
           else if ((string)listBox1.SelectedItem == "Birthday")
            {
                listBox1.Visible = true;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
