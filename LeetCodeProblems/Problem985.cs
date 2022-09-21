using System;
namespace LeetCodeProblems
{
    public class Problem985 : Solution
    {
        public Problem985()
        {
        }

        public void Run()
        {
            int[] actual = SumEvenAfterQueries(new int[] { 1, 2, 3, 4 }, new int[][] { new int[] { 1, 0 }, new int[] { -3, 1 }, new int[] { -4, 0 }, new int[] { 2, 3 } });
            int[] expected = new int[] { 8, 6, 2, 4 };
            Console.WriteLine("Outcome: {0} {1}", String.Join(',', expected), String.Join(',', actual));

            actual = SumEvenAfterQueries(new int[] { 1 }, new int[][] { new int[] { 4, 0 } });
            expected = new int[] { 0 };
            Console.WriteLine("Outcome: {0} {1}", String.Join(',', expected), String.Join(',', actual));
        }

        public int[] SumEvenAfterQueries(int[] nums, int[][] queries)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    sum += nums[i];
                }
            }

            int[] answer = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                int index = queries[i][1];
                if (nums[index] % 2 == 0)
                {
                    sum -= nums[index];
                }

                nums[index] = nums[index] + queries[i][0];
                if (nums[index] % 2 == 0)
                {
                    sum += nums[index];
                }

                answer[i] = sum;
            }

            return answer;
        }
    }
}

