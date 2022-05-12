using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class ReverseString
    {     
        public string Reverse(string input)
        {
            // majed
            if (input.Length == 0 || input.Length == 1)
                return input;

            return input[input.Length -1] + Reverse(input.Substring(0, input.Length -1));
        }
    }
}
