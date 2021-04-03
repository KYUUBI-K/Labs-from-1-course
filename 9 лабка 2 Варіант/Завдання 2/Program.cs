using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
            TAngle k = new TAngle(60);
            Console.Write("На скільки збільшити радіан збільшити: ");
            int n = Convert.ToInt32(Console.ReadLine());
            k.increase(n);
            k.print();
            Console.Write("На скільки збільшити радіан зменшити: ");
             n = Convert.ToInt32(Console.ReadLine());
            k.reduce(n);
            k.print();
            Console.ReadKey();
        }
    }
}
