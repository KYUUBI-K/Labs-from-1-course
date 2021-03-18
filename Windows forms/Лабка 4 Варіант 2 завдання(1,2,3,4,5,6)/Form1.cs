using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабка_4_Варіант_2_завдання_1_2_3_4_5_6_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(tbx_n.Text);
            int m = Convert.ToInt32(tbx_m.Text);
            double[,] arr = Create_arr.inputArray(n, m);
            double sum = Create_arr.getSumPositive(arr);
            S.Text = sum.ToString();
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1[j,i].Value= arr[i,j];
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox_n.Text);
            int m = Convert.ToInt32(textBox_m.Text);
            double[,] A = Create_arr.inputArray(n, m);
            double[,] B = Create_arr.inputArray1(n, m);
            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView2[j, i].Value = A[i, j];
                }
            }
            dataGridView3.RowCount = n;
            dataGridView3.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView3[j, i].Value = B[i, j];
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] == 0)
                    {
                        A[i, j] = B[i, j];
                    }

                }
            }
            dataGridView4.RowCount = n;
            dataGridView4.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView4[j, i].Value = A[i, j];
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(N_col.Text);
            int m = Convert.ToInt32(M_row.Text);
            double[,] a = Create_arr.inputArray(n, m);
            dataGridView5.RowCount = n;
            dataGridView5.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView5[j, i].Value = a[i, j];
                }
            }
            double[] x = Create_arr.Randomarray(n);
            dataGridView7.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView7[i, 0].Value = x[i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)

                {
                    a[i, j] = a[i, j] * x[j];
                }
            }
            double[] xa = new double[n];
            for (int i = 0; i < n; i++)
            {
                xa[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    xa[i] += a[i, j];
                }
            }
            dataGridView6.ColumnCount = n;
            for (int i = 0; i < n; i++)
            {
                dataGridView6[i,0].Value = xa[i];
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(col.Text);
            int m = Convert.ToInt32(row.Text);
            double[,] arr = Create_arr.inputArray(n, m);
            dataGridView8.RowCount = n;
            dataGridView8.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView8[j, i].Value = arr[i, j];
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i % 2 != 0)
                {
                    for (int iter = 1; iter < arr.GetLength(1); iter++)
                    {
                        for (int col = 0; col < arr.GetLength(1) - iter; col++)
                        {

                            if (arr[i, col] > arr[i, col + 1])
                            {
                                double temp = arr[i, col];
                                arr[i, col] = arr[i, col + 1];
                                arr[i, col + 1] = temp;

                            }
                        }
                    }
                }
            }
            dataGridView9.RowCount = n;
            dataGridView9.ColumnCount = m;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView9[j, i].Value = arr[i, j];
                }
            }
        }
    }
}
