using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2 : Solution
    {
        public void Run()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Should be 708 was: {0}", answer.ToString());


            l1 = new ListNode(0);
            l2 = new ListNode(0);
            answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Should be 0 was: {0}", answer.ToString());

            l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Should be 89990001 was: {0}", answer.ToString());
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            ListNode pointer = answer;
            int carryOver = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    l1 = new ListNode();
                }
                else if (l2 == null)
                {
                    l2 = new ListNode();
                }

                int amount = l1.val + l2.val + carryOver;
                carryOver = amount / 10;
                pointer.val = amount % 10;

                l1 = l1.next;
                l2 = l2.next;

                if (l1 != null || l2 != null)
                {
                    pointer.next = new ListNode();
                    pointer = pointer.next;
                }
                else if (carryOver > 0)
                {
                    pointer.next = new ListNode(carryOver);
                    pointer = pointer.next;
                }
            }

            return answer;
        }
    }
}
