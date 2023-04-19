using System;
namespace LeetCodeProblems.Solved
{
	public class Problem1768: Solution
	{
		public Problem1768()
		{
		}

        public void Run()
        {
            string actual = MergeAlternately("abc", "pqr");
            string expected = "apbqcr";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MergeAlternately("ab", "pqrs");
            expected = "apbqrs";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MergeAlternately("abcd", "pq");
            expected = "apbqcd";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string MergeAlternately(string word1, string word2)
        {
            string ret = "";
            for (int i = 0; i < word1.Length || i < word2.Length; i++)
            {
                if (i < word1.Length)
                {
                    ret += word1[i];
                }
                if (i < word2.Length)
                {
                    ret += word2[i];
                }
            }

            return ret;
        }
    }
}

