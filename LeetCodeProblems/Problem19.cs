using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem19 : Solution
    {
        public void Run()
        {
            ListNode actual = RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))), 2);
            string expected = "1->2->3->5->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = RemoveNthFromEnd(new ListNode(1), 1);
            expected = "";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = RemoveNthFromEnd(new ListNode(1, new ListNode(2)), 1);
            expected = "1->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = RemoveNthFromEnd(new ListNode(1, new ListNode(2)), 2);
            expected = "2->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = RemoveNthFromEnd(new ListNode(1, new ListNode(2, new ListNode(3))), 1);
            expected = "1->2->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());
        }

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if(head.next == null)
            {
                return null;
            }

            List<ListNode> references = new List<ListNode>();
            ListNode? refr = head;

            while (refr != null)
            {
                references.Add(refr);
                refr = refr.next;
            }

            if(n == 1)
            {
                references[references.Count - 2].next = null;
            }
            else if (references.Count - n == 0)
            {
                head = head.next;
            }
            else
            {
                references[references.Count - n - 1].next = references[references.Count - n + 1];
            }

            return head;
        }
    }
}
