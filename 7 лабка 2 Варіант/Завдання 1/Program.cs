using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector a = new Vector(3);
            a.input();
            a.print();
            int S = a.length();
            // У мене не вийшло нормувати вектор
            
           foreach (int i in S)
                {
                    Console.Write($"{i} ");
                }
            
            Console.ReadKey();
        }
    }
}
