using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Queue
{
    public class MSQueueWithArray
    {
        int size;
        private int[] arr;
        int front;
        int rear;

        public MSQueueWithArray()
        {
            size = 5;
            arr = new int[size];
            front = -1;
            rear = -1;
        }

        public bool IsEmpty()
        {
            return (front == -1 && rear == -1);
        }
        public bool IsFull()
        {
            return ((rear + 1) % size == front);
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.Write("Queue is Full");
                return;
            }
            else if (IsEmpty())
            {
                front += 1;
                rear += 1;
                arr[rear] = item;
            }
            else
            {
                rear = (rear + 1) % size;
                arr[rear] = item;
            }
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.Write("Queue is Empty");
                return -1;
            }
            else if (front == rear)
            {
                int temp = arr[front];
                front = rear = -1;
                return temp;
            }
            else
            {
                int temp = arr[front];
                front = (front + 1) % size;
                return temp;
            }
        }
    }
}
