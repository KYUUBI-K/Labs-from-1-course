using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабка_5_Варіант_2_Завдання__1_2_3_
{
    class Find_something
    {
        public static double f(int x, int y)
        {
            double g;
            double m;
            if (x > 0 && y > 0)
            {
                g = Math.Pow(x, 3) + Math.Sqrt((Math.Pow(x, 2) + Math.Pow(y, 4)));
                return g;
            }
            else if (x > 0 && y < 0)
            {
                m = (Math.Pow(x, 2) - 2 * x + Math.Sqrt(x)) / Math.Sqrt(Math.Pow(x, 3));
                return m;

            }
            else
            {
                m = Math.Sin(x * y);
                return m;
            }
        }
        public static double S(int a, int b)
        {

            double S = (b - a) * Math.Sqrt(4 * a + Math.Sin(Math.Sqrt(Math.Pow(a, 3))));
            return S;
        }
        public static double g(int n)
        {
            double el=0;
            double[] a = { 9, 35 };
            int i = 2;
            while (i <= n)
            {
                el = Math.Sin(a[i - 1] + Math.Cos(a[i - 2]));

                i++;
            }
                return el;
        }
        public static double get_res(int count)
        {
            double g0 = 9;
            double g1 = 35;
            double gi = 0;
            for (int i = 2; i < count + 1; i++)
            {
                gi = Math.Sin(g0 + Math.Cos(g1));
                g1 = g0;
                g0 = gi;
            }
            return g1;
        }
    }
}
