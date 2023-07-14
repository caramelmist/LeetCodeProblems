using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
  public class Problem21 : Solution
  {
    public void Run()
    {
      ListNode actual = MergeTwoLists(new ListNode(1, new ListNode(3, new ListNode(4))), new ListNode(1, new ListNode(2, new ListNode(4))));
      ListNode expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4))))));
      Console.WriteLine("Outcome: {0}  {1}", expected, actual);

      actual = MergeTwoLists(new ListNode(1, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))), new ListNode(1, new ListNode(2, new ListNode(4))));
      expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, new ListNode(6))))))));
      Console.WriteLine("Outcome: {0}  {1}", expected, actual);

      actual = MergeTwoLists(new ListNode(1, new ListNode(3, new ListNode(4))), new ListNode(1, new ListNode(2, new ListNode(4, new ListNode(5, new ListNode(6))))));
      expected = new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(4, new ListNode(5, new ListNode(6))))))));
      Console.WriteLine("Outcome: {0}  {1}", expected, actual);

      actual = MergeTwoLists(new ListNode(), new ListNode());
      expected = new ListNode();
      Console.WriteLine("Outcome: {0}  {1}", expected, actual);

      actual = MergeTwoLists(new ListNode(), new ListNode(0));
      expected = new ListNode(0);
      Console.WriteLine("Outcome: {0}  {1}", expected, actual);
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
      if(list1 == null && list2 == null)
      {
        return null;
      }

      ListNode result = new ListNode();
      ListNode ret = new ListNode();
      result = ret;

      while (list1 != null || list2 != null)
      {
        if (list1 == null)
        {
          ret.val = list2.val;
          list2 = list2.next;
        }
        else if (list2 == null)
        {
          ret.val = list1.val;
          list1 = list1.next;
        }
        else
        {
          if(list1.val <= list2.val)
          {
            ret.val = list1.val;
            list1 = list1.next;
          }
          else
          {
            ret.val = list2.val;
            list2 = list2.next;
          }
        }
        if(list1 != null || list2 != null)
        {
          ret.next = new ListNode();
          ret = ret.next;
        }
      }

      return result;
    }

  }
}
