using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Sorting
{
    public class Sort
    {
        public void QuickSort(int[] arr, int l, int h)
        {
            // check if there are more than one element in array
            if (l < h)
            {
                int pivot = PartitionQuick(arr, l, h);
                QuickSort(arr, l, pivot - 1);
                QuickSort(arr, pivot + 1, h);
            }
        }

        private int PartitionQuick(int[] arr, int l, int h)
        {
            int pivot = arr[h];

            int i = (l-1);

            for (int j = l; j < h; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    // swap i with j
                    var temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap pivot 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[h];
            arr[h] = temp1;
            return i + 1;
        }

        public void MergeSort(int[] a)
        {
            int n = a.Length;
            if (n < 2)
            {
                return;
            }
            // left array
            // right 

            // backtrack 
            // merge sub arrays
        }
    }
}
