using System;
namespace LeetCodeProblems
{
	public class Problem783: Solution
	{
		public Problem783()
		{
		}

        public void Run()
        {
            TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(1), new TreeNode(3)), new TreeNode(6));
            int actual = MinDiffInBST(root);
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(1, new TreeNode(0), new TreeNode(48, new TreeNode(12), new TreeNode(49)));
            actual = MinDiffInBST(root);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }

        public int MinDiffInBST(TreeNode root)
        {
            List<int> values = new List<int>();

            GetValues(root, values);
            values.Sort();
            int min = int.MaxValue;
            int value = 0;

            for (int i = values.Count-2; i >= 0; i--)
            {
                value = values[i + 1] - values[i];
                if (value < min)
                {
                    min = value;
                }
            }

            return min;
        }

        private void GetValues(TreeNode root, List<int> values)
        {
            if (root != null)
            {
                values.Add(root.val);
            }
            if (root.right != null)
            {
                GetValues(root.right, values);
            }
            if (root.left != null)
            {
                GetValues(root.left, values);
            }
        }
    }
}

