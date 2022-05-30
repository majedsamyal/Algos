using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class QuickSortAlgo
    {
        // 3,1,11,7,15,9
        public int[] QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pos = FindPosition(arr, left, right);
                QuickSort(arr, left, pos - 1);
                QuickSort(arr, pos + 1, right);
            }
            return arr;
        }

        private int FindPosition(int[] arr, int left, int right)
        {
            int pivot = arr[right];

            int i = left - 1;
            int j;

            for (j = left; j < right; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    var temp1 = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp1;
                }
            }

            var temp = arr[i + 1];
            arr[i + 1] = pivot;
            arr[right] = temp;
            return  i +1;
        }
    }
}
