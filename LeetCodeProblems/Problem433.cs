using System;
namespace LeetCodeProblems
{
    public class Problem433: Solution
    {
        public Problem433()
        {
        }

        public void Run()
        {
            int actual = MinMutation("AACCGGTT", "AACCGGTA", new string[] { "AACCGGTA" });
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinMutation("AACCGGTT", "AAACGGTA", new string[] { "AACCGGTA", "AACCGCTA", "AAACGGTA" });
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinMutation("AAAAACCC", "AACCCCCC", new string[] { "AAAACCCC", "AAACCCCC", "AACCCCCC" });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MinMutation(string start, string end, string[] bank)
        {
            return 0;
        }
    }
}

