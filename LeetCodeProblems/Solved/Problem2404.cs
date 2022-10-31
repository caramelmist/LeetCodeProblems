using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2404 : Solution
    {
        public void Run()
        {
            int actual = MostFrequentEven(new int[] { 0, 1, 2, 2, 4, 4, 1 });
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MostFrequentEven(new int[] { 4, 4, 4, 9, 2, 4 });
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MostFrequentEven(int[] nums)
        {
            Dictionary<int, int> results = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (num % 2 == 0)
                {
                    if (!results.ContainsKey(num))
                    {
                        results[num] = 1;
                    }
                    else
                    {
                        results[num]++;
                    }
                }
            }
            int max = -1;
            int maxValue = -1;
            foreach (int key in results.Keys)
            {
                int value = results[key];
                if (value >= max)
                {
                    if (value == max && key > maxValue)
                    {
                        continue;
                    }

                    max = value;
                    maxValue = key;
                }
            }

            return maxValue;
        }
    }
}
