using Algos.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class PrintLinkedlistInReverseOrder
    {
        private readonly MSingleLinkedList _linkedList;
        public PrintLinkedlistInReverseOrder()
        {
            _linkedList = new MSingleLinkedList();
            _linkedList.Add("1");
            _linkedList.Add("2");
            _linkedList.Add("3");
        }

        public void Print()
        {
            PrintInReverse(_linkedList.Head);
            Console.ReadLine();
        }

        private void PrintInReverse(Node head)
        {
            if (head == null)
                return;

            PrintInReverse(head.Next);
            Console.WriteLine(head.Data);
        }

    }

}
