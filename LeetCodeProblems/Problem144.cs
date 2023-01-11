using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem144 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(2, new TreeNode(3, new TreeNode(3), new TreeNode(1)), new TreeNode(1, null, new TreeNode(1)));
            IList<int> actual = PreorderTraversal(root);
            IList<int> expected = new List<int>() { 1, 2, 3 };
            Console.WriteLine("Outcome: {0}", expected.SequenceEqual(actual));

            root = new TreeNode(2, new TreeNode(1, new TreeNode(1), new TreeNode(3, null, new TreeNode(1))), new TreeNode(1));
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
            return new List<int>();
        }
    }
}
