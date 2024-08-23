using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.Form1;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        // Form1-dən gələn event referansı
        private readonly EventHandler<Muellim> muellimElaveEdildi;

        public Form2(EventHandler<Muellim> muellimElaveEdildi)
        {
            InitializeComponent();
            this.muellimElaveEdildi = muellimElaveEdildi;
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            string firstName = textBoxS.Text;
            string lastName = textBox2S.Text;
            int age = Convert.ToInt32(textBox4S.Text);
            string sub = textBox5S.Text;

            Muellim muellim = new Muellim
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Sub = sub
            };

            // Məlumatları Form1-ə geri qaytar
            muellimElaveEdildi?.Invoke(this, muellim);
            this.Close();
        }

    }
}