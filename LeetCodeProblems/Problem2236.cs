using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2236 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(10, new TreeNode(4), new TreeNode(6));
            bool actual = CheckTree(root);
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(5, new TreeNode(3), new TreeNode(1));
            actual = CheckTree(root);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool CheckTree(TreeNode root)
        {
            return root.value == root.right.value + root.left.value;
        }
    }
}
