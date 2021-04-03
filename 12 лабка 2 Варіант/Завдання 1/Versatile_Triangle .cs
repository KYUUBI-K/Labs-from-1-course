using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Versatile_Triangle:Triangle,ITry
    {
        public Versatile_Triangle(int a,int b,int c) : base(a, b, c)
        {

        }
        public int P()
        {
            return a + b + c;
        }
        public int p()
        {
            return (a + b + c) / 2;
        }
        public int S()
        {
            return (int)(Math.Sqrt(p() * (p() - a)*(p()-b)*(p()-c)));
        }
        public int r()
        {
            return (int)(2 * S()) / p();
        }
        public int R()
        {
            return (int)(4 * S()) / a*b*c;
        }
    }
}
