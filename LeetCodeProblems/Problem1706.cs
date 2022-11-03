using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1706 : Solution
    {
        public void Run()
        {
            int[] actual = FindBall(new int[][] { new int[] { 1, 1, 1, -1, -1 }, new int[] { 1, 1, 1, -1, -1 }, new int[] { -1, -1, -1, 1, 1 }, new int[] { 1, 1, 1, 1, -1 }, new int[] { -1, -1, -1, -1, -1 } });
            int[] expected = new int[] { 1, -1, -1,-1, -1 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = FindBall(new int[][] { new int[] { -1 } });
            expected = new int[] { -1 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = FindBall(new int[][] { new int[] { 1, 1, 1, -1, -1 }, new int[] { 1, 1, 1, -1, -1 }, new int[] { -1, -1, -1, 1, 1 }, new int[] { 1, 1, 1, 1, -1 }, new int[] { -1, -1, -1, -1, -1 } });
            expected = new int[] { 0, 1, 2, 3, 4, -1 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
        }

        public int[] FindBall(int[][] grid)
        {
            int hLen = grid[0].Length;
            int vLen = grid.Length;

            int[] result = Enumerable.Repeat(-1, hLen).ToArray();

            for (int i = 0; i < hLen; i++)
            {
                bool terminated = false;
                int x = i;
                int y = 0;
                while (!terminated && y <= (vLen - 1))
                {
                    if (grid[y][x] == -1 && x == 0)
                    {
                        terminated = true;
                        break;
                    }

                    if (grid[y][x] == 1 && x == (hLen - 1))
                    {
                        terminated = true;
                        break;
                    }

                    if (grid[y][x] == 1 && grid[y][x + 1] == -1)
                    {
                        terminated = true;
                        break;
                    }

                    x += grid[y][x];
                    y++;

                    if(y >= vLen-1)
                    {
                        x -= grid[y-1][x];
                        result[i] = x;
                    }
                }
            }

            return result;
        }
    }
}
