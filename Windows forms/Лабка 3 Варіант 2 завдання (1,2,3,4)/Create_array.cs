using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабка_3_Варіант_2_завдання__1_2_3_4_
{
    class Create_array
    {
        public int n;
        public Create_array(int n)
        {
            this.n = n;
        }
        public static double[] Randomarray(int rowCount)
        {
            double[] arr = new double[rowCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < rowCount; i++)
            {

                {
                    arr[i] = rand.Next(-10, 101);

                }

            }
            return arr;
        }
        public static double[] array(int rowCount)
        {
            double[] b = new double[rowCount];
            double factorial = 1;
            for (int i = 1; i < rowCount; i++)
            {

                if (i % 2 == 0)
                {
                    b[i - 1] = 1.0 / i;
                }
                else
                {
                    factorial = factorial * i;
                    b[i - 1] = factorial / (2.0 + 3.0);
                }
            }
            return b;




        }

    }
}
