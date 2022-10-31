using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2095 : Solution
    {
        public void Run()
        {
            ListNode actual = new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(7, new ListNode(1, new ListNode(2, new ListNode(6)))))));
            actual = DeleteMiddle(actual);
            string expected = "1->3->4->1->2->6->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            actual = DeleteMiddle(actual);
            expected = "1->2->4->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = new ListNode(2, new ListNode(1));
            actual = DeleteMiddle(actual);
            expected = "2->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());

            actual = new ListNode(2);
            actual = DeleteMiddle(actual);
            expected = "";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual.Print());
        }

        public ListNode DeleteMiddle(ListNode head)
        {
            List<ListNode> references = new List<ListNode>();
            ListNode refr = head;
            while (refr != null)
            {
                references.Add(refr);
                refr = refr.next;
            }

            if (references.Count > 2)
            {
                refr = references[references.Count / 2];
                refr.val = refr.next.val;
                refr.next = refr.next.next;
            }
            else if (references.Count == 2)
            {
                refr = references[0];
                refr.next = null;
            }
            else if (references.Count == 1)
            {
                return null;
            }

            return head;
        }

        public ListNode DeleteMiddle2(ListNode head)
        {
            ListNode refr = head;
            ListNode remove = null;
            int c = 1;
            while (refr != null)
            {
                c++;
                if (c % 2 == 0)
                {
                    if (c == 2)
                    {
                        remove = head;
                    }
                    else
                    {
                        remove = remove.next;
                    }
                }
                refr = refr.next;
            }

            if (remove != null)
            {
                remove.val = remove.next.val;
                remove.next = remove.next.next;
            }

            return head;
        }
    }
}
