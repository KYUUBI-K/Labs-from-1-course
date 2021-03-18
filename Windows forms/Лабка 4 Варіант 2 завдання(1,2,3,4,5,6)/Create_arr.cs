using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лабка_4_Варіант_2_завдання_1_2_3_4_5_6_
{
    class Create_arr
    {
        public static double[,] inputArray(int rowCount, int colCount, int minRandValue = -10, int maxRandValue = 11)
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
        public static double[,] inputArray1(int rowCount, int colCount, int minRandValue = -10, int maxRandValue = 11)
        {
            //2. Виділяємо пам"ять для масиву
            double[,] arr = new double[rowCount, colCount];
            //3. Вводимо елементи масиву або геренуємо їх
            Random rand = new Random(DateTime.Now.Second);
            for (int i = 0; i < arr.GetLength(0); i++) //Як змінюються номери рядків
            {
                for (int j = 0; j < arr.GetLength(1); j++) //Як змінюються номери стовпців
                {
                    arr[i, j] = rand.Next(minRandValue, maxRandValue);
                }
            }
            return arr;
        }
            public static double getSumPositive(double[,] arr)
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
        public static double[] Randomarray(int rowCount)
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

    }
}           
