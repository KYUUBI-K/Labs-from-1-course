using System;

namespace _1_завдання
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вводимо сторону AB
            Console.Write("AB=");
            //Вводимо сторону BC
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("BC=");
            int b = Convert.ToInt32(Console.ReadLine());
            //Вводимо сторону AC
            Console.Write("AC=");
            int c = Convert.ToInt32(Console.ReadLine());
            //Знаходимо півпириметр
            int p = (a + b + c) / 2;
            Console.WriteLine("p={0}", p);
            //Знаходимо площу
            double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("S={0}", S);
        }
    }
}
