using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class StringIsPalimdrome
    {
        public string InputString { get; set; }

        public bool Check()
        {
            return IsPalindrome(InputString, 0, InputString.Length - 1);
        }

        private bool IsPalindrome(string input, int start, int end)
        {
            // base case
            if (start >= end)
            {
                return true;
            }

            if (input[start] != input[end])
            {
                return false;
            }

            return IsPalindrome(input, start + 1, end - 1);
        }
    }
}
