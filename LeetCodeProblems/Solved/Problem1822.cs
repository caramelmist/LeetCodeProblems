using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem1822 : Solution
    {
        public void Run()
        {
            int actual = ArraySign(new int[] { -1, -2, -3, -4, 3, 2, 1 });
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ArraySign(new int[] { 1, 5, 0, 2, -3 });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ArraySign(new int[] { -1, 1, -1, 1, -1 });
            expected = -1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int ArraySign(int[] nums)
        {
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    return 0;
                }
                else if (nums[i] < 0)
                {
                    result *= -1;
                }
            }

            return result;
        }
    }
}
