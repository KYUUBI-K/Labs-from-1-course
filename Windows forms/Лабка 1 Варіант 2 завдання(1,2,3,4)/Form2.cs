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
    public partial class Form2 : Form
    {
        Thread th;
        public Form2()
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
            int AB = Convert.ToInt32(textBox1.Text);
            int BC = Convert.ToInt32(textBox2.Text);
            int AC = Convert.ToInt32(textBox3.Text);
            double p = (AB + BC + AC) / 2.0;
            textBox4.Text = p.ToString();
            double S = Math.Sqrt(p * (p - AB) * (p - BC) * (p - AC));
            textBox5.Text = S.ToString();
        }
    }
}
