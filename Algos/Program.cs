using System;

namespace Algos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var spiralArr = SpiralMatrix.ReturnSpiralMatrix(5);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(spiralArr[i, j] +"\n");
                }

                Console.WriteLine(Environment.NewLine);
            }
            Console.ReadLine();
        }

        
    }
}
