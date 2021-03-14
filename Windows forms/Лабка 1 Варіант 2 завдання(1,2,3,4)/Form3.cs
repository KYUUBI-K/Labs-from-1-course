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
    public partial class Form3 : Form
    {
        Thread th;
        public Form3()
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

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);
            double d = Convert.ToDouble(textBox4.Text);
            if (1 <= a && a <= 2 && a >= c && a <= d)
            {
                string i = "а належить інтервалу";
                label6.Text = i;
                label6.Show();
            }
            else
            {
                string g = "а не належить інтервалу";
                label6.Text = g;
                label6.Show();
            }
            if (1 <= b && b <= 2 && b >= c && b <= d)
            {
                string i = "b належить інтервалу";
                label3.Text = i;
                label3.Show();
            }
            else
            {
                string g = "b не належить інтервалу";
                label3.Text = g;
                label3.Show();
            }
            if (1 <= c && c <= 2 && c >= c && c <= d)
            {
                string i = "c належить інтервалу";
                label8.Text = i;
                label8.Show();
            }
            else
            {
                string g = "c не належить інтервалу";
                label8.Text = g;
                label8.Show();
            }
            if (1 <= d && d <= 2 && d >= c && d <= d)
            {
                string i = "d належить інтервалу";
                label9.Text = i;
                label9.Show();
            }
            else
            {
                string g = "d не належить інтервалу";
                label9.Text = g;
                label9.Show();
            }
        }
    }
}
