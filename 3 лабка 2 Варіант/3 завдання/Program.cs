using System;

namespace завдання3
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
            Console.Write("Вимір вектора =");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] x = Randomarray(n);
            printField(x);
            Console.Write("a =");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <x.GetLength(0); i++)
            {
                x[i] *= a;
            }
            printField(x);

        }
           
        }

            
               
    }      
