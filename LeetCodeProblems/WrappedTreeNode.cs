using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class WrappedTreeNode
    {
        public WrappedTreeNode? parent;
        public TreeNode wrapped;
        public WrappedTreeNode? left;
        public WrappedTreeNode? right;

        public WrappedTreeNode(TreeNode root, WrappedTreeNode? p = null)
        {
            wrapped = root;
            parent = p;

            if(root == null)
            {
                return;
            }

            if(root.left != null)
            {
                this.left = new WrappedTreeNode(root.left, this);
            }

            if (root.right != null)
            {
                this.right = new WrappedTreeNode(root.right, this);
            }
        }

        public List<WrappedTreeNode> GetLeaves()
        {
            List<WrappedTreeNode> s = new List<WrappedTreeNode>();
            if(right == null && left == null)
            {
                s.Add(this);
                return s;
            }
            if (right != null)
            {
                s.AddRange(right.GetLeaves());
            }
            if (left != null)
            {
                s.AddRange(left.GetLeaves());
            }

            return s;
        }

        public int GetBranchSum()
        {
            int sum = 0;

            if (parent != null)
            {
                sum += parent.GetBranchSum();
            }

            sum += wrapped.value;

            return sum;
        }

        public List<int> GetBranchDetails()
        {
            List<int> values = new List<int>();
            if (wrapped == null)
            {
                return values;
            }
            if(parent != null)
            {
                values.AddRange(parent.GetBranchDetails());
            }
            values.Add(wrapped.value);
            return values;
        }
    }
}
