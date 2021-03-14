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
    public partial class Form5 : Form
    {
        public Form5()
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
            int n = Convert.ToInt32(textBox1.Text);
            int x0 = 1;
            int x1 = 1;
            int xi = 0;
            for (int i = 2; i < n+1; i++)
            {
                xi = x1 + 2 * x0;
                x1 = xi;
                x0 = x1;
            }
            textBox2.Text = xi.ToString();
        }
    }
}
