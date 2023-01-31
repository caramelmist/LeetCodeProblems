using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1443 : Solution
    {
        public void Run()
        {
            int actual = MinTime(7, new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 4 }, new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 2, 6 } }, new bool[] { false, false, true, false, true, true, false });
            int expected = 8;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinTime(7, new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 4 }, new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 2, 6 } }, new bool[] { false, false, true, false, false, true, false });
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinTime(7, new int[][] { new int[] { 0, 1 }, new int[] { 0, 2 }, new int[] { 1, 4 }, new int[] { 1, 5 }, new int[] { 2, 3 }, new int[] { 2, 6 } }, new bool[] { false, false, false, false, false, false, false });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinTime(4, new int[][] { new int[] { 0, 2 }, new int[] { 0, 3 }, new int[] { 1, 2 } }, new bool[] { false, true, false, false });
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }

        public int MinTime(int n, int[][] edges, IList<bool> hasApple)
        {
            List<int[]> paths = new List<int[]>();
            for (int i = 0; i < n; i++)
            {
                if (hasApple[i])
                {
                    StepsToZero(i, edges, paths);
                }
            }

            return paths.Count() * 2;
        }

        private void StepsToZero(int index, int[][] edges, List<int[]> paths)
        {
            while (index != 0)
            {
                bool found = false;
                for (int i = 0; i < edges.Length; i++)
                {
                    if (edges[i][1] == index)
                    {
                        found = true;
                        index = edges[i][0];
                        if (!paths.Contains(edges[i]))
                        {
                            paths.Add(edges[i]);
                        }
                        break;
                    }
                }

                if (!found)
                {
                    for (int i = 0; i < edges.Length; i++)
                    {
                        if (edges[i][0] == index)
                        {
                            found = true;
                            index = edges[i][1];
                            if (!paths.Contains(edges[i]))
                            {
                                paths.Add(edges[i]);
                            }
                            break;
                        }
                    }
                }
            }
        }
    }
}
