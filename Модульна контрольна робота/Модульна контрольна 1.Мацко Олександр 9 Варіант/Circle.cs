using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Модульна_контрольна_1.Мацко_Олександр_9_Варіант
{
    class Circle : Point2d
    {
        public int[] centre_t;
        public int r = 2;
        public Circle() : base()
        {

        }
        public Circle(int[] centre_t, int[] coor) : base(coor)
        {
            this.centre_t = centre_t;
        }
        public Circle(Circle centre_t, Circle coor) : base(coor)
        {
            this.centre_t = centre_t.centre_t;
        }
        public override void input()
        {

            centre_t = new int[2];
            for (int i = 0; i < centre_t.Length; i++)
            {
                coor[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public override void print()
        {
            foreach (int i in centre_t)
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("");
        }
        public override void distance(Point2d t2)
        {
            double AB = Math.Sqrt(Math.Pow(t2.coor[0] - coor[0], 2) + (Math.Pow(t2.coor[1] - coor[1], 2))) - r - r;
            Console.WriteLine("Відстань від кола до кола  = " + AB);
        }
        public override void according(Point2d t2)
        {
            if (r==r)
            {
                Console.WriteLine("кола рівні рівні");
            }
            else
            {
                Console.WriteLine("кола  не рівні");
            }

        }
    }
}
