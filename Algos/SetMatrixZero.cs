using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class SetMatrixZero
    {
        public static void SetMatrixZeroFunc(int[,] arr)
        {
            int x = arr.GetLength(0);
            int y = arr.GetLength(1);

            bool firstRow = ScanRow(arr, 0);
            bool firstColumn = ScanColumn(arr, 0);

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                if (ScanRow(arr, i) == true)
                {
                    arr[i, 0] = 0;
                }
            }

            for (int i = 1; i < arr.GetLength(1); i++)
            {
                if (ScanColumn(arr, i) == true)
                {
                    arr[0, i] = 0;
                }
            }

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1); j++)
                {
                    if (arr[i, 0] == 0 || arr[0, j] == 0)
                    {
                        arr[i, j] = 0;
                    }
                }
            }

            if (firstRow)
            {
                for (int i = 0; i < arr.GetLength(1); i++)
                {
                    arr[0, i] = 0;
                }
            }

            if (firstColumn)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    arr[i, 0] = 0;
                }
            }
        }

        private static bool ScanRow(int[,] arr, int rowNum)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[rowNum, i] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ScanColumn(int[,] arr, int columnNum)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (arr[i, columnNum] == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
