using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2336 : Solution
    {
        public void Run()
        {
            SmallestInfiniteSet smallestInfiniteSet = new SmallestInfiniteSet();
            smallestInfiniteSet.AddBack(2);    // 2 is already in the set, so no change is made.
            int value = smallestInfiniteSet.PopSmallest(); // return 1, since 1 is the smallest number, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 1, value);
            value = smallestInfiniteSet.PopSmallest(); // return 2, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 2, value);
            value = smallestInfiniteSet.PopSmallest(); // return 3, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 3, value);
            smallestInfiniteSet.AddBack(1);    // 1 is added back to the set.
            value = smallestInfiniteSet.PopSmallest(); // return 1, since 1 was added back to the set and is the smallest number, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 1, value);
            value = smallestInfiniteSet.PopSmallest(); // return 4, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 4, value);
            value = smallestInfiniteSet.PopSmallest(); // return 5, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 5, value);

            smallestInfiniteSet.AddBack(5);    // 5 is added back to the set.
            smallestInfiniteSet.AddBack(2);    // 2 is added back to the set.
            value = smallestInfiniteSet.PopSmallest(); // return 2, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 2, value);
            value = smallestInfiniteSet.PopSmallest(); // return 5, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 5, value);
            value = smallestInfiniteSet.PopSmallest(); // return 6, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 6, value);

            smallestInfiniteSet.AddBack(6);    // 6 is added back to the set.
            smallestInfiniteSet.AddBack(6);    // 6 is added back to the set.

            value = smallestInfiniteSet.PopSmallest(); // return 6, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 6, value);

            value = smallestInfiniteSet.PopSmallest(); // return 7, and remove it from the set.
            Console.WriteLine("Outcome: {0} {1}", 7, value);
        }
    }

    public class SmallestInfiniteSet
    {
        private List<int> _added = new List<int>();
        private int _current = 0;

        public SmallestInfiniteSet()
        {
        }

        public int PopSmallest()
        {
            if(_added.Count > 0)
            {
                int v = _added.Min();
                _added.Remove(v);
                return v;
            }
            _current++;
            return _current;
        }

        public void AddBack(int num)
        {
            if(_current >= num && !_added.Contains(num))
            {
                _added.Add(num);
            }
        }
    }
}
