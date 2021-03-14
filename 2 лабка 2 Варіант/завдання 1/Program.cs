using System;

namespace завдання_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n=");
            double n = Convert.ToDouble(Console.ReadLine());
            double S = 0;           
            for(int i = 1; i <= n; i++)
            {
                S=S+ Math.Log(Math.Abs(Math.Pow(i, n)));
            }
            
        }
    }
}
