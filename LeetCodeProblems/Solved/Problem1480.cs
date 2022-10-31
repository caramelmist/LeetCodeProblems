using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1480 : Solution
    {
        public void Run()
        {
            int[] actual = RunningSum(new int[] { 1, 2, 3, 4 });
            int[] expected = new int[] { 1, 3, 6, 10 };
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = RunningSum( new int[] { 1, 1, 1, 1, 1 });
            expected = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            runningSum[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                runningSum[i] = runningSum[i - 1] + nums[i];
            }
            return runningSum;
        }
    }
}
