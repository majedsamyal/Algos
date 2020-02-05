using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    public class MinimumLengthUnsortedArray
    {
        public static string ReturnUnsortedArrayIndex(int[] arr)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (arr[l] < arr[l + 1] && l < r)
            {
                l++;
            }

            if (l == r)
            {
                return "The array is already sorted";
            }

            while (arr[r] > arr[r - 1] && r > l)
            {
                r--;
            }

            int count1 = l;
            int count2 = r;

            for (int i = l + 1; i < count2 - 1; i++)
            {
                if (arr[i + 1] < arr[i])
                {
                    l--;
                }
            }

            for (int i = r; i > count1; i--)
            {
                if (arr[i] > arr[count2])
                {
                    r++;
                }
            }

            return string.Concat(l, ",", r);
        }
    }
}
