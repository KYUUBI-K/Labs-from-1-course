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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            double S = 0;
            while (n >= 1)
            {
                S += Math.Log(Math.Abs(Math.Pow(a, n)));
                n--;
            }
            textBox3.Text = S.ToString();
        }
    }
}
