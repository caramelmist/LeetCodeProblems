using System;
namespace LeetCodeProblems
{
	public class Problem452: Solution
	{
		public Problem452()
		{
		}

        public void Run()
        {
            int actual = FindMinArrowShots(new int[][] { new int[] { 10, 16 }, new int[] { 2, 8 }, new int[] { 1, 6 }, new int[] { 7, 12 } });
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = FindMinArrowShots(new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 }, new int[] { 5, 6 }, new int[] { 7, 8 } });
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = FindMinArrowShots(new int[][] { new int[] { 1, 2 }, new int[] { 2, 3 }, new int[] { 3, 4 }, new int[] { 4, 5 } });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int FindMinArrowShots(int[][] points)
        {

        }

        private Dictionary<int, List<int[]>> GetIntersections(int[][] points)
        {
            Dictionary<int, List<int[]>> intersections = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < points.Length - 1; i++)
            {
                int start = points[i][0];
                int end = points[i][1];
                for (int j = start; j <= end; j++)
                {

                }
            }
        }
    }
}

