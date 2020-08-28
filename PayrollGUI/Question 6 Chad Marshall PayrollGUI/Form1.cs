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

namespace Question_6_Chad_Marshall_PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) /*getting the characters to work was a pain.*/
        {

            String empName = (textBox2.Text); /* here is the script for the employee name*/
            foreach (Char x in empName)/// x is the value for user imput
            {
                String cString = x.ToString();
            }
            label5.Text = "The weekly payroll information summary for " + empName;/// this makes the form display x along with the text in the comment
            String empSocial = (textBox3.Text); /// i found out that int or double cant handle "-" as input so im doing it the hard way
            foreach (Char y in empSocial)/// y is the value for user imput
            {
                String cString = y.ToString();
            }
            double hrsWorked = Convert.ToDouble(textBox4.Text);
            double payRate = Convert.ToDouble(textBox1.Text);
            double grossPay = (hrsWorked * payRate);/// here is the math part of the program
            double federalTaxWithheld = (0.15 * grossPay);
            double socialSecurityWithheld = (0.5 * grossPay);
            double netPay = (grossPay - federalTaxWithheld + socialSecurityWithheld);
            label6.Text = "GrossPay Pay: " + grossPay;/// just a simple text + varible statement
            label6.Text = (grossPay.ToString("C"));/// here I had converted it to currency 
            label7.Text = "Federal income taxes withheld: " + federalTaxWithheld;
            label7.Text = (federalTaxWithheld.ToString("C"));
            label8.Text = "Social Security taxes withheld: " + socialSecurityWithheld;
            label8.Text = (socialSecurityWithheld.ToString("C"));
            label9.Text = "NetPay: " + netPay;
            label9.Text = (netPay.ToString("C"));










        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
