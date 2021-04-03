using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Isosceles_Triangle:Triangle,ITry
    {
        public Isosceles_Triangle(int a, int b, int c) : base(a, b, c)
        {

        }
        public int P()
        {
            return a + b + c;
        }
       
        public int S()
        {
            return (int)((b * Math.Sqrt(Math.Pow(a, 2) - (Math.Pow(b, 2) / 4)))/2);
        }
        public int r()
        {
            return (int)((b / 2) * Math.Sqrt((2 * a - b) / 2 * a + b));
        }
        public int R()
        {
            return (int)(Math.Pow(a, 2) / Math.Sqrt(4 * Math.Pow(a, 2)) - Math.Pow(b, 2));
        }

    }
}
