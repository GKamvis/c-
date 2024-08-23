using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
        
    {
        Form4 form4;
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sbutton1_Click(object sender, EventArgs e)
        {
            if (form4 == null) 
            {
                form4 = new Form4();
                form4.Owner = this;
                form4.Show();
            }
            form4.listBox2.Items.Add(stextBox1.Text); 
        }
    }
    }

