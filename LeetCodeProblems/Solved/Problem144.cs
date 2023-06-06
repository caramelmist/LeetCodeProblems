using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem144 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(1, null, new TreeNode(2, new TreeNode(3)));
            IList<int> actual = PreorderTraversal(root);
            IList<int> expected = new List<int>() { 1, 2, 3 };
            Console.WriteLine("Outcome: {0}", expected.SequenceEqual(actual));

            root = null;
            actual = PreorderTraversal(root);
            expected = new List<int>();
            Console.WriteLine("Outcome: {0}", expected.SequenceEqual(actual));

            root = new TreeNode(1);
            actual = PreorderTraversal(root);
            expected = new List<int>() { 1 };
            Console.WriteLine("Outcome: {0}", expected.SequenceEqual(actual));
        }

        public IList<int> PreorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();

            AddToList(root, result);

            return result;
        }

        private void AddToList(TreeNode root, List<int> values)
        {
            if (root == null)
            {
                return;
            }
            values.Add(root.val);
            if (root.left != null)
            {
                AddToList(root.left, values);
            }
            if (root.right != null)
            {
                AddToList(root.right, values);
            }
        }
    }
}
