using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem149 : Solution
    {
        public void Run()
        {
            int actual = MaxPoints(new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 } });
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxPoints(new int[][] { new int[] { 1, 1 }, new int[] { 3, 2 }, new int[] { 5, 3 }, new int[] { 4, 1 }, new int[] { 2, 3 }, new int[] { 1, 4 } });
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MaxPoints(int[][] points)
        {
            int maxPoints = 2;
            for (int i = 0; i < points.Length-1; i++)
            {
                for (int j = i+1; j < points.Length; j++)
                {
                    int count = 2;
                    for (int k = 0; k < points.Length; k++)
                    {
                        if (points[k] == points[i] || points[k] == points[j])
                        {
                            continue;
                        }

                        if (OnLine(points[i], points[j], points[k]))
                        {
                            count++;
                        }
                    }
                    if(maxPoints < count)
                    {
                        maxPoints = count;
                    }
                }
            }
            return maxPoints;
        }

        private bool OnLine(int[] a, int[] b, int[] toCheck)
        {
            int xMax = Math.Max(a[0], b[0]);
            int yMax = Math.Max(a[1], b[1]);
            int max = Math.Max(xMax, yMax);
            int len = Math.Abs(a[0] - b[0]);
            bool found = false;
            for (int i = 0; i <= len; i++)
            {
                if (toCheck[0] == i)
                {

                    found = true;
                    break;
                }
            }

            return false;
        }

        private bool OnLineEx(int[] a, int[] b, int[] toCheck)
        {
            double one = GetDistance(a, b);
            double two = GetDistance(b, toCheck);
            double three = GetDistance(a, toCheck);
            return one == two + three;
        }

        private bool IsSame(int[] a, int[] b)
        {
            return a[0] == b[0] && a[1] == b[1];
        }

        private double GetDistance(int[] a, int[] b)
        {
            return GetDistance(a[0], a[1], b[0], b[1]);
        }

        private double GetDistance(int x1, int y1, int x2, int y2)
        {
            int a = (x1 - x2) * (x1 - x2);
            int b = (y1 - y2) * (y1 - y2);
            double result = Math.Sqrt(a + b);
            return result;
        }
    }
}
