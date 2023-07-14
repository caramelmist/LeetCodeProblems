using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2352 : Solution
    {
        public void Run()
        {
            int actual = EqualPairs(new int[][] { new int[] { 3, 2, 1 }, new int[] { 1, 7, 6 }, new int[] { 2, 7, 7 } });
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EqualPairs(new int[][] { new int[] { 3, 1, 2, 2 }, new int[] { 1, 4, 4, 5 }, new int[] { 2, 4, 2, 2 }, new int[] { 2, 4, 2, 2 } });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int EqualPairs(int[][] grid)
        {
            int total = 0;

            for (int i = 0; i < grid.Length; i++)
            {
                total += EqualPairs(grid[i], grid);
            }

            return total;
        }

        private int EqualPairs(int[] match, int[][] grid)
        {
            int total = 0;
            for (int x = 0; x < match.Length; x++)
            {
                bool isSame = true;
                for (int y = 0; y < match.Length; y++)
                {
                    if (match[y] != grid[y][x])
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    total++;
                }
            }
            return total;
        }
    }
}
