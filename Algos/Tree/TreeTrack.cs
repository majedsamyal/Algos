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
    }
}
