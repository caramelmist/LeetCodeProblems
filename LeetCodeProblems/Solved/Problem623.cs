using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem623 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(1)), new TreeNode(6, new TreeNode(5)));
            TreeNode actual = AddOneRow(root, 1, 2);
            Console.WriteLine("Outcome: {0}", actual.WritePaths());

            root = new TreeNode(4, new TreeNode(2, new TreeNode(3), new TreeNode(1)));
            actual = AddOneRow(root, 1, 3);
            Console.WriteLine("Outcome: {0}", actual.WritePaths());

            root = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
            actual = AddOneRow(root, 5, 4);
            Console.WriteLine("Outcome: {0}", actual.WritePaths());
        }

        public TreeNode AddOneRow(TreeNode root, int val, int depth)
        {
            if (depth == 1)
            {
                TreeNode newKid = new TreeNode(val, root);
                return newKid;
            }

            List<TreeNode> refrs = new List<TreeNode>();
            refrs.Add(root);
            int c = 1;

            while (c < depth - 1)
            {
                int remove = refrs.Count;
                for (int i = 0; i < remove; i++)
                {
                    TreeNode refr = refrs[0];
                    if (refr.right != null)
                    {
                        refrs.Add(refr.right);
                    }
                    if (refr.left != null)
                    {
                        refrs.Add(refr.left);
                    }
                    refrs.RemoveAt(0);
                }
                c++;
            }

            foreach (TreeNode refr in refrs)
            {
                TreeNode? kid = refr.left;
                TreeNode newKid = new TreeNode(val, kid);
                refr.left = newKid;

                kid = refr.right;
                newKid = new TreeNode(val, null, kid);
                refr.right = newKid;
            }

            return root;
        }
    }
}
