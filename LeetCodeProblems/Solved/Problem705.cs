using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem705 : Solution
    {
        public void Run()
        {
            MyHashSet myHashSet = new MyHashSet();
            myHashSet.Add(1);                           // set = [1]
            myHashSet.Add(2);                           // set = [1, 2]
            bool value = myHashSet.Contains(1);         // return True
            Console.WriteLine($"{value} - true");
            value = myHashSet.Contains(3);              // return False, (not found)
            Console.WriteLine($"{value} - false");
            myHashSet.Add(2);                           // set = [1, 2]
            value = myHashSet.Contains(2);              // return True
            Console.WriteLine($"{value} - true");
            myHashSet.Remove(2);                        // set = [1]
            value = myHashSet.Contains(2);              // return False, (already removed)
            Console.WriteLine($"{value} - false");
        }
    }

    public class MyHashSet
    {
        private List<int> _list = new List<int>();

        public MyHashSet()
        {
        }

        public void Add(int key)
        {
            if (_list.Contains(key))
            {
                return;
            }

            _list.Add(key);
        }

        public void Remove(int key)
        {
            _list.Remove(key);
        }

        public bool Contains(int key)
        {
            return _list.Contains(key);
        }
    }
}
