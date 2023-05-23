using System;
namespace LeetCodeProblems
{
	public class Problem347: Solution
	{
		public Problem347()
		{
		}

        public void Run()
        {
            int[] actual = TopKFrequent(new int[] { 1, 1, 1, 2, 2, 3 }, 2);
            int[] expected = new int[] { 1, 2 };
            Console.WriteLine("Outcome: {0}", actual.SequenceEqual(expected));

            actual = TopKFrequent(new int[] { 1 }, 1);
            expected = new int[] { 1 };
            Console.WriteLine("Outcome: {0}", actual.SequenceEqual(expected));
        }

        public int[] TopKFrequent(int[] nums, int k)
        {
            int[] answer = new int[k];

            for (int i = 0; i < nums.Length; i++)
            {

            }

            return answer;
        }
    }
}

