using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2215 : Solution
    {
        public void Run()
        {
            IList<IList<int>> actual = FindDifference(new int[] { 1, 2, 3 }, new int[] { 2, 4, 6 });
            IList<IList<int>> expected = new int[][] { new int[] { 1, 3 }, new int[] { 4, 6 } };
            //Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));

            actual = FindDifference(new int[] { 1,2,3,3 }, new int[] { 1,1,2,2 });
            expected = new int[][] { new int[] { 3 }, new int[] { } };
            //Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));
        }

        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            IList<IList<int>> result = new List<IList<int>>
            {
                new List<int>(),
                new List<int>()
            };

            foreach (int item in nums1)
            {
                if (result[0].Contains(item))
                {
                    continue;
                }
                if (!nums2.Contains(item))
                {
                    result[0].Add(item);
                }
            }

            foreach (int item in nums2)
            {
                if (result[1].Contains(item))
                {
                    continue;
                }
                if (!nums1.Contains(item))
                {
                    result[1].Add(item);
                }
            }

            return result;
        }
    }
}
