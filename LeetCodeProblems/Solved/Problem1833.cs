using System;
namespace LeetCodeProblems.Solved
{
    public class Problem1833 : Solution
    {
        public Problem1833()
        {
        }

        public void Run()
        {
            int actual = MaxIceCream(new int[] { 1, 3, 2, 4, 1 }, 7);
            int expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxIceCream(new int[] { 10, 6, 8, 7, 7, 8 }, 5);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxIceCream(new int[] { 1, 6, 3, 1, 2, 5 }, 20);
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }

        public int MaxIceCream(int[] costs, int coins)
        {
            Array.Sort(costs);

            int result = 0;
            for (int i = 0; i < costs.Length; i++)
            {
                if(coins >= costs[i])
                {
                    result++;
                    coins -= costs[i];
                }
                else
                {
                    break;
                }
            }

            return result;
        }
    }
}

