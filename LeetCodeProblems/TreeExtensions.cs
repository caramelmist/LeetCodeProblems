using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public static class TreeExtensions
    {
        public static string GetTreeString(this TreeNode node)
        {
            string output = "";
            if (node != null)
            {
                output += node.val;
            }
            if (node.left != null)
            {
                output += "(" + node.left.GetTreeString() + ")";
            }
            else if (node.right != null)
            {
                output += "()";
            }

            if (node.right != null)
            {
                output += "(" + node.right.GetTreeString() + ")";
            }

            return output;
        }
    }
}
