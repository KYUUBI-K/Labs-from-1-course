using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабка_3_Варіант_2_завдання__1_2_3_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txb_n.Text);
            
            dataGridView1.ColumnCount = n;
            
            double[] m = Create_array.Randomarray(n);
            for (int i = 0; i <n; i++)
            {
                dataGridView1[i,0].Value = m[i];
            }
            double d = 1;
            double g = 1.0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                d *= m[i];


            }
            tbx_d.Text = d.ToString();
            if (d > 0)
            {
                g = Math.Pow(d, 1.0 / n);
                txb_g.Text = g.ToString();
            }
            else
            {
                txb_g.Text = "Середнього геометричного немає, оскільки добуток від'ємний";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textbox_n.Text);
            double[] B = Create_array.array(n);
            dataGridView2.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView2[i, 0].Value = B[i];
            }
            double d = 1.0;
            for (int i = 0; i < B.Length; i++)
            {
                if (i % 2 != 0)
                {
                    d = d * B[i];
                }
            }
            dobutok.Text = d.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textb_n.Text);
            int a = Convert.ToInt32(textb_a.Text);
            double[] x = Create_array.Randomarray(n);
            dataGridView3.ColumnCount = n;
            dataGridView4.ColumnCount = n;

            for (int i = 0; i < n; i++)
            {
                dataGridView3[i, 0].Value = x[i];
            }

            for (int i = 0; i < x.GetLength(0); i++)
            {
                x[i] *= a;
            }
            for (int i = 0; i < n; i++)
            {
                dataGridView4[i, 0].Value = x[i];
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBo_n.Text);
            double[] m = Create_array.Randomarray(n);
            dataGridView5.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView5[i, 0].Value = m[i];
            }

            double k;
            for (int i = 0; i < m.Length - 1; i++)
            {
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (m[i] > m[j])
                    {
                        k = m[i];
                        m[i] = m[j];
                        m[j] = k;
                    }
                }
            }
            dataGridView6.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView6[i, 0].Value = m[i];
            }
        }
    }
}
