﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Array
{
    public class ArrayProblem
    {
        // int[] arr = {4,4,3,2,1}

        public static int MinDeleteOpertionsUsingHash(int[] arr)
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

        public static void PrintArrayFrequency(int[] arr, int n)
        {
            //  { 2, 3, 3, 2, 5 }
            // decreament all the elements in array by 1 
            for (int i = 0; i < n; i++)
            {
                arr[i] = arr[i] - 1;
            }

            // use every element as an index of array 

            for (int i = 0; i < n; i++)
            {
                arr[arr[i] % n] = arr[arr[i] % n] + n;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + "-->" + arr[i] / n);
            }
        }

        public static void PrintMostFrequentSortedArray(int[] arr)
        {

        }

        public static void PrintMostFrequentUnSortedArrayWithHashing(int[] arr)
        {

        }

        public static int MaxSubArraySum(int[] arr)
        {
            int max_Sum = int.MinValue;
            int max_ending_here = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                max_ending_here = max_ending_here + arr[i];

                if (max_Sum < max_ending_here)
                {
                    max_Sum = max_ending_here;
                }

                if (max_ending_here < 0)
                {
                    max_ending_here = 0;
                }
            }

            return max_Sum;
        }

        public static int[] Segregate012InArray(int[] arr)
        {
            int low = 0, mid = 0, high = arr.Length - 1;

            while (mid <= high)
            {
                switch (arr[mid])
                {
                    case 0:
                        //swap low, mid
                        var temp = arr[low];
                        arr[low] = arr[mid];
                        arr[mid] = temp;
                        low++;
                        mid++;
                        break;
                    case 1:
                        mid++;
                        break;
                    case 2:
                        // swap high, mid
                        var temp1 = arr[high];
                        arr[high] = arr[mid];
                        arr[mid] = temp1;
                        mid++;
                        high--;
                        break;
                }
            }

            return arr;
        }
    }
}
