using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem112 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(5, new TreeNode(4, new TreeNode(11, new TreeNode(7), new TreeNode(2))), new TreeNode(8, new TreeNode(13), new TreeNode(4, null, new TreeNode(1))));
            bool actual = HasPathSum(root, 22);
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(1, new TreeNode(2), new TreeNode(3));
            actual = HasPathSum(root, 5);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode();
            actual = HasPathSum(null, 0);
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if(root == null)
            {
                return false;
            }
            return HasPathSum(root, targetSum, 0);
        }

        public bool HasPathSum(TreeNode root, int targetSum, int value)
        {
            int currentValue = value + root.value;
            if(root.left == null && root.right == null)
            {
                if( targetSum == currentValue)
                {
                    return true;
                }
            }
            
            if( root.left != null)
            {
                if(HasPathSum(root.left, targetSum, currentValue))
                {
                    return true;
                }
            }
            
            if (root.right != null)
            {
                if (HasPathSum(root.right, targetSum, currentValue))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
