using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class SumOfNumber
    {
        public int Number { get; set; }        
        public int Get()
        {
            int sum =  0;
            return Sum(Number);
        }

        private int Sum(int num)
        {
            if(num == 1)
               return 1;
            
            return num + Sum(num -1);
        }
    }
}
