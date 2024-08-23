using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Form2 : Form
    {
        Form4 form4;
        public Form2() { InitializeComponent(); }
        private void button1_Click(object sender, EventArgs e)
        {
      
            File.AppendAllText("data.txt", ttextBox.Text + Environment.NewLine);

            if (form4 == null) 
            {
                form4 = new Form4(); 
                form4.Owner = this;
                form4.Show(); 
            }
            form4.listBox1.Items.Add(ttextBox.Text); 
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }


}