using System;
using System.Collections.Generic;
using System.Text;

namespace Algos.LinkedList
{
    public class MSingleLinkedList
    {
        #region Basic Operations
        public Node Head { get; set; }

        public void Add(string data)
        {
            Node newNode = new Node() { Data = data };
            newNode.Next = Head;
            Head = newNode;
        }

        public void Delete()
        {
            if (Head != null)
            {
                Node temp = Head;
                Head = Head.Next;
            }
        }

        public void Print()
        {
            var temp = Head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }
        public void PrintInReverse(Node head)
        {
            if (head == null) return;
            PrintInReverse(head.Next);
            Console.WriteLine(head.Data);
        }
        public Node Search(string data)
        {
            var temp = Head;
            while (temp != null)
            {
                if (temp.Data == data)
                {
                    return temp;
                }

                temp = temp.Next;
            }
            return null;
        }
        public void Delete(string data)
        {
            if (Head != null && Head.Data == data)
            {
                Head = Head.Next;
            }

            Node p = null;
            Node q = Head;

            while (q != null && q.Data != data)
            {
                p = q;
                q = q.Next;
            }

            if (q == null)
            {
                // key not present
                return;
            }

            p.Next = q.Next;
        }
        #endregion

        public Node FindMiddle()
        {
            Node slowPtr = Head;
            Node fastPtr = Head;

            if (Head == null)
            {
                return null;
            }

            while (fastPtr != null && fastPtr.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next.Next;
            }

            return slowPtr;
        }

        public bool HasLoop()
        {
            Node slowPtr = Head;
            Node fastPtr = Head;
            bool hasLoop = false;
            while (fastPtr != null && fastPtr.Next != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next.Next;
                if (slowPtr == fastPtr)
                {
                    hasLoop = true;
                    break;
                }
            }
            return hasLoop;
        }

        public Node Reverse(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            Node temp = Reverse(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return temp;
        }

        public Node ReverseWithLoop(Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            Node prev = null;
            Node current = head;
            Node next;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
            return head;
        }

        public void RemoveDuplicates()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }

            Node current = Head;

            while (current != null && current.Next != null)
            {
                if (current.Data == current.Next.Data)
                {
                    var temp = current.Next;
                    current.Next = current.Next.Next;
                    continue;
                }
                else
                {
                    current = current.Next;
                }
            }
        }

        public void RemoveDuplicatesUnsorted()
        {
            if (Head == null || Head.Next == null)
            {
                return;
            }

            HashSet<string> hash = new HashSet<string>();
            Node current = Head;
            Node prev = null;

            while (current != null)
            {
                if (hash.Contains(current.Data))
                {
                    prev.Next = current.Next;
                }
                else
                {
                    hash.Add(current.Data);
                    prev = current;
                }
                current = current.Next;
            }
        }

        public Node FindKthNodeFromTail(int position, Node head)
        {
            if (head == null || head.Next == null)
            {
                return head;
            }

            Node slowPtr = head;
            Node fastPtr = head;
            int count = 0;

            while (count < position)
            {
                fastPtr = fastPtr.Next;
                count++;
            }

            while (fastPtr != null)
            {
                slowPtr = slowPtr.Next;
                fastPtr = fastPtr.Next;
            }

            return slowPtr;
        }

        public Node FindIntersectionNode(Node head1, Node head2)
        {
            if (head1 == null || head2 == null)
            {
                return null;
            }

            int lenght1 = 0;
            int lenght2 = 0;

            var temp = head1;
            while (temp != null)
            {
                temp = temp.Next;
                lenght1++;
            }

            temp = head2;
            while (temp != null)
            {
                temp = temp.Next;
                lenght2++;
            }

            int diff = Math.Abs(lenght1 - lenght2);

            if (lenght1 > lenght2)
            {
                while (diff > 0)
                {
                    head1 = head1.Next;
                    diff--;
                }
            }
            else
            {
                while (diff > 0)
                {
                    head2 = head2.Next;
                    diff--;
                }
            }

            while (head1 != null)
            {
                head1 = head1.Next;
                head2 = head2.Next;

                if (head1.Data == head2.Data)
                {
                    return head2;
                }
            }
            return null;
        }

        public Node SumOfTwoLinkedList(Node head1, Node head2)
        {
            // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            // Output: 7 -> 0 -> 8
            // Explanation: 342 + 465 = 807.          

            int carry = 0;
            int sum = 0;
            int val1;
            int val2;
            Node res = null;
            Node temp = null;
            Node prev = null;
            while (head1 != null || head2 != null)
            {
                val1 = head1 == null ? 0 : Convert.ToInt32(head1.Data);
                val2 = head2 == null ? 0 : Convert.ToInt32(head2.Data);
                sum = carry + val1 + val2;

                carry = (sum >= 10) ? 1 : 0;

                sum = sum % 10;
                temp = new Node { Data = sum.ToString() };
                if (res == null)
                {
                    res = temp;
                }
                else
                {
                    prev.Next = temp;
                }

                prev = temp;

                if (head1 != null)
                {
                    head1 = head1.Next;
                }
                if (head2 != null)
                {
                    head2 = head2.Next;
                }
            }

            if (carry > 0)
            {
                temp.Next = new Node { Data = sum.ToString() };
            }

            return res;
        }

        public Node SumOfLinkedListSet2UsingStack(Node head1, Node head2)
        {
            //First List: 5->6->3  // represents number 563
            //Second List: 8->4->2 //  represents number 842
            //Resultant list: 1->4->0->5
            Stack<int> stack1 = new Stack<int>();
            Stack<int> stack2 = new Stack<int>();
            Stack<int> stack3 = new Stack<int>();
            Node res = null;
            Node prev = null;
            Node temp = null;
            int val1, val2;
            int sum = 0;
            int carry = 0;
            while (head1 != null)
            {
                stack1.Push(Convert.ToInt32(head1.Data));
                head1 = head1.Next;
            }

            while (head2 != null)
            {
                stack2.Push(Convert.ToInt32(head2.Data));
                head2 = head2.Next;
            }

            while (stack1.Count > 0 || stack2.Count > 0)
            {
                val1 = stack1.Count > 0 ? stack1.Pop() : 0;
                val2 = stack2.Count > 0 ? stack2.Pop() : 0;
                sum = carry + val1 + val2;

                carry = sum >= 10 ? 1 : 0;
                sum = sum % 10;
                stack3.Push(sum);
            }

            if (carry > 0)
            {
                stack3.Push(carry);
            }

            while (stack3.Count > 0)
            {
                temp = new Node { Data = stack3.Pop().ToString() };
                if (res == null)
                {
                    res = temp;
                }
                else
                {
                    prev.Next = temp;
                }

                prev = temp;
            }

            return res;
        }

        public Node ReverseAlterKNodes(Node head, int k)
        {
            //Inputs: 1->2->3->4->5->6->7->8->9->NULL and k = 3
            //Output: 3->2->1->4->5->6->9->8->7->NULL.

            Node current = head;
            Node next = null, prev = null;
            int count = 0;

            while (current != null && count < k)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
                count++;
            }

            if (head != null)
            {
                head.Next = current;
            }

            count = 0;

            while (count < k - 1 && current != null)
            {
                current = current.Next;
                count++;
            }

            if (current != null)
            {
                current.Next = ReverseAlterKNodes(current.Next, k);
            }

            return prev;
        }

        public int IsPalindromeUsingStack(Node node)
        {
            Stack<string> stack = new Stack<string>();
            Node temp = node;

            while (temp != null)
            {
                stack.Push(temp.Data);
                temp = temp.Next;
            }


            while (node != null)
            {
                if (node.Data != stack.Pop())
                {
                    return -1;
                }
                node = node.Next;
            }

            return 1;
        }

        public int IsPalindromWithNoExtraSpace(Node node)
        {
            Node slow_Ptr = node;
            Node fast_Ptr = node;
            Node prev_Node_Of_slow_Ptr = node;
            Node middleNode = null;
            Node second_Half;

            while (fast_Ptr != null && fast_Ptr.Next != null)
            {
                fast_Ptr = fast_Ptr.Next.Next;
                prev_Node_Of_slow_Ptr = slow_Ptr;
                slow_Ptr = slow_Ptr.Next;
            }

            if (fast_Ptr != null)
            {
                middleNode = slow_Ptr;
                slow_Ptr = slow_Ptr.Next;
            }

            second_Half = slow_Ptr;
            prev_Node_Of_slow_Ptr.Next = null;

            var reverse = ReverseWithLoop(second_Half);
            int flag = Compare(node, reverse);

            var reverse1 = ReverseWithLoop(reverse);

            if (middleNode != null)
            {
                prev_Node_Of_slow_Ptr.Next = middleNode;
                middleNode.Next = reverse1;
            }
            else
            {
                prev_Node_Of_slow_Ptr.Next = reverse1;
            }

            return flag;
        }

        private int Compare(Node node1, Node node2)
        {
            while (node1 != null && node2 != null)
            {
                if (node1.Data == node2.Data)
                {
                    node1 = node1.Next;
                    node2 = node2.Next;
                }
                else
                {
                    return -1;
                }
            }

            return 1;
        }

        public Node RemoveAllDuplicateOccurances(Node head)
        {
            // 1>1>1>2>3
            // https://www.geeksforgeeks.org/remove-occurrences-duplicates-sorted-linked-list/
            Node dummy = new Node() { Data = "0" };
            dummy.Next = head;
            Node prev = dummy;
            Node current = head;

            while (current != null)
            {
                /* Until the current and previous values 
                are same, keep updating current */
                while (current.Next != null &&
                    prev.Next.Data == current.Next.Data)
                    current = current.Next;

                /* if current has unique value i.e current 
                    is not updated, Move the prev pointer 
                    to next node*/
                if (prev.Next == current)
                    prev = prev.Next;

                /* when current is updated to the last 
                duplicate value of that segment, make 
                prev the next of current*/
                else
                    prev.Next = current.Next;

                current = current.Next;
            }

            /* update original head to the next of dummy 
            node */
            head = dummy.Next;
            return head;
        }
    }

    public class Node
    {
        public string Data { get; set; }
        public Node Next { get; set; }
    }
}
