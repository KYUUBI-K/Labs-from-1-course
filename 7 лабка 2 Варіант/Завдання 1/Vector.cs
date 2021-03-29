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
            this.n = k;
            this.coor = v;
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

    }
}
