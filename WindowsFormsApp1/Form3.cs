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
    public partial class Form3 : Form
    {
        // Form1-dən gələn event referansı
        private readonly EventHandler<Telebe> telebeElaveEdildi;

        public Form3(EventHandler<Telebe> telebeElaveEdildi)
        {
            InitializeComponent();
            this.telebeElaveEdildi = telebeElaveEdildi;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            // TextBox-lardan məlumatları al
            string firstName = textBox1.Text;
            string lastName = textBox3.Text;
            int age = Convert.ToInt32(textBox4.Text);
            string fac = textBox5.Text;

            // Məlumatları obyektdə saxla
            Telebe telebe = new Telebe
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age,
                Fac = fac
            };

            // Məlumatları Form1-ə geri qaytar
            telebeElaveEdildi?.Invoke(this, telebe);
            this.Close();
        }

    }
}