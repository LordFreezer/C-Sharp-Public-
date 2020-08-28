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

namespace Re_Question_4_Chaud_Marshall_EggsInteractiveGUI
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string MegaManEggCountAsString;                                                                                ///string for first chicken
            int MegaManEggCount;                                                                                          ///varible for first chicken
            MegaManEggCount = Convert.ToInt32(textBox1.Text);                                                            /// amount of eggs (user input)
            string GraveEggCountAsString;                                                                               ///string for second chicked
            int GraveEggCount;                                                                                         ///varible for second chicken
            GraveEggCount = Convert.ToInt32(textBox2.Text);                                                           /// amount of eggs (user input)
            string RushEggCountAsString;                                                                             ///string for third chicken
            int RushEggCount;                                                                                       ///varible for third chicken
            RushEggCount = Convert.ToInt32(textBox3.Text);                                                         /// amount of eggs (user input)
            string BassEggCountAsString;                                                                          ///string for fourth chicken
            int BassEggCount;                                                                                    ///varible for fourth chicken
            BassEggCount = Convert.ToInt32(textBox4.Text);                                                      /// amount of eggs (user input)
            string TrebleEggCountAsString;                                                                     ///string for fifth chicken
            int TrebleEggCount;                                                                               ///varible for fifth chicken
            TrebleEggCount = Convert.ToInt32(textBox5.Text);                                                 /// amount of eggs (user input)
            int EggTotal;                                                                                   ///verible for the total amount of eggs 
            EggTotal = MegaManEggCount + RushEggCount + BassEggCount + TrebleEggCount + GraveEggCount;     ///the total amount of eggs
            int EggDozen;                                                                                 ///the verible for how many dozen there are
            EggDozen = EggTotal / 12;                                                                    ///how many dozens there are
            double Remainder;                                                                           /// the varible for Remainder
            Remainder = EggTotal % 12;                                                                 ///the amount of eggs left over
            label2.Text = EggTotal + " eggs is " + EggDozen + " dozen with " + Remainder + " left over ";///the finished statement

        }
    }
}
