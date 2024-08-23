using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Api_Wholesale
{

    public partial class Form2 : Form
    {
        private int i;
        private int j;
        private Random random;
        private int speed1;
        private int speed2;
        private System.Timers.Timer timer1;

        public Form2()
        {

            InitializeComponent();
            i = 0;
            j = 0;
            random = new Random();
            timer1 = new System.Timers.Timer();
            timer1.Interval = 100; // 100 ms
            timer1.Elapsed += new System.Timers.ElapsedEventHandler(timer1_Tick);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            speed1 = random.Next(1, 6);
            speed2 = random.Next(1, 6);

            timer1.Start();

        }
        private void timer1_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() => race1()));
            Invoke(new Action(() => race2()));
        }
        private void race1()
        {
            if (pictureBox1.Location.X < panel1.Size.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + speed1, pictureBox1.Location.Y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Maşın 1 qazandı!");
            }
        }
        private void race2()
        {
            if (pictureBox2.Location.X < panel2.Size.Width)
            {
                pictureBox2.Location = new Point(pictureBox2.Location.X + speed2, pictureBox2.Location.Y);
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Maşın 2 qazandı!");
            }
        }

       

    }
}
