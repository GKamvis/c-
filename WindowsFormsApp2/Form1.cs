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
    public partial class Form1 : Form
    {
        Form2 form2;
        Form4 form4;
        Form3 form3;
        public Form1()
        {
            InitializeComponent();
        }

        private void teacherMenu_Click(object sender, EventArgs e)
        {
            form2 = new Form2();
            form2.Owner = this;
            form2.Show();

        }

        private void allData_Click(object sender, EventArgs e)
        {
            form4 = new Form4();
            //form4.Owner = this;
            form4.Show();
            
        }

        private void studentMenu_Click(object sender, EventArgs e)
        {
            form3 = new Form3();
            //form4.Owner = this;
            form3.ShowDialog();
        }
    }
}
