using System;
namespace LeetCodeProblems.Solved
{
    public class Problem1523 : Solution
    {
        public Problem1523()
        {
        }

        public void Run()
        {
            int actual = CountOdds(3, 7);
            int expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(8, 10);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(1, 3);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(2, 4);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(1, 5);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(1, 6);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(2, 6);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(2, 8);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(1, 8);
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountOdds(0, 8);
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }

        public int CountOdds(int low, int high)
        {
            int v = (high - low) / 2;

            if (high % 2 == 1)
            {
                v++;
            }
            else if (low % 2 == 1)
            {
                v++;
            }

            return v;
        }
    }
}

