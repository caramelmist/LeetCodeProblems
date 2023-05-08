using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1498 : Solution
    {
        public void Run()
        {
            int actual = NumSubseq(new int[] { 3, 5, 6, 7 }, 9);
            int expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumSubseq(new int[] { 3, 3, 6, 8 }, 10);
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumSubseq(new int[] { 2, 3, 3, 4, 6, 7 }, 12);
            expected = 61;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int NumSubseq(int[] nums, int target)
        {
            int result = 1;

            return result % 1000000007;
        }

    }
}
