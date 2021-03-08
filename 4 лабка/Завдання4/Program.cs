using System;

namespace Завдання4
{
    class Завдання4
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            int x  = Convert.ToInt32(Console.ReadLine());
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            if (x <= n)
                Console.WriteLine((Math.Log(Math.Abs(x)) - n));
            else
                Console.WriteLine((Math.Cos(x * n))); 

        }
    }
}
