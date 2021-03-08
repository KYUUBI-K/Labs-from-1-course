using System;

namespace Завдання_2
{
    class Program
    {
        static double[,] inputArray(int rowCount, int colCount, bool randomMode = false, int minRandValue = -10, int maxRandValue = 11)
        {
            //2. Виділяємо пам"ять для масиву
            double[,] arr = new double[rowCount, colCount];
            //3. Вводимо елементи масиву або геренуємо їх
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    if (randomMode)
                        arr[i, j] = rand.Next(minRandValue, maxRandValue);
                    else
                    {
                        Console.Write($"a[{i},{j}]=");
                        arr[i, j] = Convert.ToDouble(Console.ReadLine());
                    }
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
            //1. Вводимо кількість рядків і кількість стовпців
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            //2. Виділяємо пам"ять  i вводимо елементи масиву або геренуємо їх
            double[,] A = inputArray(n, m, true);
            double[,] B = inputArray(n, m, true);
            //4. Виконуємо операції з масивом
            //Вивід матриці на екран
            Console.WriteLine("Матриця А");
            printArray(A);
            Console.WriteLine("Матриця B");
            printArray(B);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (A[i, j] == 0)
                    {
                        A[i, j] = B[i, j];
                    }

                }
            }
            Console.WriteLine("Матриця А із замінами");
            printArray(A);
        }   
    }
}
