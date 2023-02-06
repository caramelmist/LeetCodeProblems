using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1470 : Solution
    {
        public void Run()
        {
            int[] actual = Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);
            int[] expected = new int[] { 2, 3, 5, 4, 1, 7 };
            Console.WriteLine("Outcome: {0}", actual.SequenceEqual(expected));

            actual = Shuffle(new int[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4);
            expected = new int[] { 1, 4, 2, 3, 3, 2, 4, 1 };
            Console.WriteLine("Outcome: {0}", actual.SequenceEqual(expected));

            actual = Shuffle(new int[] { 1, 1, 2, 2 }, 2);
            expected = new int[] { 1, 2, 1, 2 };
            Console.WriteLine("Outcome: {0}", actual.SequenceEqual(expected));
        }

        public int[] Shuffle(int[] nums, int n)
        {
            List<int> ret = new List<int>();
            for (int i = 0; i < n; i++)
            {
                ret.Add(nums[i]);
                ret.Add(nums[n + i]);
            }
            return ret.ToArray();
        }
    }
}
