using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public static class RecursionHelper
    {
        public static void PrintReverse(char[] str)
        {
            ReverseHelper(str, 0);
        }

        public static void ReverseHelper(char[] arr, int next)
        {
            if (next >= arr.Length - 1)
            {
                return;
            }

            ReverseHelper(arr, next + 1);
            Console.Write(arr[next] + " ");
        }
        public static int SumOfNumber(int num)
        {
            if (num == 1)
                return 1;
            return SumOfNumber(num - 1) + num;
        }

        public static void PrintNumberIncreasing(int num)
        {
            if (num == 0)
                return;
            PrintNumberIncreasing(num - 1);
            Console.WriteLine(num);
        }

        public static void PrintNumberDecreasing(int num)
        {
            if (num == 0)
                return;
            Console.WriteLine(num);
            PrintNumberDecreasing(num - 1);
        }

        // maj
        // jam
        public static string ReverseString(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

          return  ReverseString(str.Substring(1)) + str[0];
        }

    }
}
