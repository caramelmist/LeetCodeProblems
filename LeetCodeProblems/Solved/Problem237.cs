using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem237 : Solution
    {
        public void Run()
        {
            ListNode actual = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(9))));
            DeleteNode(actual.next);
            string expected = "4->1->9->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = new ListNode(4, new ListNode(5, new ListNode(1, new ListNode(9))));
            DeleteNode(actual.next.next);
            expected = "4->5->9->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());
        }

        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}
