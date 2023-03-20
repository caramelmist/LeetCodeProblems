using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem706 : Solution
    {
        public void Run()
        {
            MyHashMap myHashMap = new MyHashMap();
            myHashMap.Put(1, 1); // The map is now [[1,1]]
            myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
            int value = myHashMap.Get(1);    // return 1, The map is now [[1,1], [2,2]]
            Console.WriteLine($"{value} - 1");
            value = myHashMap.Get(3);    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
            Console.WriteLine($"{value} - -1");
            myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
            value = myHashMap.Get(2);    // return 1, The map is now [[1,1], [2,1]]
            Console.WriteLine($"{value} - 1");
            myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
            value = myHashMap.Get(2);    // return -1 (i.e., not found), The map is now [[1,1]]
            Console.WriteLine($"{value} - -1");
        }
    }

    public class MyHashMap
    {
        private Dictionary<int, int> _map = new Dictionary<int, int>();

        public MyHashMap()
        {
        }

        public void Put(int key, int value)
        {
            if (_map.ContainsKey(key))
            {
                _map[key] = value;
            }
            else
            {
                _map.Add(key, value);
            }
        }

        public int Get(int key)
        {
            if (_map.ContainsKey(key))
            {
                return _map[key];
            }
            return -1;
        }

        public void Remove(int key)
        {
            if (_map.ContainsKey(key))
            {
                _map.Remove(key);
            }
        }
    }
}
