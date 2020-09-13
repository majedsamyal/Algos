using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Queue
{
    public class LRUCache
    {
        private int size = 0;
        private int currentSize = 0;
        private NodeDoubly front = null;
        private NodeDoubly rear = null;
        private Dictionary<int, NodeDoubly> keyValuePairs = null;

        public LRUCache(int cacheSize)
        {
            size = cacheSize;
            keyValuePairs = new Dictionary<int, NodeDoubly>(size);
        }

        public int Get(int key)
        {
            if (!keyValuePairs.ContainsKey(key))
            {
                return -1;
            }

            NodeDoubly node;
            keyValuePairs.TryGetValue(key, out node);
            RemoveNode(node);
            AddNode(node);
            return node.Value;
        }

        public void Add(int key, int value)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                // when key already exists
                NodeDoubly node;
                keyValuePairs.TryGetValue(key, out node);
                RemoveNode(node);
                AddNode(node);
            }
            else
            {
                if (currentSize == size)
                {   
                    RemoveFromRear();
                    keyValuePairs.Remove(key);
                    currentSize--;
                }

                NodeDoubly node = new NodeDoubly() { Value = value };
                AddNode(node);
                keyValuePairs.Add(key, node);
                currentSize++;
            }
        }

        private void AddNode(NodeDoubly nodeDoubly)
        {
            if (front == null)
            {
                front = rear = nodeDoubly;
                return;
            }

            nodeDoubly.Next = front;
            front.Prev = nodeDoubly;
            front = nodeDoubly;
        }

        private void RemoveFromRear()
        {
            rear.Prev.Next = null;
            rear = rear.Prev;
        }
        private void RemoveNode(NodeDoubly nodeDoubly)
        {
            nodeDoubly.Prev.Next = nodeDoubly.Next;
            nodeDoubly.Next.Prev = nodeDoubly.Prev;
        }
    }

    public class NodeDoubly
    {
        public NodeDoubly Prev { get; set; }
        public int Value { get; set; }
        public NodeDoubly Next { get; set; }
    }
}
