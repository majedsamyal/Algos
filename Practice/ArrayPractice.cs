using System;
using System.Collections.Generic;
using System.Text;

namespace Practice
{
    public class ArrayPractice
    {
        public int[] SortArray012(int[] arr, int len)
        {
            int start = 0, mid = 0;
            int end = len - 1;

            int pivot = 1;

            while (mid <= end)
            {
                if (arr[mid] > pivot)
                {
                    // swap end with mid 
                    int temp = arr[mid];
                    arr[mid] = arr[end];
                    arr[end] = temp;
                    end--;
                }
                else if (arr[mid] < pivot)
                {
                    // swap start with mid
                    int temp = arr[mid];
                    arr[mid] = arr[start];
                    arr[start] = temp;
                    start++;
                    mid++;
                }
                else
                {
                    mid++;
                }
            }

            return arr;
        }

        public void PrintSpiralOrderMatrix(int[,] matrix, int row, int col)
        {
            // left/top     1    2   3   4  right
            //              5    6   7   8
            //              9   10  11  12
            // bottom       13  14  15  16

            // output 1 2 3 4 8 12 16 15 14 13 9 5 6 7 11 10 

            int top = 0;
            int bottom = row - 1;
            int left = 0;
            int right = col - 1;

            while (true)
            {
                if (left > right)
                {
                    break;
                }

                // print top row 

                for (int i = left; i <= right; i++)
                {
                    Console.WriteLine(matrix[left, i] + " ");
                }
                top++;

                if (top > bottom)
                {
                    break;
                }

                // print right column

                for (int i = top; i <= bottom; i++)
                {
                    Console.WriteLine(matrix[i, right] + " ");
                }
                right--;

                if (left > right)
                {
                    break;
                }

                // print bottom row 

                for (int i = right; i >= left; i--)
                {
                    Console.WriteLine(matrix[bottom, i] + " ");
                }

                bottom--;

                if (top > bottom)
                {
                    break;
                }

                for (int i = bottom; i >= top; i--)
                {
                    Console.WriteLine(matrix[i, left] + " ");
                }

                left++;
            }
        }

        public int MajorityElement(int[] arr)
        {
            // {3, 3, 4, 2, 4, 4, 2, 4, 4}
            // output 4

            int majority = arr[0];
            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                // if current element is equals to default majority element
                if (arr[i] == majority)
                {
                    count++;
                }
                else
                {
                    count--;
                }

                if (count == 0)
                {
                    // update the majority element
                    majority = arr[i];
                    count++;
                }
            }

            return majority;
        }

        public int MaximumSubArray(int[] arr)
        {
            // {-2, -3, 4, -1, -2, 1, 5, -3}

            int currentSum = 0;
            int maxSum = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = currentSum + arr[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

                if (currentSum < 0)
                {
                    currentSum = 0;
                }
            }

            return maxSum;
        }

        public int LongestNonReaptingSubstringLength(string s)
        {
            //S = "geeksforgeeks"
            //Output: 7

            return 0;
        }
    }
}
