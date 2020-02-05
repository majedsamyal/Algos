using Algos.LinkedList;
using System;

namespace Algos
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //var spiralArr = SpiralMatrix.ReturnSpiralMatrix(5);
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(spiralArr[i, j] +"\n");
            //    }

            //    Console.WriteLine(Environment.NewLine);
            //}
            //Console.ReadLine();
            //var arr = new[] { 10, 12, 20, 30, 25, 40, 32, 31, 35, 50, 60 };
            //var unsortedArrayIndex = MinimumLengthUnsortedArray.ReturnUnsortedArrayIndex(arr);
            //var sum = MaximumSumArray.GetMaximumSumOfSubArray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            //SetMatrixZero.SetMatrixZeroFunc(new int[,] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });
            //int counter = LargestNonNegativeSubArray.Length(new int[] { 2, 3, 4, -1, -2, 1, 5, 6, 3 });
            //int maxSum = LargestNonNegativeSubArray.Sum(new int[] { 10, -1, 2, 3, -4, 100 });
            MSingleLinkedList lnk = new MSingleLinkedList();
            lnk.Add("10");
            lnk.Add("10");
            lnk.Add("6");
            lnk.Add("5");
            lnk.Add("4");
            lnk.Add("3");
            lnk.Add("3");
            lnk.Add("1");
            var kthNode = lnk.FindKthNodeFromTail(3, lnk.Head);
            //var node5 = lnk.Search("5");
            //node5.Next = lnk.Search("3");
            //bool hasLoop = lnk.HasLoop();
            //var reverseLnk = lnk.Reverse(lnk.Head);
            //var newHead = lnk.ReverseWithLoop(lnk.Head);
            //lnk.RemoveDuplicates();
            MSingleLinkedList lnkUnsorted = new MSingleLinkedList();
            lnkUnsorted.Add("10");
            lnkUnsorted.Add("1");
            lnkUnsorted.Add("6");
            lnkUnsorted.Add("5");
            lnkUnsorted.Add("12");
            lnkUnsorted.Add("3");
            lnkUnsorted.Add("3");
            lnkUnsorted.Add("1");
            lnkUnsorted.RemoveDuplicatesUnsorted();

            //MSingleLinkedList lnk1 = new MSingleLinkedList();
            //lnk1.Add("5");
            //lnk1.Add("4");
            //lnk1.Add("3");
            //lnk1.Add("2");           

            //MSingleLinkedList lnk2 = new MSingleLinkedList();
            //lnk2.Add("5");
            //lnk2.Add("4");
            //lnk2.Add("3");
            //lnk2.Add("8");
            //lnk2.Add("9");
            //lnk2.Add("10");

            //var interSectionNode = lnk1.FindIntersectionNode(lnk1.Head, lnk2.Head);

            //MSingleLinkedList lnk3 = new MSingleLinkedList();
            //lnk3.Add("3");
            //lnk3.Add("4");
            //lnk3.Add("2");

            //MSingleLinkedList lnk4 = new MSingleLinkedList();
            //lnk4.Add("4");
            //lnk4.Add("6");
            //lnk4.Add("5");

            //var resultLnkList = lnk3.SumOfTwoLinkedList(lnk3.Head, lnk4.Head);

            MSingleLinkedList lnk5 = new MSingleLinkedList();
            lnk5.Add("3");
            lnk5.Add("6");
            lnk5.Add("5");

            MSingleLinkedList lnk6 = new MSingleLinkedList();
            lnk6.Add("2");
            lnk6.Add("4");
            lnk6.Add("8");

            //var res = lnk5.SumOfLinkedListSet2UsingStack(lnk5.Head, lnk6.Head);

            MSingleLinkedList lnk7 = new MSingleLinkedList();
            lnk7.Add("9");
            lnk7.Add("8");
            lnk7.Add("7");
            lnk7.Add("6");
            lnk7.Add("5");
            lnk7.Add("4");
            lnk7.Add("3");
            lnk7.Add("2");
            lnk7.Add("1");
            var node = lnk7.ReverseAlterKNodes(lnk7.Head, 3);
        }

    }
}
