using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class TreeNodeExtensions
    {
        public static List<TreeNode> GetLeaves(this TreeNode node)
        {
            List<TreeNode> s = new List<TreeNode>();
            if (node.right == null && node.left == null)
            {
                s.Add(node);
                return s;
            }
            if (node.right != null)
            {
                s.AddRange(node.right.GetLeaves());
            }
            if (node.left != null)
            {
                s.AddRange(node.left.GetLeaves());
            }

            return s;
        }

    }
}
