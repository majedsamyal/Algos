using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Queue
{
    public class LRUCacheRevision
    {
        private int size = 0;
        private int currentSize = 0;
        NodeDoubly rear = null;
        NodeDoubly front = null;
        Dictionary<int, NodeDoubly> keyValuePairs = null;

        public LRUCacheRevision(int cacheSize)
        {
            size = cacheSize;
            keyValuePairs = new Dictionary<int, NodeDoubly>(cacheSize);
        }

        public int Get(int key)
        {
            if (!keyValuePairs.ContainsKey(key))
            {
                return -1;
            }

            // Get the value and move node to the front
            NodeDoubly node;
            keyValuePairs.TryGetValue(key, out node);
            // remove this node from the current position
            RemoveNode(node);
            // and add this node to the front node
            AddNode(node);
            return node.Value;
        }

        public void Add(int key, int value)
        {
            if (keyValuePairs.ContainsKey(key))
            {
                NodeDoubly node;
                keyValuePairs.TryGetValue(key, out node);
                RemoveNode(node);
                AddNode(node);
            }
            else
            {
                if (currentSize == size)
                {
                    var temp = RemoveFromRear();
                    keyValuePairs.Remove(temp.Key);
                    currentSize--;
                }

                NodeDoubly node = new NodeDoubly() { Key = key, Value = value };
                AddNode(node);
                keyValuePairs.Add(key, node);
                currentSize++;
            }
        }

        private void RemoveNode(NodeDoubly node)
        {
            node.Prev.Next = node.Next;
            node.Next.Prev = node.Prev;
        }

        private NodeDoubly RemoveFromRear()
        {
            var temp = rear;
            rear.Prev.Next = null;
            rear = rear.Prev;
            return temp;
        }
        private void AddNode(NodeDoubly node)
        {
            if (front == null)
            {
                front = rear = node;
                return;
            }
            // add to the front
            node.Next = front;
            front.Prev = node;
            front = node;
        }

    }
}
