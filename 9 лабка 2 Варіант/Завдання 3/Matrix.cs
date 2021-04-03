using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_3
{
    class Matrix
    {
        public int[,] matrix
        {
            get
            {
                return matrix;
            }

            set
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (i > 100 && j > 100)

                            throw new Exception("Елементи більше за 100");

                    }
                }
            }
        }
        public Matrix()
        {
            
        }
        public int[,] inputArray(int rowCount, int colCount,  int minRandValue = -10, int maxRandValue = 100)
        {
         
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                     
                    {
                        Console.Write($"a[{i},{j}]=");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
            return matrix;
        }
        public void printArray()
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    Console.Write("{0,8:f}  ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        public void max()
        {
            int max_value = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > max_value)
                    {
                        max_value = matrix[i, j];
                    }
                }
            }
            Console.WriteLine(max_value);
        }
        public void min()
        {
            int min_value = matrix[0, 0];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min_value)
                    {
                        min_value = matrix[i, j];
                    }
                }
            }
            Console.WriteLine(min_value);
        }
    }
}
                
