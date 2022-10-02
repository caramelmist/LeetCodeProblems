using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem218 : Solution
    {
        public void Run()
        {
            IList<IList<int>> actual = GetSkyline(new int[][] { new int[] { 2, 9, 10 }, new int[] { 3, 7, 15 }, new int[] { 5, 12, 12 }, new int[] { 15, 20, 10 }, new int[] { 19, 24, 8 } });
            IList<IList<int>> expected = new int[][] { new int[] { 2, 10 }, new int[] { 3, 15 }, new int[] { 7, 12 }, new int[] { 12, 0 }, new int[] { 15, 10 }, new int[] { 20, 8 }, new int[] { 24, 0 } };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));

            actual = GetSkyline(new int[][] { new int[] { 0, 2, 3 } });
            expected = new int[][] { new int[] { 0, 3 }, new int[] { 2, 0 } };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));

            actual = GetSkyline(new int[][] { new int[] { 0, 2, 3 }, new int[] { 2, 5, 3 } });
            expected = new int[][] { new int[] { 0, 3 }, new int[] { 5, 0 } };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));
        }

        public IList<IList<int>> GetSkyline(int[][] buildings)
        {
            List<IList<int>> result = new List<IList<int>>();

            int finalX = -1;
            for (int i = 0; i < buildings.Length; i++)
            {
                int x = buildings[i][0];
                int y = buildings[i][2];
                result.Add(new List<int> { x, y });

                if (buildings[i][1] > finalX)
                {
                    finalX = buildings[i][1];
                }
            }

            result.Add(new List<int> { finalX, 0 });

            return result;
        }

        public IList<IList<int>> GetSkyline2(int[][] buildings)
        {
            List<IList<int>> result = new List<IList<int>>();

            int maxX = -1;
            int minX = int.MaxValue;
            int prevMax = int.MaxValue;
            int nextY = 0;

            while(true)
            {
                int y = 0;
                for (int i = 0; i < buildings.Length; i++)
                {
                    int x = buildings[i][1];
                    if (x > maxX && x < prevMax)
                    {
                        maxX = x;
                        y = buildings[i][2];
                    }
                    if(x < minX)
                    {
                        minX = x;
                    }
                }

                if(maxX == prevMax)
                {
                    result.Insert(0, new List<int>() { minX, nextY });
                    break;
                }

                result.Insert(0, new List<int>() { maxX, nextY });

                prevMax = maxX;
                maxX = -1;
                nextY = y;
            }

            return result;
        }
    }
}
