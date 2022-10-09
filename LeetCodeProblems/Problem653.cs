using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem653 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7)));
            bool actual = FindTarget(root, 9);
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(5, new TreeNode(3, new TreeNode(2), new TreeNode(4)), new TreeNode(6, null, new TreeNode(7)));
            actual = FindTarget(root, 28);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(2, new TreeNode(1), new TreeNode(3));
            actual = FindTarget(root, 4);
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }
            return FindTarget(root, k, new List<int>());
        }

        private bool FindTarget(TreeNode root, int k, List<int> list)
        {
            list.Add(root.val);

            if(root.left != null)
            {
                int v = root.left.val;
                int f = k - v;
                if (list.Contains(f) || FindTarget(root.left, k, list))
                {
                    return true;
                }
            }

            if (root.right != null)
            {
                int v = root.right.val;
                int f = k - v;
                if (list.Contains(f) || FindTarget(root.right, k, list))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
