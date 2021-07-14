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

            int i = (l - 1);

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

        public int[] MergeSort(int[] arr)
        {
            int[] left;
            int[] right;
            int[] result = new int[arr.Length];

            if (arr.Length <= 1)
            {
                return arr;
            }

            int midPoint = arr.Length / 2;
            left = new int[midPoint];
            if (arr.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                left[i] = arr[i];
            }

            int x = 0;

            for (int i = midPoint; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            //Recursively sort the left array
            left = MergeSort(left);
            //Recursively sort the right array
            right = MergeSort(right);

            // backtrack 
            // merge sub arrays

            result = Merge(left, right);
            return result;
        }

        private int[] Merge(int[] leftArr, int[] rigthArr)
        {
            int resultArrLenght = leftArr.Length + rigthArr.Length;
            var resultArr = new int[resultArrLenght];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < leftArr.Length || indexRight < rigthArr.Length)
            {
                if (indexLeft < leftArr.Length && indexRight < rigthArr.Length)
                {
                    if (leftArr[indexLeft] < rigthArr[indexRight])
                    {
                        resultArr[indexResult] = leftArr[indexLeft];
                        indexResult++;
                        indexLeft++;
                    }
                    else
                    {
                        resultArr[indexResult] = rigthArr[indexRight];
                        indexResult++;
                        indexRight++;
                    }
                }
                else if (indexLeft < leftArr.Length)
                {
                    resultArr[indexResult] = leftArr[indexLeft];
                    indexResult++;
                    indexLeft++;
                }
                else if (indexRight < rigthArr.Length)
                {
                    resultArr[indexResult] = rigthArr[indexRight];
                    indexResult++;
                    indexRight++;
                }
            }
            return resultArr;
        }
    }
}
