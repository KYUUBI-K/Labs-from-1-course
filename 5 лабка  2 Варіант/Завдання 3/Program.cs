using System;

namespace Завдання_3
{
    class Program
    {

        static double get_res(int count)
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
        static void Main(string[] args)
        {
            double S = get_res(7) + get_res(9);
            Console.WriteLine(S);
        }




       
    }
}
