using System;

using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4() { InitializeComponent(); }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Form4_Load(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines("data.txt");


            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }

        }
    }

}
