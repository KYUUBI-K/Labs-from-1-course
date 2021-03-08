using System;

namespace Завдання_1
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
            double[]m = Randomarray(n);
            printField(m);
            double d = 1;
            double g = 0;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                d *=m[i];


            }
            Console.WriteLine($"Добуток = {d}");
            if(d>0)
            {
                g = Math.Pow(d, 1 / n);
            }
            Console.WriteLine($"g={g}");







        }
    }
}
