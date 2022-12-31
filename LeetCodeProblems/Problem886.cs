using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem886 : Solution
    {
        public void Run()
        {
            bool actual = PossibleBipartition(4, new int[][] { new int[] { 1, 2 }, new int[] { 1, 3 }, new int[] { 2, 4 } });
            bool expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = PossibleBipartition(3, new int[][] { new int[] { 1, 2 }, new int[] { 1, 3 }, new int[] { 2, 3 } });
            expected = false;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = PossibleBipartition(5, new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 }, new int[] { 1, 5 } });
            expected = false;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = PossibleBipartition(4, new int[][] { new int[] { 1, 2 }, new int[] { 4, 3 }, new int[] { 3, 1 } });
            expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);

            actual = PossibleBipartition(4, new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 3, 1 } });
            expected = true;
            Console.WriteLine("Expected matches actual: {0}", expected == actual);
        }

        public bool PossibleBipartition(int n, int[][] dislikes)
        {
            if (n < 2)
            {
                return false;
            }

            if (dislikes.Length < 1)
            {
                return true;
            }

            List<int> groupA = new List<int>();
            List<int> groupB = new List<int>();
            groupA.Add(dislikes[0][0]);
            groupB.Add(dislikes[0][1]);
            List<int> grouped = new List<int>() { 0 };

            while (grouped.Count != dislikes.Length)
            {
                for (int i = 1; i < dislikes.Length; i++)
                {
                    if (grouped.Contains(i))
                    {
                        continue;
                    }
                    int first = dislikes[i][0];
                    int second = dislikes[i][1];

                    if (groupA.Contains(first))
                    {
                        groupB.Add(second);
                    }
                }
            }

            return false;
        }

        private bool HasBoth(List<int> group, int a, int b)
        {
            return group.Contains(a) && group.Contains(b);
        }

    }
}
