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
        public partial class Form1 : Form
        {

            public Form1()
            {
                InitializeComponent();
            this.form2 = new Form2(this);
            }
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2.Show();
        }
        Form2 form2;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form2 = new Form3();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form2 = new Form4();
            form2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form2 = new Form5();
            form2.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
