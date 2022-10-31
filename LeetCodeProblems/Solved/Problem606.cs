using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem606 : Solution
    {
        public void Run()
        {
            TreeNode node = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
            string answer = Tree2str(node);
            Console.WriteLine("Should be 1(2(4))(3) was: {0}", answer.ToString());
            Console.WriteLine("Test Passed: {0}", answer == "1(2(4))(3)");

            node = new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3));
            answer = Tree2str(node);
            Console.WriteLine("Should be 1(2()(4))(3) was: {0}", answer.ToString());
            Console.WriteLine("Test Passed: {0}", answer == "1(2()(4))(3)");
        }

        public string Tree2str(TreeNode root)
        {
            return root.GetTreeString();
        }
    }
}
