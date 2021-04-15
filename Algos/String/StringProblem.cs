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

        /// <summary>
        /// Swap string array, assuming the parameter will be an array of strings
        /// Time Complexicity: O(n), loop array to swap
        /// Space Complexcity: O(1)
        /// </summary>
        /// <param name="sentenceArray"></param>
        /// <returns></returns>
        public static string ReverseWordUsingSwap(string[] sentenceArray)
        {
            // i like this program very much
            // much very program this like i   

            for (int i = 0; i < sentenceArray.Length / 2; i++)
            {
                var temp = sentenceArray[i];
                sentenceArray[i] = sentenceArray[sentenceArray.Length - 1 - i];
                sentenceArray[sentenceArray.Length - 1 - i] = temp;
            }

            return string.Join(" ", sentenceArray);
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
                    ReverseLetters(arr, start, end - 1);
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


        /// <summary>
        /// Store words in Disctionay with their count
        /// Time Complexcity: O(N), in best case it's O(N) to O(M), where M is the index of duplicate word
        /// Space Complexcity: O(N), as we are using Dictionay to store the occurance 
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string FirstDuplicateWord(string[] arr)
        {
            // Ravi had been saying that he had been there
            string result = "No Repetition";

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (keyValuePairs.ContainsKey(arr[i]))
                {
                    int count = keyValuePairs[arr[i]];
                    keyValuePairs[arr[i]] = count++;
                    if (count > 1)
                    {
                        return arr[i];
                    }
                }
                else
                {
                    keyValuePairs.Add(arr[i], 1);
                }
            }

            return result;
        }

        /// <summary>
        /// Find middle and do the comparison
        /// Time Complexcity: O(N)
        /// Space Complexcity: O(1)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool IsPalimdrome(string str)
        {
            //Kayak

            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Subtract or Add int 32 
        /// Time Complexcity: O(N)
        /// Space Complexcity: O(1)
        /// </summary>
        /// <param name="str"></param>
        public static void ConvertCase(StringBuilder str)
        {
            int ln = str.Length;
            for (int i = 0; i < ln; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z')
                {
                    str[i] = (char)(str[i] - 32);
                }
                else if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    str[i] = (char)(str[i] + 32);
                }
            }
        }

        /// <summary>
        /// Remove using Brute Force
        /// Time Complexcity: O(N ^2), using two loops
        /// Space Complexcity: O(1)
        /// </summary>
        /// <param name="str"></param>
        public static void RemoveDuplicateCharBruteForce(StringBuilder str)
        {
            //majeeed

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (j > str.Length - 1)
                    {
                        break;
                    }
                    if (str[i] == str[j])
                    {
                        str.Remove(j, 1);
                        j--;
                    }
                }
            }
        }

        /// <summary>
        /// Add key into Dictionary and then if key found remove the occurance from origional string
        /// Time Complexcity:O(N)
        /// Space Complexcity:O(N)
        /// </summary>
        /// <param name="str"></param>
        public static void RemoveDuplicateCharUsingHashing(StringBuilder str)
        {
            //geeksforgeeks

            Dictionary<char, char> keyValuePairs = new Dictionary<char, char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (keyValuePairs.ContainsKey(str[i]))
                {
                    str.Remove(i, 1);
                    i--;
                }
                else
                {
                    keyValuePairs.Add(str[i], str[i]);
                }
            }
        }

        /// <summary>
        /// Store words count in Disctionary and then find the next most repeated word count
        /// Time Complexcity:O(N)
        /// Space Complexcity:O(N), using Dictionary to store
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static string SecondMostRepeatedWord(string[] arr)
        {
            //["aaa", "bbb", "ccc", "bbb",  "aaa", "aaa"]

            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (keyValuePairs.ContainsKey(arr[i]))
                {
                    keyValuePairs[arr[i]] = keyValuePairs[arr[i]] + 1;
                }
                else
                {
                    keyValuePairs.Add(arr[i], 1);
                }
            }

            string result = string.Empty;
            int first = 0;
            int second = -1;
            foreach (var item in keyValuePairs)
            {
                var value = item.Value;
                if (value > first)
                {
                    first = value;
                }
                if (value < first && value > second)
                {
                    second = value;
                    result = item.Key;
                }
            }
            return result;
        }

        /// <summary>
        /// Traverse the string, if current char is a space, remove and shift all char by -1 position. Using inbuilt C# method to remove and shift
        /// Time Complexcity: O(N^2), traverse string and shift chars
        /// Space Complexcity: O(1)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSpacesBruteForce(StringBuilder str)
        {
            // input: "g  eeks   for ge  eeks  "

            int counter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                counter++;
                if (str[i] == ' ')
                {
                    str.Remove(i, 1);
                    i--;
                }
            }

            return str.ToString();
        }

        /// <summary>
        /// Traverse the string, if current char is not a space, move that char to the start of string by maintaining one counter
        /// Time Complexcity:O(N), as we only do string traverse
        /// Space Complexcity:O(1)
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string RemoveSpacesBetterApproach(StringBuilder str)
        {
            // input: "g  eeks   for ge  eeks  "

            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    str[count++] = str[i];
                }
            }

            return str.ToString().Substring(0, count);
        }
    }
}
