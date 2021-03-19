using System;

namespace Завдання_5
{
    class Program
    {
        static double[,] inputArray(int rowCount, int colCount, int minRandValue = -10, int maxRandValue = 11)
        {
            //2. Виділяємо пам"ять для масиву
            double[,] arr = new double[rowCount, colCount];
            //3. Вводимо елементи масиву або геренуємо їх
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {

                    arr[i, j] = rand.Next(minRandValue, maxRandValue);
                }
            }
            return arr;
        }
        static void printArray(double[,] arr)
        {
            //Вивід матриці на екран
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    Console.Write("{0,8:f}  ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            double[,] a = inputArray(n, m);
            printArray(a);
            int count = 0;
            for (int j = 0; j < n ; j++)
            {
                bool is_zero = false;
                for (int i = 0; i < m; i++)
                {
                    if (a[i, j]==0)
                    {
                        is_zero = true;
                        break;
                    }
                }
                    if (is_zero == false)
                    {
                        count ++;
                    }
            }
            Console.WriteLine(count);
        }


    }
}
