using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem49 : Solution
    {
        public void Run()
        {
            IList<IList<string>> actual = GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            IList<IList<string>> expected = new string[][] { new string[] { "ate", "eat", "tea" }, new string[] { "nat", "tan" }, new string[] { "bat" } };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));

            actual = GroupAnagrams(new string[] { "" });
            expected = new string[][] { new string[] { "" } };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));

            actual = GroupAnagrams(new string[] { "a" });
            expected = new string[][] { new string[] { "a" } };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
            Console.WriteLine("Expected {0} \n Actual: {1}", Program.Print2DArray(expected), Program.Print2DArray(actual));
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            List<IList<string>> result = new List<IList<string>>();
            List<string> res = new List<string>();
            res.Add(strs[0]);
            result.Add(res);

            for (int i = 1; i < strs.Length; i++)
            {
                string v = strs[i];
                bool found = false;
                foreach (List<string> r in result)
                {
                    string first = r[0];
                    if (IsAnagram(first, v))
                    {
                        found = true;
                        r.Add(v);
                        break;
                    }
                }

                if (!found)
                {
                    res = new List<string>();
                    res.Add(v);
                    result.Add(res);
                }
            }

            return result;
        }

        public bool IsAnagram(string first, string second)
        {
            if (first.Length != second.Length)
            {
                return false;
            }

            string p = second;

            for (int i = 0; i < first.Length; i++)
            {
                for (int j = 0; j < p.Length; j++)
                {
                    if (first[i] == p[j])
                    {
                        p = p.Remove(j, 1);
                        break;
                    }
                }
            }

            return p.Length == 0;
        }
    }
}
