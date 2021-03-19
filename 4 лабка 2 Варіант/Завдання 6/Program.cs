using System;

namespace Завдання_6
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
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("m=");
            int m = Convert.ToInt32(Console.ReadLine());
            double[,] arr = inputArray(n, m);
            printArray(arr);
            double[] massive = new double[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                massive[i] = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] % 2 == 0 && arr[i, j] > 0)
                    {
                        massive[i] += arr[i, j];
                    }
                }
            }
                foreach (int k in massive)
                {
                    Console.WriteLine(k);
                }
            double g;
            for (int i = 0; i < massive.Length - 1; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        g = massive[i];
                        massive[i] = massive[j];
                        massive[j] = g;
                        for (int count = 0; count < arr.GetLength(0); count++)
                        {
                            g = arr[i, count];
                            arr[i, count] = arr[j, count];
                            arr[j, count] = g;
                        }

                    }
                }
            }
            Console.WriteLine("--------");
            foreach (int k in massive)
            {
                Console.WriteLine(k);
            }
            printArray(arr);
        }
    }
}
