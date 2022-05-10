using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class SumOfNaturalNumber
    {
        public int Number { get; set; }

        public int Get()
        {
            return GetSum(Number);
        }

        private int GetSum(int num)
        {
            if (num <= 1)
                return num;
            return num + GetSum(num - 1);
        }
    }
}
