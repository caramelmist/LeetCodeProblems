using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem739 : Solution
    {
        public void Run()
        {
            int[] actual = DailyTemperatures(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
            int[] expected = new int[] { 1, 1, 4, 2, 1, 1, 0, 0 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = DailyTemperatures(new int[] { 30, 40, 50, 60 });
            expected = new int[] { 1, 1, 1, 0 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = DailyTemperatures(new int[] { 30, 60, 90});
            expected = new int[] { 1, 1, 0 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
        }

        public int[] DailyTemperatures(int[] temperatures)
        {
            int[] ret = new int[temperatures.Length];

            for (int i = 0; i < temperatures.Length; i++)
            {

            }

            return ret;
        }
    }
}
