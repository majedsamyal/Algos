using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Array
{
    public class ArrayProblem
    {
        // int[] arr = {4,4,3,2,1}

        public static int MinDeleteOpertions(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            
            // insert keys with frequency count
            foreach (var item in arr)
            {
                if (frequency.ContainsKey(item))
                {
                    frequency[item] = frequency[item] + 1;
                }
                else
                {
                    frequency.Add(item, 1);
                }
            }

            // get max frequency
            int maxFreq = int.MinValue;
            foreach (var item in frequency)
            {
                maxFreq = Math.Max(maxFreq, frequency[item.Key]);
            }

            return arr.Length - maxFreq;
        }
    }
}
