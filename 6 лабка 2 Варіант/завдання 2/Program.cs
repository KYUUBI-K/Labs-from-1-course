using System;

namespace завдання_2
{
    class Program
    {
        static double[] array(int rowCount)
        {
            double[] b=new double[rowCount];
            double factorial = 1;
            for (int i = 1; i < rowCount; i++)
            {
                
                if (i % 2 == 0)
                {
                    b[i-1] = 1.0 / i;
                }
                else
                {
                    factorial = factorial * i;
                    b[i - 1] = factorial / (2.0 + 3.0);
                }
            }
            return b;
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
            double[] B = array(n);
            printField(B);
            double d = 1.0; 
            for (int i =0; i  < B.Length; i++)
            {
                if(i%2!=0)
                {
                    d = d * B[i];
                }    
            }
            Console.WriteLine($"d={d}");
          
        }
    }
}
