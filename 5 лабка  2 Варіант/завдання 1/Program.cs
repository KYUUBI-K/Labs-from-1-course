using System;

namespace завдання_1
{
    class Program
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
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            double u =f(a, b) + f(2, a) + 2;
            Console.WriteLine(u);
        }
    }
    
}
