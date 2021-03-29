using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модульна_контрольна_1.Мацко_Олександр_9_Варіант
{
    class Point2d
    {
        public int[] coor;
        public Point2d()
        {

        }
        public Point2d(int[] coor)
        {
            this.coor = coor;
        }
        public Point2d(Point2d coor)
        {
            this.coor = coor.coor;
        }
        public virtual void input()
        {

            coor = new int[2];
            for (int i = 0; i < coor.Length; i++)
            {
                coor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public virtual void print()
        {
            foreach (int i in coor)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("");
        }
        public virtual void distance(Point2d  t2)
        {
            double AB = Math.Sqrt(Math.Pow(t2.coor[0] - coor[0], 2) + (Math.Pow(t2.coor[1] - coor[1], 2)));
            Console.WriteLine("Відстань від точки до точки = " +AB);
        } 
        public virtual void according(Point2d t2)
        {
            if (coor[0] == t2.coor[0] && coor[1] == t2.coor[1])
            {
                Console.WriteLine("Точки рівні");
            }
            else
            {
                Console.WriteLine("Точки не рівні");
            }
        }
        public static Point2d operator +(Point2d  t1, Point2d t2)
        {
            int[] Sum = new int[2];

            Sum[0] = t1.coor[0] + t2.coor[0];
            Sum[1]= t1.coor[1] + t2.coor[1];
            return new Point2d { coor = Sum };
            
        }
        public   static Point2d operator -(Point2d t1,Point2d t2)
        {
            int[] Sum = new int[2];

            Sum[0] = t2.coor[0] - t1.coor[0];
            Sum[1] = t2.coor[1] - t1.coor[1];
            return new Point2d { coor = Sum };
        }


        
    }
}
