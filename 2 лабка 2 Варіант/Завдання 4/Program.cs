using System;

namespace Завдання_4
{
    class Program
    {
        static void Main(string[] args)
        {   // Вводимо n
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int x0 = 1;
            int x1 = 1;
            int xi = 0;
            // знаходи xi
            for (int i = 2; i < n+1; i++)
            {
                xi = x1 + 2 * x0;
                x1 = xi;
                x0 = x1;
            }
            Console.WriteLine($"xi={xi}");



               

            
        }
    }
}
