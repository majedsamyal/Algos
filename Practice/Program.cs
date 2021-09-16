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
            //int[] arrTpSprt = new int[] { 2, 0, 1, 2, 1, 1, 0, 2, 1, 0, 1, 2, 0 };
            //var result = arrayPractice.SortArray012(arrTpSprt, 13);
            //int[,] a = { { 1, 2, 3, 4 },
            //          { 5, 6, 7, 8},
            //          { 9, 10, 11, 12},
            //          { 13, 14, 15, 16}};
            //arrayPractice.PrintSpiralOrderMatrix(a, 4, 4);

            //int majorityElement = arrayPractice.MajorityElement(new int[] { 1, 3, 3, 3, 2 });

            int sum = arrayPractice.MaximumSubArray(new int[] { -2, 3, -1 });
        }
    }
}
