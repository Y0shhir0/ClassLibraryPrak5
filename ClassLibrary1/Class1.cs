using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Zadanie1(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int minElement = matrix[0, 0];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < minElement)
                    {
                        minElement = matrix[i, j];
                    }
                }
            }

            return minElement;
        }

        public static int Zadanie2(int[,] matrix, int row)
        {
            int cols = matrix.GetLength(1);
            int sum = 0;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[row, j] > 0)
                {
                    sum += matrix[row, j];
                }
            }

            return sum;
        }

        public static int[] Zadanie3(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[] zeroCounts = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        count++;
                    }
                }
                zeroCounts[j] = count;
            }

            return zeroCounts;
        }

        public static int[] Zadanie4(int[,] matrix, int row)
        {
            int cols = matrix.GetLength(1);
            int sum = Zadanie2(matrix, row);
            int[] elements = new int[cols];
            int count = 0;

            for (int j = 0; j < cols; j++)
            {
                if (matrix[row, j] > sum)
                {
                    elements[count] = matrix[row, j];
                    count++; 
                }
            }

            Array.Resize(ref elements, count);

            return elements;
        }
    }
}
