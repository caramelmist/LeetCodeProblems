using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem2348 : Solution
    {
        public void Run()
        {
            long actual = ZeroFilledSubarray(new int[] { 1, 3, 0, 0, 2, 0, 0, 4 });
            long expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] { 0, 0, 0, 2, 0, 0 });
            expected = 9;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] { 2, 10, 2019 });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] { 0});
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] { 0, 0 });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] { 0, 0, 0 });
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] { 0, 0, 0, 0 });
            expected = 10;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(new int[] {});
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ZeroFilledSubarray(null);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            int[] ints = new int[100000];
            for (int i = 0; i < ints.Length; i++)
            {
                ints[i] = 0;
            }
            actual = ZeroFilledSubarray(ints);
            expected = 5000050000;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public long ZeroFilledSubarray(int[] nums)
        {
            if (nums == null || nums.Length < 1)
            {
                return 0;
            }

            long len = nums.Length;
            IEnumerable<int> n = nums.Distinct();
            if (n.Count() == 1)
            {
                if (n.First() == 0)
                {
                    return ((len+1)*len)/2;
                }
                else
                {
                    return 0;
                }
            }

            long total = 0;

            for (int i = 0; i < len; i++)
            {
                int idx = i;
                if (nums[i] == 0)
                {
                    do
                    {
                        total++;
                        idx--;
                        if(idx < 0)
                        {
                            break;
                        }
                    }while(nums[idx] == 0);
                }
            }

            return total;
        }
    }
}
