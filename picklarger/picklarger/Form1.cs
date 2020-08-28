using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace picklarger
{
    public partial class Form1 : Form
    {
        Random RandomClass = new Random();
        const int MIN = 0;
        const int MAX = 100;
        int[] array1 = new int[100];
        int[] array2 = new int[100];
        int x;
        int right = 0;
        int wrong = 0;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (x = 0; x < array1.Length; ++x)
                array1[x] = RandomClass.Next(MIN, MAX);
            for (x = 0; x < array2.Length; ++x)
                array2[x] = RandomClass.Next(MIN, MAX);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (array1[count] >= array2[count])
                ++right;
            else
                ++wrong;
            label4.Text = "Right " + right;
            label5.Text = "Wrong " + wrong;
            label2.Text = array1[count].ToString();
            label3.Text = array2[count].ToString();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (array2[count] >= array1[count])
                ++right;
            else
                ++wrong;
            label4.Text = "Right " + right;
            label5.Text = "Wrong " + wrong;
            label2.Text = array1[count].ToString();
            label3.Text = array2[count].ToString();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            label2.Text = "?";
            label3.Text = "?";
            ++count;
            if (count == array1.Length)
                count = 0;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}