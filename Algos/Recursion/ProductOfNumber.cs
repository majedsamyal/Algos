using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class ProductOfNumber
    {
        public List<int> Numbers { get; set; }

        public int Get()
        {

            return GetProduct(Numbers, 0, Numbers.Count - 1);
        }

        private int GetProduct(List<int> numbers, int start, int end)
        {
            // {1,2}           
            if (start == end)
                return numbers[start];

            return numbers[start] * GetProduct(numbers, start + 1, end);
        }
    }
}
