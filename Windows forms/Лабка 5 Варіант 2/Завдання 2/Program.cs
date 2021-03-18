using System;

namespace Завдання_2
{
    class Program
    {
        public static double Suma(int a, int b)
        {

            double S = (b - a) * Math.Sqrt(4 * a + Math.Sin(Math.Sqrt(Math.Pow(a, 3))));
            return S;
        }
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            double S = Suma(3, b) +Suma(a, b);
            Console.WriteLine(S);
        }
    }
}
