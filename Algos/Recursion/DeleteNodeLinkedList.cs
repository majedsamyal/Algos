using Algos.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class DeleteNodeLinkedList
    {
        private readonly MSingleLinkedList
            _linkedList;

        public DeleteNodeLinkedList()
        {
            _linkedList = new MSingleLinkedList();
            _linkedList.Add("4");
            _linkedList.Add("3");
            _linkedList.Add("2");
            _linkedList.Add("1");
        }

        public Node Delete(int k)
        {
            return DeleteNode(_linkedList.Head, k);
        }

        private Node DeleteNode(Node start, int k)
        {
            if (k < 1)
            {
                return start;
            }

            if (start == null)
            {
                return start;
            }

            // base condition
            if (k == 1)
            {
                return start.Next;
            }

            start.Next = DeleteNode(start.Next, k - 1);

            return start;
        }
    }
}
