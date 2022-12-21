using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2256 : Solution
    {
        public void Run()
        {
            int actual = MinimumAverageDifference(new int[] { 2, 5, 3, 9, 5, 3 });
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinimumAverageDifference(new int[] { 0 });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MinimumAverageDifference(int[] nums)
        {
            return -1;
        }
    }
}
