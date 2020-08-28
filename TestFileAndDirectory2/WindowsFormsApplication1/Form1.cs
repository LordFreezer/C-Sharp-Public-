using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string directoryName;
            directoryName = @"D:\Documents\Caesar";///You can edit this yourself when you test/grade it
            string[] listOfFiles;
            listOfFiles = Directory.GetFiles(directoryName);
            for (int x = 0; x < listOfFiles.Length; ++x)
            {
                checkedListBox1.Items.Add(listOfFiles[x]);
            }
        }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemCheck = Convert.ToString(checkedListBox1.SelectedItem);
            label1.Text = "Created at " + File.GetCreationTime(itemCheck);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
