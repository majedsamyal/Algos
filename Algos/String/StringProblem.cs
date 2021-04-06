using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algos.String
{
    public class StringProblem
    {
        /// <summary>
        /// Sort and Compare.
        /// Time Complexcity: O(nlogn), sorting string
        /// Space Complexicity: O(1)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool AnagramMethod1(string first, string second)
        {
            // listen : silent
            if (first.Length != second.Length)
            {
                return false;
            }

            // sort both the strings
            var arr1 = first.ToCharArray();
            var arr2 = second.ToCharArray();
            System.Array.Sort(arr1);
            System.Array.Sort(arr2);

            //use loop for comparison
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Using Count Array
        /// Time Complexicity: O(n), loop array to increament
        /// Space Complexcity: O(1), assuming 8 bit char, possible combinations 256
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static bool AnagramMehtod2(string first, string second)
        {
            // listen : silent
            int noOfChar = 256;
            int[] count = new int[noOfChar];

            // compare length
            if (first.Length != second.Length)
            {
                return false;
            }

            for (int i = 0; i < first.Length; i++)
            {
                count[first[i]]++;
                count[second[i]]--;
            }

            // check if all elements contains 0 
            for (int i = 0; i < count.Length; i++)
            {
                if (count[i] != 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static string ReverseWordUsingSwap(string sentence)
        {
            // i like this program very much
            // much very program this like i
            string[] arr = sentence.ToCharArray().Select(c => c.ToString()).ToArray();

            return "";
        }

        /// <summary>
        /// Reverse all the words first, and then reverse the complete string
        /// Time Complexcity: O(N)
        /// Space Complexcity: O(1)
        /// </summary>
        /// <param name="sentence"></param>
        /// <returns></returns>
        public static string ReverseWord(string sentence)
        {
            // i like this program very much
            // much very program this like i
            var arr = sentence.ToCharArray();

            int start = 0;
            for (int end = 0; end < arr.Length; end++)
            {
                if (arr[end] == ' ')
                {
                    ReverseLetters(arr, start, end-1);
                    start = end + 1;
                }
            }

            // reverse last word
            ReverseLetters(arr, start, arr.Length - 1);

            ReverseLetters(arr, 0, arr.Length - 1);

            return new string(arr);
        }

        private static void ReverseLetters(char[] str, int start, int end)
        {
            // majed
            // dejam
            char temp;
            while (start <= end)
            {
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
        }
    }
}
