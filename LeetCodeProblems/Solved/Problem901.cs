using System;
namespace LeetCodeProblems
{
    public class Problem901: Solution
    {
        public Problem901()
        {
        }

        public void Run()
        {
            StockSpanner ss = new StockSpanner();
            int value = ss.Next(100);
            Console.WriteLine("Passed: {0}", value == 1);
            value = ss.Next(80);
            Console.WriteLine("Passed: {0}", value == 1);
            value = ss.Next(60);
            Console.WriteLine("Passed: {0}", value == 1);
            value = ss.Next(70);
            Console.WriteLine("Passed: {0}", value == 2);
            value = ss.Next(60);
            Console.WriteLine("Passed: {0}", value == 1);
            value = ss.Next(75);
            Console.WriteLine("Passed: {0}", value == 4);
            value = ss.Next(85);
            Console.WriteLine("Passed: {0}", value == 6);
        }
    }

    public class StockSpanner
    {
        private List<int> _prices = new List<int>();

        public StockSpanner()
        {

        }

        public int Next(int price)
        {
            _prices.Add(price);
            int c = 0;
            for (int i = _prices.Count-1; i >= 0; i--)
            {
                if (_prices[i] > price)
                {
                    return c;
                }
                else
                {
                    c++;
                }
            }

            return c;
        }
    }
}

