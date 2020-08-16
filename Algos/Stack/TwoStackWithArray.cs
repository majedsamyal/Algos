using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Stack
{
    public class TwoStackWithArray
    {
        private int size;
        private static string[] arr;
        int top1;
        int top2;
        public TwoStackWithArray()
        {
            size = 10;
            arr = new string[size];
            top1 = -1;
            top2 = size;
        }

        public void S1Push(string item)
        {
            if (top1 + 1 == top2)
            {
                Console.Write("Stack is full");
            }
            top1++;
            arr[top1] = item;
        }

        public string S1Pop()
        {
            if (top1 < 0)
            {
                Console.Write("Stack is empty");
                return null;
            }
            
            top1--;
            return arr[top1 + 1];
        }

        public string S1Peek()
        {
            if (top1 < 0)
            {
                Console.Write("Stack is empty");
                return null;
            }

            return arr[top1];
        }

        public void S2Push(string item)
        {
            if (top1 + 1 == top2)
            {
                Console.Write("Stack is full");
            }
            top2--;
            arr[top2] = item;
        }

        public string S2Pop()
        {
            if (top2 >= size)
            {
                Console.Write("Stack is empty");
                return null;
            }

            top2++;
            return arr[top2 + 1];
        }

        public string S2Peek()
        {
            if (top2 == size)
            {
                Console.Write("Stack is empty");
                return null;
            }

            return arr[top2];
        }

    }
}
