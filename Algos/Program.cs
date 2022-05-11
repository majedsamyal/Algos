using Algos.Array;
using Algos.Graph;
using Algos.LinkedList;
using Algos.Recursion;
using Algos.Stack;
using Algos.String;
using Algos.Tree;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos
{
    class Program
    {
        public static void Main(string[] args)
        {
            #region Linked List
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
            //MSingleLinkedList lnk = new MSingleLinkedList();
            //lnk.Add("10");
            //lnk.Add("10");
            //lnk.Add("6");
            //lnk.Add("5");
            //lnk.Add("4");
            //lnk.Add("3");
            //lnk.Add("3");
            //lnk.Add("1");
            //var kthNode = lnk.FindKthNodeFromTail(3, lnk.Head);
            //var node5 = lnk.Search("5");
            //node5.Next = lnk.Search("3");
            //bool hasLoop = lnk.HasLoop();
            //var reverseLnk = lnk.Reverse(lnk.Head);
            //var newHead = lnk.ReverseWithLoop(lnk.Head);
            //lnk.RemoveDuplicates();
            //MSingleLinkedList lnkUnsorted = new MSingleLinkedList();
            //lnkUnsorted.Add("10");
            //lnkUnsorted.Add("1");
            //lnkUnsorted.Add("6");
            //lnkUnsorted.Add("5");
            //lnkUnsorted.Add("12");
            //lnkUnsorted.Add("3");
            //lnkUnsorted.Add("3");
            //lnkUnsorted.Add("1");
            //lnkUnsorted.RemoveDuplicatesUnsorted();

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

            //MSingleLinkedList lnk5 = new MSingleLinkedList();
            //lnk5.Add("3");
            //lnk5.Add("6");
            //lnk5.Add("5");

            //MSingleLinkedList lnk6 = new MSingleLinkedList();
            //lnk6.Add("2");
            //lnk6.Add("4");
            //lnk6.Add("8");

            //var res = lnk5.SumOfLinkedListSet2UsingStack(lnk5.Head, lnk6.Head);

            //MSingleLinkedList lnk7 = new MSingleLinkedList();
            //lnk7.Add("9");
            //lnk7.Add("8");
            //lnk7.Add("7");
            //lnk7.Add("6");
            //lnk7.Add("5");
            //lnk7.Add("4");
            //lnk7.Add("3");
            //lnk7.Add("2");
            //lnk7.Add("1");
            //var node = lnk7.ReverseAlterKNodes(lnk7.Head, 3);

            //MSingleLinkedList lnk8 = new MSingleLinkedList();
            //lnk8.Add("1");
            //lnk8.Add("1");
            //lnk8.Add("3");
            //lnk8.Add("3");
            //lnk8.Add("1");
            //lnk8.Add("1");

            //var isPalindrome = lnk8.IsPalindromWithNoExtraSpace(lnk8.Head);

            //MSingleLinkedList lnk9 = new MSingleLinkedList();           
            //lnk9.Add("3");
            //lnk9.Add("2");
            //lnk9.Add("1");
            //lnk9.Add("1");
            //lnk9.Add("1");
            //var newHead = lnk9.RemoveAllDuplicateOccurances(lnk9.Head);
            #endregion

            #region Tree 

            //TreeNode t1 = new TreeNode("15");
            //t1.left = new TreeNode("10");
            //t1.right = new TreeNode("20");
            //t1.left.left = new TreeNode("8");
            //t1.left.right = new TreeNode("12");
            //t1.right.left = new TreeNode("16");
            //t1.right.right = new TreeNode("25");

            //TreeNode t2 = new TreeNode("15");
            //t2.left = new TreeNode("10");
            //t2.right = new TreeNode("20");
            //t2.left.left = new TreeNode("8");
            //t2.left.right = new TreeNode("12");
            //t2.right.left = new TreeNode("16");
            //t2.right.right = new TreeNode("25");
            //t2.right.right.left = new TreeNode("50");

            //TreeProblems.DFSPreOrder(t1);
            //TreeProblems.DFSPreOrderUsingRecursion(t1);
            //TreeProblems.DFSInOrder(t1);
            //TreeProblems.DFSInOrderUsingRecursion(t1);
            //TreeProblems.DFSPostOrder(t1);
            //TreeProblems.DFSPostOrderWithSingleStack(t1);

            //TreeProblems.LevelOrderTraversalWithLevel(t1);
            // bool res = TreeProblems.IsIdenticalUsingRecursion(t1, t2);
            // bool rest = TreeProblems.IsIdenticalUsingIterative(t1, t2);
            //int[] inoder = { 8, 10, 12, 15, 16, 20, 50, 25 };
            //int[] preorder = { 15, 10, 8, 12, 20, 16, 25, 50 };
            //var root = TreeProblems.TreeFromPreAndInorder(inoder, preorder);
            //int h = TreeProblems.HeightOfBinaryTree(t2);
            //var sum = RecursionHelper.SumOfNumber(5);
            //Console.WriteLine(sum);
            //RecursionHelper.PrintNumberIncreasing(10);
            //RecursionHelper.PrintNumberDecreasing(10);
            //var output =  RecursionHelper.ReverseString("majed samyal");
            //Console.WriteLine(output);
            //Stack<int> stack = new Stack<int>();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);
            //var stackP = StackProblems.RemoveMidElement(stack, 5/2 + 1);
            //StackProblems.PrintStackInReverse(stack);
            //StackProblems.PrintStack(stack);
            //var result = StackProblems.EvaluatePostfixExpression("231*+9-");
            //var reverseString = StackProblems.ReverseStringUsingStack("majed");
            //StackProblems.ReverseWordsInString("Hello World");

            //TreeNode t1 = new TreeNode("22");
            //t1.left = new TreeNode("14");
            //t1.right = new TreeNode("25");
            //t1.left.left = new TreeNode("13");            
            //t1.right.left = new TreeNode("23");
            //t1.right.right = new TreeNode("32");
            //t1.right.right.left = new TreeNode("28");
            //t1.right.right.left.left = new TreeNode("26");
            //t1.right.right.right = new TreeNode("40");

            //TreeTrack.KLargestElement(t1, 3);
            #endregion

            #region Array 
            //ArraySubset arraySubset = new ArraySubset();
            //arraySubset.IsSubset(new int[] { 1, 2, 5, 3, 7, 11 }, new int[] { 3, 7, 1 });
            //int minCount = ArrayProblem.MinDeleteOpertionsUsingHash(new int[] { 4, 4, 3, 2, 1 });
            //ArrayProblem.PrintArrayFrequency(new int[] { 2, 3, 3, 2, 5 }, 5);
            //int sum = ArrayProblem.MaxSubArraySum(new int[] { -2, -3, 4, -1, -2, 1, 5, -3 });
            //var sort = ArrayProblem.Segregate012InArray(new int[] { 0, 1, 0, 2, 1 });

            //var array = Array.update1.ArrayProblems.LeftRotateArray(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2);
            //var arr = Array.update1.ArrayProblems.LeftRotateArrayUsingExtraSpace(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 2);
            //var arr = Array.update1.ArrayProblems.RightRotateArray(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 1);
            int[] arr = new int[] { 0, 2 };
            //var missingElement = Array.update1.ArrayProblems.FindMissingElementUsingXOR(arr);
            int[] arr1 = new[] { 1, 1, 3, 3, 4, 5, 5, 7, 7, 8, 8 };
            int[] arr2 = new[] { 2, 5, 6, 8, 11, 21 };
            //var mergeTwoSortedArray = Array.update1.ArrayProblems.MergeTwoSortedArrayUsingExtraSpace(arr1, arr2);
            //var mergeTwoSortedArray = Array.update1.ArrayProblems.MergeTwoSortedArrayIntoOne(arr1, arr2);
            //var singleAppearElement = Array.update1.ArrayProblems.FindElementAppearsOnceUsingXOR(arr1);
            //Array.update1.ArrayProblems.FindElementAppearsOnceUsingBinarySearch(arr1, 0, arr1.Length - 1);
            //var item = Array.update1.ArrayProblems.FindItemUsingBinarySearch(arr2, 5, 0, arr2.Length - 1);
            //int[] arrUnSorted = new[] { 8, 4, 3, 12, 25, 6, 13, 10 };
            //var copy = new int[arrUnSorted.Length];
            //System.Array.Copy(arrUnSorted, copy, 0);
            //Array.update1.ArrayProblems.MergeSort(arrUnSorted, copy, 0, arrUnSorted.Length - 1);
            //int[] arr3 = new[] { 1,3, 5, 6, 9, 6, 4, 2, 1, 0 };
            //var largestNumber = Array.update1.ArrayProblems.MaxNumberInIncreasingAndDecreasingArray(arr3, 0, arrUnSorted.Length - 1);
            //int[] sortTo = new int[] { 0, 1, 2, 0, 1, 2 };
            //Array.update1.ArrayProblems.SortArrayOf01And2s(sortTo);

            //int[] arrToJump = new[] { 1, 3, 5, 3, 1, 2, 6, 7, 6, 8, 9 };
            //int totalJumps = Array.update1.ArrayProblems.JumpGameProblem(arrToJump);

            //int[] arrInput = new[] { 2,3,5,9,1 };
            //var output = Array.update1.ArrayProblems.FindNextImmediateMaxNumber(arrInput);
            //int[] arrivals = { 100, 140, 150, 200, 215, 400 };
            //int[] departures = { 110, 300, 220, 230, 315, 600 };
            //var totalPlatformRequired = Array.update1.ArrayProblems.MaximumPlatformsRequired(arrivals, departures);
            //int[,] a = { { 1, 2, 3, 4},
            //          { 5, 6, 7, 8},
            //          { 9, 10, 11, 12},
            //          { 13, 14, 15, 16},
            //};
            //Array.update1.ArrayProblems.PrintMatrixInSpriralOrder(a, 4, 4);
            //int[] frequencyArr = new int[] { 5, 2, 7, 7, 5, 5, 2 };
            //Array.update1.ArrayProblems.FrequencyOfElements(frequencyArr);
            //int[] arrStock = new int[] { 98, 178, 250, 300, 40, 540, 690 };
            //Array.update1.ArrayProblems.StockBuySellProblem(arrStock);

            //int[,] mat = {
            //{ 1, 2, 3, 4 },
            //{ 5, 6, 7, 8 },
            //{ 9, 10, 11, 12 },
            //{ 13, 14, 15, 16 }
            //};

            //Array.update1.ArrayProblems.RotateMatrixBy90(mat,4);

            //int[,] matrix = { { 0, 0, 1, 0 },
            //                  { 0, 0, 1, 0 },
            //                  { 0, 0, 0, 0 },
            //                  { 0, 0, 1, 0 }
            //};


            //Array.update1.ArrayProblems.FindCelebrity(matrix, 4);

            //int[] part = new[] { 4, 3, 9, 5,11, 1, 23 };

            //int kth = Array.update1.ArrayProblems.KthSmallestElement(part, 0, 6, 5);

            //int result = Array.update1.ArrayProblems.TrappingRainWater(new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 });

            //int[] arrayToCheck = new[] { 1, 20, 6, 7, 5, 8, 11, 3 };
            //var tempArr = new int[arrayToCheck.Length];
            //System.Array.Copy(arrayToCheck, tempArr, 0);
            //int inversionCount = Array.update1.ArrayProblems.InversionCountOfArray(arrayToCheck, tempArr, 0, arrayToCheck.Length - 1);

            // Insert, Search, Delete, GetRandom in O(1)
            //ProDataStructure proDataStructure = new ProDataStructure();
            //proDataStructure.Insert(2);
            //proDataStructure.Insert(5);
            //proDataStructure.Insert(9);
            //proDataStructure.Insert(3);

            //proDataStructure.Remove(2);
            //proDataStructure.Insert(8);
            //var output = proDataStructure.Search(5);

            //var random = proDataStructure.GetRandom();

            //proDataStructure.Insert(11);

            //int[] arrMed1 = new int[] { 1,6,8,10,12,13 };
            //int[] arrMed2 = new int[] { 2,3,4,9,11,15 };
            //int median = Array.update1.ArrayProblems.MedianOfTwoSortedArrays1(arrMed1, arrMed2);


            #endregion

            #region Graph Problems 

            //GraphMS g = new GraphMS(4);
            //g.AddEdge(0, 1);
            //g.AddEdge(0, 2);
            //g.AddEdge(1, 2);
            //g.AddEdge(2, 0);
            //g.AddEdge(2, 3);
            //g.AddEdge(3, 3);

            //g.PrintDFS(2);
            //g.PrintBFS(2);

            #endregion

            #region Sorting 

            //Sorting.Sort sort = new Sorting.Sort();
            //var arrToSort = new int[] { 10, 80, 30, 90, 40, 50, 70 };
            ////sort.QuickSort(arrToSort, 0, arrToSort.Length - 1);
            //var res = sort.MergeSort(arrToSort);
            #endregion

            #region String
            //var isAnagram = StringProblem.AnagramMethod1("listen", "silent");
            //var isAnagram = StringProblem.AnagramMehtod2("listen", "silent");
            //var reverse = StringProblem.ReverseWord("i like this program very much");
            //string[] words = { "i", "like", "this", "this", "program", "very", "much" };
            //var reverse = StringProblem.ReverseWordUsingSwap(words);
            //var duplicateWord = StringProblem.FirstDuplicateWord(words);
            //var isPalimdrome = StringProblem.IsPalimdrome("kayak");

            //StringProblem.ConvertCase(builder);
            //StringProblem.RemoveDuplicateCharUsingHashing(builder);
            // expected geksfor
            //string[] words = { "aaa", "bbb", "ccc", "bbb", "aaa", "aaa" };
            //var secondMostRepeatedWord = StringProblem.SecondMostRepeatedWord(words);
            //StringBuilder builder = new StringBuilder("geeksforgeeks");
            //var removeSpaces = StringProblem.RemoveSpacesBetterApproach(builder);
            //var firstNonRepeativeChar = StringProblem.FirstNonRepeativeCharSignleTraverse(builder);
            #endregion

            #region Recursion : https://towardsdatascience.com/10-popular-coding-interview-questions-on-recursion-2ddd8aa86039

            //SumOfNumber sumOfNumber = new SumOfNumber() { Number = 5 };
            //var sum = sumOfNumber.Get();
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //FactorialOfNumber factorialOfNumber = new FactorialOfNumber { Number = 5 };
            //var factorial = factorialOfNumber.Get();
            //Console.WriteLine(factorial);
            //Console.ReadLine();

            //SumOfNaturalNumber sumOfNaturalNumber = new SumOfNaturalNumber() { Number = 3 };
            //var sum = sumOfNaturalNumber.Get();
            //Console.WriteLine(sum);
            //Console.ReadLine();

            //ProductOfNumber productOfNumber = new ProductOfNumber() { Numbers = new List<int>() { 5, 6,2,1,3,1 } };
            //var product = productOfNumber.Get();
            //Console.WriteLine(product);
            //Console.ReadLine();
            #endregion

            StringIsPalimdrome stringIsPalimdrome = new StringIsPalimdrome() { InputString = "MOOM" };
            var isPalindrome = stringIsPalimdrome.Check();
            Console.WriteLine(isPalindrome);
            Console.ReadLine();
        }

    }
}
