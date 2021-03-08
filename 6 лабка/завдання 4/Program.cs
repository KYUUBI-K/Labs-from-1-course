using System;

namespace завдання_4
{
    class Program
    {
        static double[] Randomarray(int rowCount)
        {
            double[] arr = new double[rowCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < rowCount; i++)
            {

                {
                    arr[i] = rand.Next(-100, 101);

                }

            }
            return arr;
        }
        static void printField(double[] arr)
        {
            Console.Write("  [ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("]\n");
        }

        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] m = Randomarray(n);
            printField(m);
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
            printField(m);

        }


}   }