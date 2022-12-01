using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem222 : Solution
    {
        public void Run()
        {
            TreeNode root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6)));
            int actual = CountNodes(root);
            int expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6), new TreeNode(7)));
            actual = CountNodes(root);
            expected = 7;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(1);
            actual = CountNodes(root);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CountNodes(null);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(1, new TreeNode(2));
            actual = CountNodes(root);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            root = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
            actual = CountNodes(root);
            expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int CountNodes(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }

            int count = 0;
            bool hasFinalRight = true;

            while(root != null)
            {
                count++;
                if(root.right == null && root.left != null)
                {
                    hasFinalRight = false;
                    count++;
                }
                root = root.right;
            }

            int ret = 0;
            if (count == 1)
            {
                ret = 1;
            }
            else
            {
                ret = 3;
            }

            for (int i = 2; i < count; i++)
            {
                ret += (i * i);
            }
            
            if(!hasFinalRight)
            {
                ret--;
            }

            return ret;
        }
    }
}
