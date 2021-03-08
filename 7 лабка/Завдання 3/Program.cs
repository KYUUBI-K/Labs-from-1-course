using System;

namespace Завдання_3
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
        static double[] Randomarray(int rowCount)
        {
            double[] arr = new double[rowCount];
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < rowCount; i++)
            {

                {
                    arr[i] = rand.Next(-100, 101);

                }

            }
            return arr;
        }
        static void printField(double[] arr)
        {
            Console.Write("  [ ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("]\n");
        }
            static void Main(string[] args)
        {
            //1. Вводимо кількість рядків і кількість стовпців
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Вимір вектора=");
            int v = Convert.ToInt32(Console.ReadLine());
            double[] x = Randomarray(v);
            printField(x);
            //2. Виділяємо пам"ять  i вводимо елементи масиву або геренуємо їх
            double[,] a = inputArray(n, m, true);
            //4. Виконуємо операції з масивом
            //Вивід матриці на екран
            printArray(a);
            
            for (int i = 0; i < n; i++)
            {
                for (int g = 0; g < m; g++)
                {
                    for (int j = 0; j < v; j++)
                    {
                    a[i,j] = a[i, j] * x[j];
                    }

                }
            }
            Console.WriteLine("------------");
            printArray(a);
            double[] xa;
            for (int i = 0; i < n; i++)
            {
                xa = 
            }
           
                
        }
    }
}
