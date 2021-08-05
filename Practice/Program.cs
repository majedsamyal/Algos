using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Array 
            ArrayPractice arrayPractice = new ArrayPractice();
            int[] arrTpSprt = new int[] { 2, 0, 1, 2, 1, 1, 0, 2, 1, 0, 1, 2, 0 };
            var result = arrayPractice.SortArray012(arrTpSprt, 13);


        }
    }
}
