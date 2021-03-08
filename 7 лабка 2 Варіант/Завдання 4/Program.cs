using System;

namespace Завдання_4
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
        static double getSumPositive(double[,] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(0); i = i + 2) //Як змінюються номери рядків
            {
                for (int j = 1; j < arr.GetLength(1); j = j + 2) //Як змінюються номери стовпців
                {
                    if (arr[i, j] > 0)
                        sum += arr[i, j];
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //1. Вводимо кількість рядків і кількість стовпців
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            //2. Виділяємо пам"ять  i вводимо елементи масиву або геренуємо їх
            double[,] arr = inputArray(n, m, true);
            //4. Виконуємо операції з масивом
            //Вивід матриці на екран
            printArray(arr);
            for (int i = 0; i < n; i++)
            {
                if (i%10!=0)
                {
                    for (int col = 0; col < n; col++)
                    {
                        for (int iter = 1; iter < m; iter++)
                        {
                            for (int row = 0; row < m; row++)
                            {
                                if (arr[row+1,col]<arr[row,col])
                                {
                                    double temp = arr[row, col];
                                    arr[row, col] = arr[row + 1,col];
                                    arr[row + 1, col] = temp;

                                }
                            }
                        }
                    }
                }
            }
            printArray(arr);

        }

            
        
    }
}
