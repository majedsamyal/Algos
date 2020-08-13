using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class LargestNonNegativeSubArray
    {
        // {2, 3, 4, -1, -2, 1, 5, 6, 3}
        public static int Length(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;

                while (i < arr.Length && arr[i] >= 0)
                {
                    counter++;
                    i++;
                }
            }
            return counter;
        }

        // [1, 2, 5, -7, 2, 3]
        public static int Sum(int[] arr)
        {
            int current_sum = 0;
            int max_sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                current_sum = 0;

                while (i < arr.Length && arr[i] >= 0)
                {
                    current_sum = current_sum + arr[i];
                    i++;
                }
                max_sum = Math.Max(max_sum, current_sum);
            }
            return max_sum;
        }
    }
}
