using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordsofwisdomgui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.MouseEnter += OnMouseEnterLabel1;
            label2.MouseEnter += OnMouseEnterLabel2;
            label3.MouseEnter += OnMouseEnterLabel3;
            label4.MouseEnter += OnMouseEnterLabel4;
            label5.MouseEnter += OnMouseEnterLabel5;
            this.MouseEnter += OnMouseEnterForm1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OnMouseEnterLabel1(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // or Color.Red or whatever you want
        }
        private void OnMouseEnterLabel2(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // or Color.Red or whatever you want
        }
        private void OnMouseEnterLabel3(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // or Color.Red or whatever you want
        }
        private void OnMouseEnterLabel4(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // or Color.Red or whatever you want
        }
        private void OnMouseEnterForm1(object sender, EventArgs e)
        {
            this.BackColor = Color.Black; // or Color.Red or whatever you want
        }
        private void OnMouseEnterLabel5(object sender, EventArgs e)
        {
            this.BackColor = Color.White; // or Color.Red or whatever you want
        }
    }
}
