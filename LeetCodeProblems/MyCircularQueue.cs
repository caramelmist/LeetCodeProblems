using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MyCircularQueue
    {
        private int _size = 0;
        private ListNode? node;

        public MyCircularQueue(int k)
        {
            _size = k;
        }

        public bool EnQueue(int value)
        {
            if (IsFull())
            {
                return false;
            }

            ListNode pointer = node;
            if(pointer == null)
            {
                node = new ListNode(value);
                return true;
            }
            else
            {
                while (pointer.next != null)
                {
                    pointer = pointer.next;
                }
            }

            pointer.next = new ListNode(value);
            return true;
        }

        public bool DeQueue()
        {
            if (IsEmpty())
            {
                return false;
            }

            node = node.next;
            return true;
        }

        public int Front()
        {
            if(node == null)
            {
                return -1;
            }
            return node.val;
        }

        public int Rear()
        {
            if (node == null)
            {
                return -1;
            }

            ListNode pointer = node;
            while(pointer.next != null)
            {
                pointer = pointer.next;
            }

            return pointer.val;
        }

        public bool IsEmpty()
        {
            return node == null;
        }

        public bool IsFull()
        {
            int c = 0;
            if (node != null)
            {
                c = 1;
                ListNode pointer = node;
                while (pointer.next != null)
                {
                    pointer = pointer.next;
                    c++;
                }
            }

            return c >= _size;
        }
    }
}
