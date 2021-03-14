using System;

namespace Завдання_3
{
    class zavd3
    {
        static void Main(string[] args)
        {
            //Вводимо координати т.А
            Console.Write("x1=");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1=");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2=");
            //Вводимо координати т.B
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2=");
            double y2 = Convert.ToDouble(Console.ReadLine());
            //Вводимо координати т.C
            Console.Write("x3=");
            double x3= Convert.ToDouble(Console.ReadLine());
            Console.Write("y3=");
            double y3 = Convert.ToDouble(Console.ReadLine());
            double ab = (x2 - x1) * (x3 - x2) + (y2 - y1) * (y3 - y2);
            double ac = (x2 - x1) * (x3 - x1) + (y2 - y1) * (y3 - y1);
            double bc = (x3 - x2) * (x3 - x1) + (y3 - y2) * (y3 - y1);
            double eps = 0.000001; //Добавляємо якесь епсілон
            if ((ab) < eps)
                Console.WriteLine("Трикутник прямокутний");
            else if ((ac) < eps)
                Console.WriteLine("Трикутник прямокутний");

            else if ((bc) < eps)
                Console.WriteLine("Трикутник прямокутний");

            else
                Console.WriteLine("Трикутник не прямокутний");


        }
    }
}
