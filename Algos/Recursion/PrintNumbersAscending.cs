using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class PrintNumbersAscending
    {
        public int Number { get; set; }
        private int start = 1;

        public void Print()
        {
            PrintInAscendingOrder(Number);
        }

        private void PrintInAscendingOrder(int num)
        {
            // tail recursion
            if (start > num)
                return;

            Console.WriteLine(start);
            start++;
            PrintInAscendingOrder(num);
        }
    }
}
