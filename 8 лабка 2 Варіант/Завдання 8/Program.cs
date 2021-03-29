using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle ABCD = new Rectangle();
            Rectangle ABCD_1 = new Rectangle();
            ABCD.inp_side();
            ABCD.print();
            ABCD_1.S();
            ABCD.P();
            ABCD_1.inp_side();
            ABCD_1.print();
            ABCD_1.S();
            ABCD_1.P();
            switch (ABCD.CompareTo(ABCD_1))
            {
                case -1: Console.WriteLine("ABCD менший ніж ABCD_1 ");
                    break;
                case 0:
                    Console.WriteLine("Прямокутники рівні");
                    break;
                case 1:
                    Console.WriteLine("ABCD Більший ніж ABCD_1 ");
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
