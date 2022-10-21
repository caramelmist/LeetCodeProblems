using System;
namespace LeetCodeProblems
{
    public class Problem219: Solution
    {
        public Problem219()
        {
        }

        public void Run()
        {
            bool actual = ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3);
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ContainsNearbyDuplicate(new int[] { 99, 99}, 2);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            for(int i = 0; i < nums.Length - 1; i++)
            {
                int lim = Math.Min(i + k + 1, nums.Length);
                for (int j = i+1; j < lim; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}

