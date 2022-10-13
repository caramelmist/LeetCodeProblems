using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem976 : Solution
    {
        public void Run()
        {
            int actual = LargestPerimeter(new int[]{ 2, 1, 2});
            int expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = LargestPerimeter(new int[] { 1, 2, 1 });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int LargestPerimeter(int[] nums)
        {
            return 0;
        }
    }
}
