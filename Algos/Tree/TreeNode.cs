using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Tree
{
    public class TreeNode
    {
        public string key;
        public TreeNode left, right = null;
        public TreeNode(string key)
        {
            this.key = key;
        }
    }

    public class TreeProblems
    {

        public static void DFSPreOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                Console.WriteLine(node.key);

                if (node.right != null)
                {
                    stack.Push(node.right);
                }
                if (node.left != null)
                {
                    stack.Push(node.left);
                }
            }
        }

        public static void DFSPreOrderUsingRecursion(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.key);
            DFSPreOrderUsingRecursion(root.left);
            DFSPreOrderUsingRecursion(root.right);
        }

        public static void DFSInOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> s = new Stack<TreeNode>();

            while (true)
            {
                while (root != null)
                {
                    s.Push(root);
                    root = root.left;
                }

                if (s.Count == 0)
                    return;

                var node = s.Pop();
                Console.WriteLine(node.key);
                root = node.right;
            }
        }

        public static void DFSInOrderUsingRecursion(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            DFSInOrderUsingRecursion(root.left);
            Console.WriteLine(root.key);
            DFSInOrderUsingRecursion(root.right);
        }

        public static void DFSPostOrder(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            Stack<TreeNode> s1 = new Stack<TreeNode>();
            Stack<TreeNode> s2 = new Stack<TreeNode>();

            s1.Push(root);

            while (s1.Count > 0)
            {
                TreeNode node = s1.Pop();
                s2.Push(node);

                if (node.left != null)
                {
                    s1.Push(node.left);
                }

                if (node.right != null)
                {
                    s1.Push(node.right);
                }
            }

            while (s2.Count > 0)
                Console.WriteLine(s2.Pop().key);

        }



        public static void DFSPostOrderUsingRecursion(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            DFSPostOrderUsingRecursion(root.left);
            DFSPostOrderUsingRecursion(root.right);
            Console.WriteLine(root.key);
        }

        public static void DFSPostOrderWithSingleStack(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Stack<TreeNode> s = new Stack<TreeNode>();
            while (true)
            {
                while (root != null)
                {
                    if (root.right != null)
                    {
                        s.Push(root.right);
                    }
                    s.Push(root);
                    root = root.left;
                }

                if (s.Count == 0)
                {
                    return;
                }

                var node = s.Pop();
                if (node.right != null && s.Count > 0 && node.right == s.Peek())
                {
                    root = s.Pop();
                    s.Push(node);
                }
                else
                {
                    Console.Write(node.key + " ");
                    root = null;
                }
            }
        }

        public static void LevelOrderTraversal(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {

                var node = queue.Dequeue();
                Console.Write(node.key + " ");
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
        }

        public static void LevelOrderTraversalWithLevel(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(null);

            while (queue.Count > 0)
            {

                var curr = queue.Peek();
                queue.Dequeue();

                // condition to check the 
                // occurence of next level 
                if (curr == null)
                {
                    if (queue.Count > 0)
                    {
                        queue.Enqueue(null);
                        Console.WriteLine();
                    }
                }
                else
                {
                    // Pushing left child current node 
                    if (curr.left != null)
                        queue.Enqueue(curr.left);

                    // Pushing right child current node 
                    if (curr.right != null)
                        queue.Enqueue(curr.right);

                    Console.Write(curr.key + " ");
                }
            }
        }

        public static TreeNode TreeFromPreAndInorder(int[] inorder, int[] preorder)
        {
            if (inorder == null || inorder.Length == 0 || preorder == null || preorder.Length == 0)
            {
                return null;
            }

            var root = CreateTree(inorder, preorder, 0, inorder.Length - 1);
            return root;
        }

        public static int preIndex = 0;
        private static TreeNode CreateTree(int[] inorder, int[] preorder, int startIndex, int endIndex)
        {
            if (startIndex > endIndex)
            {
                return null;
            }

            TreeNode node = new TreeNode(preorder[preIndex++].ToString());

            /* If this node has no children then return */
            if (startIndex == endIndex)
            {
                return node;
            }

            int inorderIndex = Search(inorder, startIndex, endIndex, node);
            node.left = CreateTree(inorder, preorder, startIndex, inorderIndex - 1);
            node.right = CreateTree(inorder, preorder, inorderIndex + 1, endIndex);
            return node;
        }
        private static int Search(int[] inorder, int startIndex, int endIndex, TreeNode node)
        {
            int i;
            for (i = startIndex; i <= endIndex; i++)
            {
                if (inorder[i].ToString() == node.key)
                {
                    return i;
                }
            }
            return i;
        }

        public static int HeightOfBinaryTree(TreeNode root)
        {
            if (root == null)
                return 0;

            int left = HeightOfBinaryTree(root.left);
            int right = HeightOfBinaryTree(root.right);
            return  1 + Math.Max(left, right);
        }

        public static void DeleteBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                return;
            }

            DeleteBinaryTree(root.left);
            DeleteBinaryTree(root.right);
            root = null;
        }

        #region Binary Tree

        public static bool IsIdenticalUsingRecursion(TreeNode x, TreeNode y)
        {
            if (x == null && y == null)
            {
                return true;
            }

            return (x != null && y != null && x.key == y.key && IsIdenticalUsingRecursion(x.left, y.left) && IsIdenticalUsingRecursion(x.right, y.right));
        }

        public class StackPair
        {
            public TreeNode first { get; set; }
            public TreeNode second { get; set; }
            public StackPair(TreeNode first, TreeNode second)
            {
                this.first = first;
                this.second = second;
            }

            public static StackPair Of(TreeNode a, TreeNode b)
            {
                return new StackPair(a, b);
            }
        }

        public static bool IsIdenticalUsingIterative(TreeNode x, TreeNode y)
        {
            // if both are null then they are equal
            if (x == null && y == null)
            {
                return true;
            }

            // first tree is null
            if (x == null)
            {
                return false;
            }

            // second tree is null
            if (y == null)
            {
                return false;
            }

            Stack<StackPair> stack = new Stack<StackPair>();
            stack.Push(StackPair.Of(x, y));

            // do while stack is not empty
            while (stack.Count > 0)
            {
                // pop top pair from the stack and process it
                x = stack.Peek().first;
                y = stack.Peek().second;
                stack.Pop();

                // if value of their root node don't match, return false
                if (x.key != y.key)
                {
                    return false;
                }

                if (x.left != null && y.left != null)
                {
                    stack.Push(StackPair.Of(x.left, y.left));
                }
                else if (x.left != null || y.left != null)
                {
                    return false;
                }

                if (x.right != null && y.right != null)
                {
                    stack.Push(StackPair.Of(x.right, y.right));
                }
                else if (x.right != null || y.right != null)
                {
                    return false;
                }
            }

            // if we reach here, both binary trees are identical
            return true;

        }

        #endregion
    }


}
