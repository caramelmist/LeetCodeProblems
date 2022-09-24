using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem113 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))), new TreeNode(8, new TreeNode(13), new TreeNode(4, new TreeNode(5), new TreeNode(1))));
            IList<IList<int>> actual = PathSum(root, 22);
            IList<IList<int>> expected = new List<IList<int>>();
            expected.Add(new List<int>() { 5, 4, 11, 2 });
            expected.Add(new List<int>() { 5, 8, 4, 5 });
            Console.WriteLine("Outcome: {0} {1}", expected.Count, actual.Count);

            root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            actual = PathSum(root, 5);
            expected = new List<IList<int>>();
            Console.WriteLine("Outcome: {0} {1}", expected.Count, actual.Count);

            root = new TreeNode();
            actual = PathSum(null, 1);
            expected = new List<IList<int>>();
            Console.WriteLine("Outcome: {0} {1}", expected.Count, actual.Count);

            root = new TreeNode();
            actual = PathSum(null, 0);
            expected = new List<IList<int>>();
            Console.WriteLine("Outcome: {0} {1}", expected.Count, actual.Count);
        }

        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            if(root == null)
            {
                return new List<IList<int>>();
            }
            WrappedTreeNode wrapped = new WrappedTreeNode(root);
            List<WrappedTreeNode> wraps = wrapped.GetLeaves();
            List<IList<int>> result = new List<IList<int>>();
            foreach(WrappedTreeNode w in wraps)
            {
                List<int> values = w.GetBranchDetails();
                int value = values.Sum();
                if(value == targetSum)
                {
                    result.Add(values);
                }
            }
            return result;
        }
    }
}
