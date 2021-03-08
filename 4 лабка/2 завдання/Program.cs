using System;

namespace _2_завдання
{
    class zavd2
    {
        static void Main(string[] args)
        {
            //Вводимо дійсні числа
            Console.Write("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d=");
            double d = Convert.ToDouble(Console.ReadLine());
            // Перевіряємо чи належить
            if (1<=a && a<=2 && a>=c && a<=d)
                Console.WriteLine("a належить інтеравалу");
            else
                Console.WriteLine("a не належить інтервалу");
            if (1 <= b && b <= 2 && b >= c && b <= d)
                Console.WriteLine("b належить інтеравалу");
            else
                Console.WriteLine("b не належить інтервалу");
            if (1 <= c && c <= 2 && c >= c && c <= d)
                Console.WriteLine("c належить інтеравалу");
            else
                Console.WriteLine("c не належить інтервалу");
            if (1 <= d && d <= 2 && d >= c && d <= d)
                Console.WriteLine("d належить інтеравалу");
            else
                Console.WriteLine("d не належить інтервалу");



        }
    }
}
