using System;
namespace LeetCodeProblems
{
    public class Problem23 : Solution
    {
        public Problem23()
        {
        }

        public void Run()
        {
            ListNode actual = MergeKLists(new ListNode[] { new ListNode(1, new ListNode(4, new ListNode(5))),
                                                           new ListNode(1, new ListNode(3, new ListNode(4))),
                                                           new ListNode(2, new ListNode(6))});
            string expected = "1->1->2->3->4->4->5->6->";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);

            actual = MergeKLists(new ListNode[] {});
            expected = "";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);

            actual = MergeKLists(new ListNode[] { null });
            expected = "";
            Console.WriteLine("Outcome: {0}  {1}", expected, actual);
        }

        public ListNode MergeKLists(ListNode[] lists)
        {
            bool complete = false;
            ListNode temp = new ListNode();
            
            while (!complete)
            {
                complete = true;
                for (int i = 0; i < lists.Length; i++)
                {
                    if (lists[i] != null)
                    {
                        complete = false;
                        if (lists[i].val < temp.val)
                        {
                            temp = lists[i];
                        }
                    }
                }

            }

            return new ListNode();
        }
    }

    public static class ListNodeHelpers
    {
        public static string Print(this ListNode node)
        {
            string value = "";
            
            while (node != null)
            {
                value += (node.val + "->");
                node = node.next;
            }

            return value;
        }
    }
}

