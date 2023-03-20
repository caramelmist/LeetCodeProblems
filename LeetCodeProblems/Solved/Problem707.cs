using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem707 : Solution
    {
        public void Run()
        {
            MyLinkedList myLinkedList = new MyLinkedList();
            myLinkedList.AddAtHead(1);
            myLinkedList.AddAtTail(3);
            myLinkedList.AddAtIndex(1, 2);              // linked list becomes 1->2->3
            int value = myLinkedList.Get(1);            // return 2
            Console.WriteLine($"{value} : 2");
            myLinkedList.DeleteAtIndex(1);              // now the linked list is 1->3
            value = myLinkedList.Get(1);                // return 3
            Console.WriteLine($"{value} : 3");
        }
    }

    public class MyLinkedList
    {
        private List<int> _list = new List<int>();

        public MyLinkedList()
        {
        }

        public int Get(int index)
        {
            if(index < 0 || index > _list.Count - 1)
            {
                return -1;
            }
            return _list[index];
        }

        public void AddAtHead(int val)
        {
            _list.Insert(0, val);
        }

        public void AddAtTail(int val)
        {
            _list.Add(val);
        }

        public void AddAtIndex(int index, int val)
        {
            if (index == _list.Count)
            {
                _list.Add(val);
            }
            else if (index < _list.Count)
            {
                _list.Insert(index, val);
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index < 0 || index > _list.Count - 1)
            {
                return;
            }
            _list.RemoveAt(index);
        }
    }
}
