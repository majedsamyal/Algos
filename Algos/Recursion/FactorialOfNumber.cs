using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class FactorialOfNumber
    {
        public int Number { get; set; }
        public int Get()
        {          
            return Factorial(Number);
        }

        private int Factorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Factorial(num - 1);
        }
    }
}
