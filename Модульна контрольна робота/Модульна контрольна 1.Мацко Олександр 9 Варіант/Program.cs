using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модульна_контрольна_1.Мацко_Олександр_9_Варіант
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2d point1 = new Point2d();
            Console.WriteLine("Введіть координати точки ");
            point1.input();
            point1.print();
            Point2d point2 = new Point2d();
            Console.WriteLine("Введіть координати другої точки ");
            point2.input();
            point2.print();
            point1.distance(point2);
            //Квадрант я не встиг бо пізно зрозумів як це робити
            point1.according(point2);
            Point2d S = point1 + point2;
            Point2d subtraction = point2-point1;
            S.print();
            subtraction.print();

            //4 завдання про масив
            int[] massive = {1,2,3,4,5};
            int d = 1;
            for (int i = 0; i < massive.Length; i++)
            {
                d *= massive[i];
            }
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
