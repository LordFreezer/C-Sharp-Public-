/* Chad Marshall         Chapter 3       Question 5*            10/13/15 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_5_Chaud_Marshall_TestsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string RockScoreAsString;                                                                       /// string for first score
            double RockScore;                                                                              ///varible for first score
            RockScore = Convert.ToDouble(textBox1.Text);                                                  ///first score
            string BluesScoreAsString;                                                                   ///string for second score
            double BluesScore;                                                                          ///varible for second score
            BluesScore = Convert.ToDouble(textBox2.Text);                                              ///second score
            string BassScoreAsString;                                                                 /// string for thire score
            double BassScore;                                                                        ///varibel for thrid score
            BassScore = Convert.ToDouble(textBox3.Text);                                            ///third score
            string RollScoreAsString;                                                              ///string for fourth score
            double RollScore;                                                                     ///varible for fourth score
            RollScore = Convert.ToDouble(textBox4.Text);                                         ///fourth score
            string GutsManScoreAsString;                                                        ///string for fifth score
            double GutsManScore;                                                               ///varible for fith score
            GutsManScore = Convert.ToDouble(textBox5.Text);                                   ///fifth score
            double ScoreTotal;                                                               ///varible for the total
            ScoreTotal = RockScore + BassScore + RollScore + GutsManScore + RollScore;      ///the total amount of test scores
            double Mean;                                                                   ///verible for the average
            Mean = ScoreTotal / 5;                                                        ///the average
            label2.Text = "The average score of all 5 tests is " + Mean;                 ///connects the statement to the label
        }
    }
}
