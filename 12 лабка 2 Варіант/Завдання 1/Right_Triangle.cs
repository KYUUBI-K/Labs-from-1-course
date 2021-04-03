using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Right_Triangle:Triangle, ITry
    {
        public  Right_Triangle(int a, int b, int c) : base(a, b, c)
        {

        }
        public  int P()
        {
            return a + b + c;
        }
        public int S()
        {
            return (a * b) / 2;
        }
        public int r()
        {
            return (a + b - c) / 2;
        }
        public int R()
        {
            return c / 2;
        }
      

            
                
            
    }
    
}
