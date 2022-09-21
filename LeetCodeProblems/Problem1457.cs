using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1457 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(2, new TreeNode(3, new TreeNode(3), new TreeNode(1)), new TreeNode(1, null, new TreeNode(1)));
            int actual = PseudoPalindromicPaths(root);
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(2, new TreeNode(1, new TreeNode(1), new TreeNode(3, null, new TreeNode(1))), new TreeNode(1));
            actual = PseudoPalindromicPaths(root);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(9);
            actual = PseudoPalindromicPaths(root);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int PseudoPalindromicPaths(TreeNode root)
        {
            Console.WriteLine(root.WritePaths());
            return 0;
        }
    }

    public static class TreenodeExtensions 
    {
        public static string WritePaths( this TreeNode node)
        {
            string ret = "[" + node.val;
            if (node.right != null)
            {
                ret = ret + "," + node.right.WritePaths() + "]";
            }
            if (node.left != null)
            {
                ret = ret + "," + node.left.WritePaths() + "]";
            }

            return ret;
        }
    }
}
