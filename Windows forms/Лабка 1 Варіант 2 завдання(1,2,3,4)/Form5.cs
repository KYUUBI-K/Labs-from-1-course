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
    public partial class Form5 : Form
    {
        Thread th;
        public Form5()
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
            int x = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);
            double y;
            if (x <= n)
            {
               y =((Math.Log(Math.Abs(x)) - n));
                textBox3.Text = y.ToString();
            }

            else
            {
                y= ((Math.Cos(x * n)));
                textBox3.Text = y.ToString();
            }
        }
    }
}
