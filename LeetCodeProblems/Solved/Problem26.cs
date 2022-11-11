using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem26 : Solution
    {
        public void Run()
        {
            int actual = RemoveDuplicates(new int[] { 1, 1, 2 });
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = RemoveDuplicates(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 });
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int RemoveDuplicates(int[] nums)
        {
            int c = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[c])
                {
                    c++;
                    nums[c] = nums[i];
                }
            }

            return c + 1;
        }
    }
}
