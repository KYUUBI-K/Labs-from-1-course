using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class TAngle
    {
        public int angle;
        public TAngle(int Angle)
        {
            angle = Angle;
        }
        public int increase(int count)
        {
            double S = angle * Math.PI / 180;
            S = S + count;
            angle = (int)(S * 180 / Math.PI);
            return angle;
        }
        public void print()
        {
            Console.WriteLine(angle);
        }
        public int reduce(int count)
        {
            double S = angle * Math.PI / 180;
            S = S - count;
            angle = (int)(S * 180 / Math.PI);
            return angle;
        }
    }
}
