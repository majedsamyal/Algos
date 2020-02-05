using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class MaximumSumArray
    {
        public static int GetMaximumSumOfSubArray(int[] arr)
        {
            int max_so_far = 0;
            int max_ending_here = 0;
            int start, end, s = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here = max_ending_here + arr[i];
                if (max_ending_here < 0)
                {
                    s = i + 1;
                    max_ending_here = 0;
                }
                
               else if (max_so_far < max_ending_here)
                {
                    end = i;
                    start = s;
                    max_so_far = max_ending_here;
                }
             
            }

            return max_so_far;
        }
    }
}
