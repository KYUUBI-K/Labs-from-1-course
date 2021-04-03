using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1

{
    class Rectangle:IComparable
    {
        public int a;
        public int b;
        
        
        public Rectangle()
        {
        }
        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public Rectangle(Rectangle copy)
        {
            this.a = copy.a;
            this.b = copy.b;
        }
        public void inp_side()
        {
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
        }
        public void print()
        {
            Console.WriteLine($"Сторона AB={a}," + $"Сторона BC={b}," + $"Сторона CD={a}," + $"Сторона AD={b}");
        }
        public int S()
        {
           return a * b;
        }
        public void P()
        {
            Console.WriteLine($"Периметр = {(a + b) * 2}");
        }


        public int CompareTo(object other)
        {
            if(this.S() > (other as Rectangle).S())
            {
                return 1;
            }
            if (this.S() < (other as Rectangle).S())
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static Rectangle operator +(Rectangle t1)
        {
            Console.Write("");
            Rectangle Suma_a = new Rectangle();
            
            Suma_a.a = t1.a+t1.b;
            return new Rectangle { a = Suma_a.a };
        }
        public static Rectangle operator -(Rectangle t1)
        {
            Console.Write("");
            Rectangle subtraction = new Rectangle();
            if (t1.a > t1.b)
            {
                subtraction.a = t1.a - t1.b;
            }
            else
            {
                subtraction.a = t1.b - t1.a;
            }
            return new Rectangle { a = subtraction.a };
        }
        public static Rectangle operator *(Rectangle t1,Rectangle t2)
        {
          
            Rectangle D = new Rectangle();

            D.a = t1.a * t1.b;
            return new Rectangle { a = D.a };
        }

    }
}
