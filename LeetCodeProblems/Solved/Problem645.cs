using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem645 : Solution
    {
        public void Run()
        {
            int[] actual = FindErrorNums(new int[] { 1, 2, 2, 4 });
            int[] expected = new int[] { 2, 3 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = FindErrorNums(new int[] { 1, 1 });
            expected = new int[] { 1, 2 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = FindErrorNums(new int[] { 3, 2, 2 });
            expected = new int[] { 2, 1 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = FindErrorNums(new int[] { 3, 2, 3, 4, 6, 5 });
            expected = new int[] { 3, 1 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));
        }

        public int[] FindErrorNums(int[] nums)
        {

            int[] result = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        result[0] = nums[i];
                        break;
                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!nums.Contains(i + 1))
                {
                    result[1] = i + 1;
                    break;
                }
            }

            return result;
        }

        public int[] FindErrorNums2(int[] nums)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    result[0] = nums[i];
                    result[1] = i + 1;
                    break;
                }
            }
            return result;
        }
    }
}
