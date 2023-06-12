using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
  internal class Problem228 : Solution
  {
    public void Run()
    {
      IList<string> actual = SummaryRanges(new int[] { 0, 1, 2, 4, 5, 7 });
      IList<string> expected = new List<string> { "0->2", "4->5", "7" };
      Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

      actual = SummaryRanges(new int[] { 0, 2, 3, 4, 6, 8, 9 });
      expected = new List<string> { "0", "2->4", "6", "8->9" };
      Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

    }

    public IList<string> SummaryRanges(int[] nums)
    {
      List<string> strings = new List<string>();
      if(nums.Length < 1)
      {
        return strings;
      }

      strings.Add(nums[0].ToString());
      for (int i = 1; i < nums.Length; i++)
      {
        if (nums[i] - nums[i - 1] != 1)
        {
          string s = nums[i - 1].ToString();
          if (s != strings[strings.Count - 1])
          {
            strings[strings.Count - 1] += "->" + s;
          }
          strings.Add(nums[i].ToString());
        }
      }

      string st = nums[nums.Length - 1].ToString();
      if (st != strings[strings.Count - 1])
      {
        strings[strings.Count - 1] += "->" + st;
      }

      return strings;
    }
  }
}
