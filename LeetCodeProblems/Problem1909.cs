using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1909 : Solution
    {
        public void Run()
        {
            bool actual = CanBeIncreasing(new int[] { 1, 2, 10, 5, 7 });
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanBeIncreasing(new int[] { 2,3,1,2 });
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanBeIncreasing(new int[] { 1, 1, 1 });
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CanBeIncreasing(new int[] { 105, 924, 32, 968 });
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool CanBeIncreasing(int[] nums)
        {
            bool found = false;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i-1] >= nums[i])
                {
                    if (found)
                    {
                        return false;
                    }
                    found = true;

                    int idx = i + 1;
                    if (idx < nums.Length && nums[i-1] >= nums[idx])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
