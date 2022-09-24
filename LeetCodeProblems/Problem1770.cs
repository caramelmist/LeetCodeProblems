using System;
namespace LeetCodeProblems
{
    public class Problem1770 : Solution
    {
        public Problem1770()
        {
        }

        public void Run()
        {
            int actual = MaximumScore(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 });
            int expected = 14;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaximumScore(new int[] { 4, 2, 1000, 1 }, new int[] { 2, 1 });
            expected = 1001;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaximumScore(new int[] { 1, 2, 3, 4 }, new int[] { 3, 2, 1 });
            expected = 20;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaximumScore(new int[] { -5, -3, -3, -2, 7, 1 }, new int[] { -10, -5, 3, 4, 6 });
            expected = 102;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaximumScore(new int[] { -5, -3, -3, 1000, 7, 1 }, new int[] { -10, -5, 3, 4 });
            expected = 4066;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaximumScore(new int[] { -5, -3, -3, 1000, 7, 1 }, new int[] { -10, -5, 3 });
            expected = 2955;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaximumScore(new int[] { 555, 526, 732, 182, 43, -537, -434, -233, -947, 968, -250, -10, 470, -867, -809, -987, 120, 607, -700, 25, -349, -657, 349, -75, -936, -473, 615, 691, -261, -517, -867, 527, 782, 939, -465, 12, 988, -78, -990, 504, -358, 491, 805, 756, -218, 513, -928, 579, 678, 10 },
                                    new int[] { 783, 911, 820, 37, 466, -251, 286, -74, -899, 586, 792, -643, -969, -267, 121, -656, 381, 871, 762, -355, 721, 753, -521 });
            expected = 6861161;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MaximumScore(int[] nums, int[] multipliers)
        {
            TreeNode root = new TreeNode();
            //root.Add(nums, multipliers);

            int score = 0; //root.GetScore();

            return score;
        }
    }
}

