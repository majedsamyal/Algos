using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class DecimalToBinary
    {
        // 85452
        public string Convert(int num)
        {
            return FindBinary(num, string.Empty);
        }

        private string FindBinary(int num, string result)
        {
            if (num == 0)
            {
                return result;
            }

            result =  num % 2 + result;
            return FindBinary(num / 2, result);
        }
    }
}
