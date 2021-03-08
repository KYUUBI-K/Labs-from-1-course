using System;

namespace завдання3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x=");
            double x = Convert.ToDouble(Console.ReadLine());
            int a = 1;
            double s = 0;
            double eps = 0.000001;
            while ((Math.Abs((Math.Pow(x, a))) / a) > eps)
            {
                s = s - (Math.Abs((Math.Pow(x, a))) / a);
                a++;
            }
            Console.WriteLine("s={0}",s);
            if ((Math.Log(1 - x) - s) < eps)
               Console.WriteLine("Справедлива");
            else
                    Console.WriteLine("Не справедлива");
            





        }
           

    }
}
