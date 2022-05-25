using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class BinarySearch
    {
        public int Find(int[] arr, int num)
        {
            // 4 6 8 9 10 15 20
            // find 10
            return Search(arr, 0, arr.Length -1, num);
        }

        private int Search(int[] arr, int left, int right, int num)
        {
            if (left > right) 
            {
                // element not found
                return -1;
            }

            int mid = (left + right) / 2;

            if (arr[mid] == num)
            {
                return mid;
            }

            if (num < arr[mid])
            {
                return Search(arr, left, mid - 1, num);
            }

            return Search(arr,  mid + 1, right, num);
            
        }
    }
}
