using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1155 : Solution
    {
        public void Run()
        {
            int actual = NumRollsToTarget(1, 6, 3);
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumRollsToTarget(2, 6, 7);
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumRollsToTarget(30, 30, 500);
            expected = 222616187;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int NumRollsToTarget(int n, int k, int target)
        {
            int result = 0;

            int[] reels = new int[n];

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {

                }
            }

            return result % 1000000007;
        }
    }
}
