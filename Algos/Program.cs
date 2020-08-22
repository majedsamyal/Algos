﻿using Algos.LinkedList;
using Algos.Recursion;
using Algos.Stack;
using Algos.Tree;
using System;
using System.Collections.Generic;

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
            MSingleLinkedList lnk = new MSingleLinkedList();
            lnk.Add("10");
            lnk.Add("10");
            lnk.Add("6");
            lnk.Add("5");
            lnk.Add("4");
            lnk.Add("3");
            lnk.Add("3");
            lnk.Add("1");
            //var kthNode = lnk.FindKthNodeFromTail(3, lnk.Head);
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

            MSingleLinkedList lnk5 = new MSingleLinkedList();
            lnk5.Add("3");
            lnk5.Add("6");
            lnk5.Add("5");

            MSingleLinkedList lnk6 = new MSingleLinkedList();
            lnk6.Add("2");
            lnk6.Add("4");
            lnk6.Add("8");

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

            TreeNode t1 = new TreeNode("15");
            t1.left = new TreeNode("10");
            t1.right = new TreeNode("20");
            t1.left.left = new TreeNode("8");
            t1.left.right = new TreeNode("12");
            t1.right.left = new TreeNode("16");
            t1.right.right = new TreeNode("25");

            TreeNode t2 = new TreeNode("15");
            t2.left = new TreeNode("10");
            t2.right = new TreeNode("20");
            t2.left.left = new TreeNode("8");
            t2.left.right = new TreeNode("12");
            t2.right.left = new TreeNode("16");
            t2.right.right = new TreeNode("25");
            t2.right.right.left = new TreeNode("50");

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
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            //var stackP = StackProblems.RemoveMidElement(stack, 5/2 + 1);
            //StackProblems.PrintStackInReverse(stack);
            //StackProblems.PrintStack(stack);
            //var result = StackProblems.EvaluatePostfixExpression("231*+9-");
            //var reverseString = StackProblems.ReverseStringUsingStack("majed");
            StackProblems.ReverseWordsInString("Hello World");
            #endregion
        }

    }
}