using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class Concept
    {
        public int C1(int[] inputArr, int count)
        {
            if (count == 1)
            {
                return inputArr[3];
            }
            inputArr[3] = inputArr[3] + 1;
            return C1(inputArr, count - 1);
        }
    }
}
