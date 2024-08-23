using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Api_Wholesale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table2BindingSource.RemoveCurrent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string api = "d8c5a3ecd20e84f3f368aa8f004ed9ce";
            string connection = "http://api.openweathermap.org/data/2.5/weather?q=Nakhchivan,AZ&mode=xml&appid=" + api;
            XDocument hava = XDocument.Load(connection);
            var havaninistiliyi = hava.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            label6.Text = havaninistiliyi.ToString();

            var city = hava.Descendants("city").ElementAt(0).Attribute("name").Value;
            label7.Text = city.ToString();

            var speed = hava.Descendants("speed").ElementAt(0).Attribute("value").Value;
            var cond = hava.Descendants("speed").ElementAt(0).Attribute("name").Value;
            var direction = hava.Descendants("direction").ElementAt(0).Attribute("value").Value;
            var direc = hava.Descendants("direction").ElementAt(0).Attribute("name").Value;
            label8.Text = speed.ToString();
            label9.Text = cond.ToString();
            label10.Text = direction.ToString();
            label11.Text = direc.ToString();

            // TODO: This line of code loads data into the 'wholesale_databseDataSet.Table2' table. You can move, or remove it, as needed.
            this.table2TableAdapter.Fill(this.wholesale_databseDataSet.Table2);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            table2BindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            table2BindingSource.EndEdit();
            table2TableAdapter.Update(wholesale_databseDataSet.Table2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
                form2.Show();
            

        }
    }
}
