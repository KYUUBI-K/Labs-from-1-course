using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лабораторна_15_Варіант_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void drawFunction(double a, double b, Func<double, double> f, int pointsCount = 10)
        {
            chart1.Series[0].Points.Clear();
            double h = (b - a) / pointsCount;
            double x = a;
            while (x <= b)
            {
                chart1.Series[0].Points.AddXY(x, f(x));
                x += h;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 10;
            drawFunction(a, b, (x)=> Math.Sqrt(x)* Math.Pow(Math.Cos(x), 2));
           
        }
    }
}
