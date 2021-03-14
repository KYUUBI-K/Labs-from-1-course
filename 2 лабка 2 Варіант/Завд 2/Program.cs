using System;

namespace Завд_2
{
    class Program
    {
        static void Main(string[] args)
        {   //Вводимо число

            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int f = 0;
            //Знаходимо кількість нулів
            while (n > 0)
            {

                f = n % 10;
                if (f == 0)
                    count += 1;
                n /= 10;
            }
            
             
            Console.WriteLine(count);
        



        }
    }
}
