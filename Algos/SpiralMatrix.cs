using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public static class SpiralMatrix
    {
        public static int[,] ReturnSpiralMatrix(int n)
        {
            int minRow = 0;
            int maxRow = n - 1;
            int minCol = 0;
            int maxCol = n - 1;
            int value = 1;
            int[,] arr = new int[n, n];


            while (value <= n * n)
            {
                for (int i = minCol; i <= maxCol; i++)
                {
                    arr[minRow, i] = value;
                    value++;
                }

                for (int i = minRow + 1; i <= maxRow; i++)
                {
                    arr[i, maxCol] = value;
                    value++;
                }

                for (int i = maxCol - 1; i >= minCol; i--)
                {
                    arr[maxRow, i] = value;
                    value++;
                }

                for (int i = maxRow - 1; i >= minRow + 1; i--)
                {
                    arr[i, minCol] = value;
                    value++;
                }

                minCol++;
                minRow++;
                maxRow--;
                maxCol--;
            }

            return arr;
        }
    }
}
