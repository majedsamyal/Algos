using Algos.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class ReverseLinkedList
    {
        private readonly MSingleLinkedList _linkedList;

        public ReverseLinkedList()
        {
            _linkedList = new MSingleLinkedList();
            _linkedList.Add("3");
            _linkedList.Add("2");
            _linkedList.Add("1");
        }

        public Node Reverse()
        {
            return ReverseList(_linkedList.Head);
        }

        private Node ReverseList(Node head)
        {
            if (head.Next == null)
            {
                return head;
            }   

            var last = ReverseList(head.Next);
            last.Next = head;
            head.Next = null;
            head = last;

            return last;
        }
    }
}
