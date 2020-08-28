/* Chad Marshall         Chapter 3       Question 6         10/13/15 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_Question_1_Chad_Marshall_MilesToKilometers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double MILES_TO_KM = 1.6;/// there are 1.6 miles in a kilometer
            double Miles;///the varible for miles
            double total;///the varibel for the total
            Miles = Convert.ToDouble(textBox1.Text);///Miles is the varible for user imput 
            total = Miles * MILES_TO_KM;///the math part of the program
            label3.Text = "Kilometers = " + total;///the code that connects the output with the labe
        }
    }
}
