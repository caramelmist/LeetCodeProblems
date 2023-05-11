using System;
namespace LeetCodeProblems.Solved
{
    public class Problem1035 : Solution
    {
        public Problem1035()
        {
        }

        public void Run()
        {
            int actual = MaxUncrossedLines(new int[] { 1, 4, 2 }, new int[] { 1, 2, 4 });
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxUncrossedLines(new int[] { 2, 5, 1, 2, 5 }, new int[] { 10, 5, 2, 1, 5, 2 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxUncrossedLines(new int[] { 1, 3, 7, 1, 7, 5 }, new int[] { 1, 9, 2, 5, 1 });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MaxUncrossedLines(int[] nums1, int[] nums2)
        {
            List<(int, int)> pairs = new List<(int, int)>();
            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        pairs.Add((i, j));
                    }
                }
            }

            return pairs.Count;
        }
    }
}

