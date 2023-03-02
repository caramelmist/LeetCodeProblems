using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem121 : Solution
    {
        public void Run()
        {
            int actual = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
            int expected = 5;
            Console.WriteLine("Outcome: {0}", actual == (expected));

            actual = MaxProfit(new int[] { 7, 6, 4, 3, 1 });
            expected = 0;
            Console.WriteLine("Outcome: {0}", actual == (expected));

        }

        public int MaxProfit(int[] prices)
        {
            int profit = 0;
            int min = -1;
            for (int i = 0; i < prices.Length-1; i++)
            {
                if(i > 0 && prices[i] >= min)
                {
                    continue;
                }
                min = prices[i];
                for (int j = i+1; j < prices.Length; j++)
                {
                    int value = prices[j] - prices[i];
                    if(value > profit)
                    {
                        profit = value;
                    }
                }
            }

            return profit;
        }
    }
}
