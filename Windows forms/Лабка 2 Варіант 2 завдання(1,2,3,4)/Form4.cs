using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабка_2_Варіант_2_завдання_1_2_3_4_
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            int a = 1;
            double s = 0;
            double eps = 0.000001;
            while ((Math.Abs((Math.Pow(x, a))) / a) > eps)
            {
                s = s - (Math.Abs((Math.Pow(x, a))) / a);
                a++;
            }
            textBox2.Text = s.ToString();
            if ((Math.Log(1 - x) - s) < eps)
            {
                string i = "Рівність справедлива";
                label4.Text = i;
                label4.Show();
            }
            else
            {
                string g = "Рівність не справедлива";
                label4.Text = g;
                label4.Show();
            }
        }


    }
}
