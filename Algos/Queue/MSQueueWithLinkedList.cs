using Algos.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Queue
{
   public class MSQueueWithLinkedList
    {
        private Node rear, front = null;      

        public void Enqueue(string item)
        {
            Node temp = new Node() { Data = item };

            if (front == null && rear == null)
            {
                front = rear = temp;
            }
            else
            {
                rear.Next = temp;
                rear = temp;
            }
        }

        public string Dequeue()
        {
            if (IsEmpty())
            {                
                return "Queue is empty";
            }

            Node temp = front;
            front = front.Next;

            if (front == null) //while dequeue if queue becomes empty
            {
                front = rear = null;
            }
            return temp.Data;
        }

        public bool IsEmpty()
        {
            return front == null && rear == null;
        }

        public Node Peek()
        {
            return front;
        }
       
    }
}
