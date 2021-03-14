using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace Завдання_1
{
    public partial class Form4 : Form
    {
        Thread th;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openf1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        public void openf1(object obj)
        {
            Application.Run(new Form1());
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double y1 = Convert.ToDouble(textBox2.Text);
            double x2 = Convert.ToDouble(textBox3.Text);
            double y2 = Convert.ToDouble(textBox4.Text);
            double x3 = Convert.ToDouble(textBox5.Text);
            double y3 = Convert.ToDouble(textBox6.Text);
            double x4 = Convert.ToDouble(textBox7.Text);
            double y4 = Convert.ToDouble(textBox8.Text);
            double eps = 0.000001;
            double ab = (x2 - x1) * (x3 - x2) + (y2 - y1) * (y3 - y2);
            double ac = (x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1);
            double bc = (x3 - x2) * (x3 - x1) + (y3 - y2) * (y3 - y1);
            if ((ab) < eps)
            {
                string i = "Трикутник Прямокутний";
                label14.Text = i;
                label14.Show();
            }
            else if ((ac) < eps)
            {
                string i = "Трикутник Прямокутний";
                label14.Text = i;
                label14.Show();
            }
            else if ((bc) < eps)
            {
                string i = "Трикутник Прямокутний";
                label14.Text = i;
                label14.Show();
            }
            else
            {
                string i = "Трикутник не Прямокутний";
                label14.Text = i;
                label14.Show();
            }
        }
    }
}
