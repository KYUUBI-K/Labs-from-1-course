using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Vector
    {
        public  int n { get; set; }
        public int[] coor { get; set;}
        public Vector(int k ,int[] v)
        {
            n = k;
            coor = v;
        }
        public Vector(int k):this(k,null)
        {
            
        }
        public Vector()
        {
        }
        public void input()
        {
            
             coor = new int[n];
            for (int i = 0; i <coor.Length; i++)
            {
                 coor[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }

        public void print()
        {
            foreach (int i in coor)
            {
                Console.Write($"{i} ");
            }
        }
         public int length()
        {
            int  l_a = 0;
            for (int i = 0; i < coor.Length; i++)
            {
                l_a =(int)(Math.Sqrt(coor[i] * 2));

            }
            return l_a;
        }
        public int norm_v(int length)
        {
            int el = 0;
            for (int i = 0; i < n; i++)
            {
                el = (coor[i] / length);

            }
            return el;
        }

    }
}
