using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Equilateral_Triangle:Triangle,ITry
    {
        public Equilateral_Triangle(int a, int b, int c):base(a,b,c)
        {
       
        }
        public int P()
        {
            return a + b + c;
        }
        public int S()
        {
            return (int)(Math.Pow(a,2)*Math.Sqrt(3)/4);
        }
        public int r()
        {
            return (int)(a/2*Math.Sqrt(3));
        }
        public int R()
        {
            return (int)(a / Math.Sqrt(3));
        }
    }
}
