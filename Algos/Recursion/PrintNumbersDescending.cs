using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class PrintNumbersDescending
    {
        public int Number { get; set; }        

        public void Print(int start)
        {
            if (Number == start)
                return;
           
            start++;
            Print(start);
            Console.WriteLine(start);            
        }
        
    }
}
