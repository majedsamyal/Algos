using System;
using System.Collections.Generic;
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
    }
}
