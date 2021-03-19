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
            double[] massive;
            for (int i = 0; i < n+1; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(j%2==0 && j > 0)
                    {
                        double sum = 0;
                        sum += arr[i,j];
                        Console.WriteLine(sum);

                    }
                    
                }
            }
        }
    }
}
