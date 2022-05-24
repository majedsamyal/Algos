using Algos.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.Recursion
{
    public class DeleteLinkedList
    {
        private readonly MSingleLinkedList _linkedList;

        public DeleteLinkedList()
        {
            _linkedList = new MSingleLinkedList();
            _linkedList.Add("3");
            _linkedList.Add("2");
            _linkedList.Add("1");
            // 1=> 2=> 3=> null
        }

        public void Delete()
        {
            DeleteLinked(_linkedList.Head);
        }

        private void DeleteLinked(Node node)
        {
            if (node == null)
            {
                return;
            }

            DeleteLinked(node.Next);
            node = null;
        }
    }
}
