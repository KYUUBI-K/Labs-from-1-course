using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабка_5_Варіант_2_Завдання__1_2_3_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            double u = Find_something.f(a, b) + Find_something.f(2, a) + 2;
            textBox3.Text = u.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox4.Text);
            int b = Convert.ToInt32(textBox5.Text);
            double S = Find_something.S(3, b)+Find_something.S(a,b);
            textBox6.Text = S.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double S = Find_something.get_res(7) + Find_something.get_res(9);
            textBox7.Text = S.ToString();

        }
    }
}
