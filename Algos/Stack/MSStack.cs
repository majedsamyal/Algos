using Algos.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using static Algos.LinkedList.MSingleLinkedList;

namespace Algos.Stack
{
    public class MSStack
    {
        private Node top { get; set; } = null;
        public void Push(string data)
        {
            Node node = new Node();
            if (node == null)
            {
                Console.Write("Heap Overflow");                
            }

            node.Data = data;
            node.Next = top;
            top = node;
        }
        public string Pop()
        {
            if (IsEmpty())
            {
                Console.Write("Stack is empty");
            }

            string val = top.Data;
            top = top.Next;
            return val;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return "-1";
            }

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

    }
}
