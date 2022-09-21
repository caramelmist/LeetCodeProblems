using System;
namespace LeetCodeProblems
{
    public class TreeNode
    {
        public int value;
        public TreeNode? left;
        public TreeNode? right;

        public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.value = val;
            this.left = left;
            this.right = right;
        }

        public void Add(int[] numbers, int[] multipliers)
        {
            if(multipliers.Length == 0)
            {
                return;
            }

            int multiplier = multipliers[0];

            int back = numbers[numbers.Length - 1];

            right = new TreeNode(value + (multiplier * back));

            int[] multipliersCopy = Copy(multipliers, multipliers.Length - 1, 1);
            int[] numbersCopy = Copy(numbers, numbers.Length - 1);
            right.Add(numbersCopy, multipliersCopy);

            int front = numbers[0];
            left = new TreeNode(value + (multiplier * front));
            int[] multipliersCopy2 = Copy(multipliers, multipliers.Length - 1, 1);
            int[] numbersCopy2 = Copy(numbers, numbers.Length - 1, 1);
            left.Add(numbersCopy2, multipliersCopy2);
        }

        public int GetScore()
        {
            if(right == null || left == null)
            {
                return value;
            }

            int r = right.GetScore();
            int l = left.GetScore();
            return r > l ? r : l;
        }

        private int[] Copy(int[] first, int length, int startIndex = 0)
        {
            int[] second = new int[length];
            for(int i = 0; i < length; i++)
            {
                second[i] = first[startIndex + i];
            }

            return second;
        }
    }
}
