using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Tree
{
    public static class TreeTrack
    {
        private static int count = 0;
        public static void KLargestElement(TreeNode node, int kth)
        {
            // the second condition is to avoid unnecessary calls
            if (node == null || count > kth)
            {
                return;
            }

            KLargestElement(node.right, kth);

            count++;
            if (count == kth)
            {
                Console.WriteLine(node.key);
                return;
            }

            KLargestElement(node.left, kth);
        }

        public static TreeNode head;
        private static TreeNode prev;
        public static void ConvertBinaryTreeToDoublyLinkedList(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            // call left recursion

            ConvertBinaryTreeToDoublyLinkedList(node.left);

            // update pointer left and right

            if (prev == null) // executes once to find the root node of list
            {
                head = node;
            }
            else
            {
                node.left = prev;
                prev.right = node;
            }

            prev = node;

            // call right recursion

            ConvertBinaryTreeToDoublyLinkedList(node.right);
        }

        public static void PrintKDistanceNodes(TreeNode node, int k)
        {
            if (node == null)
                return;

            if (k == 0)
            {
                Console.WriteLine(node.key);
                return;
            }

            PrintKDistanceNodes(node.left, k--);
            PrintKDistanceNodes(node.right, k--);
        }

        public static void PrintLeafNodes(TreeNode node)
        {
            if (node == null)
                return;

            PrintLeafNodes(node.left);

            if (node.left == null && node.right == null)
            {
                Console.WriteLine(node.key);
            }

            PrintLeafNodes(node.right);
        }

        public static void PrintLeftBoundryNodes(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.left != null)
            {
                Console.WriteLine(node.key);
                PrintLeftBoundryNodes(node.left);
            }
            else if (node.right != null)
            {
                Console.WriteLine(node.key);
                PrintLeftBoundryNodes(node.right);
            }
        }

        public static void PrintRightBoundryNode(TreeNode node)
        {
            if (node == null)
            {
                return;
            }

            if (node.right != null)
            {
                PrintRightBoundryNode(node.right);
                Console.WriteLine(node.key);
            }
            else if (node.left != null)
            {
                PrintRightBoundryNode(node.left);
                Console.WriteLine(node.key);
            }
        }

        public static void PrintBoundryOfTree(TreeNode node)
        {
            if (node == null)
                return;

            // print root node

            Console.WriteLine(node.key);

            PrintLeftBoundryNodes(node);

            PrintLeafNodes(node);

            PrintRightBoundryNode(node);
        }
    }
}
