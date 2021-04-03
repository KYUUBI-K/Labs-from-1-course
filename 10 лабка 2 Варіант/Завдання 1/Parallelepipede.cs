using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Parallelepiped : Rectangle
    {

        public int h;
        public Parallelepiped() : base()
        {

        }
        public Parallelepiped(int h, int a, int b) : base(a, b)
        {
            this.h = h;
        }
        public Parallelepiped(Parallelepiped copy) : base(copy)
        {
            this.h = copy.h;
        }
        public override void inp_side()
        {
            base.inp_side();
            int h = Convert.ToInt32(Console.ReadLine());
        }
        public override void print()
        {
            Console.WriteLine($"Сторона AB={a}," + $"Сторона BC={b}," + $"Сторона CD={a}," + $"Сторона AD={b}" + $"Висота = {h}");
        }
        public override int S()
        {
            
            return base.S();
        }
        public override void P()
        {
            base.P();
        }
        public int V()
        {
            
            return S() * h;
        }
    }
}
