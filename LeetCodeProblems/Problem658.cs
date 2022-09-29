using System;
namespace LeetCodeProblems
{
    public class Problem658: Solution
    {
        public Problem658()
        {
        }

        public void Run()
        {
            int[] actual = FindClosestElements(new int[] { 1, 2, 3, 4, 5 }, 4, 3);
            int[] expected = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = FindClosestElements(new int[] { 1, 2, 3, 4, 5 }, 4, -1);
            expected = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

        }

        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            if(arr.Length == k)
            {
                return arr;
            }

            int[] result = new int[k];
            int closestIdx = -1;
            int diff = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                int dist = Math.Abs(arr[i] - x);
                if (dist < diff)
                {
                    diff = dist;
                    closestIdx = i;
                }
            }



            return result;
        }
    }
}

