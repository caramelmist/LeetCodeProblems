using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1061 : Solution
    {
        public void Run()
        {
            string actual = SmallestEquivalentString("parker", "morris", "parser");
            string expected = "makkek";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SmallestEquivalentString("hello", "world", "hold");
            expected = "hdld";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SmallestEquivalentString("leetcode", "programs", "sourcecode");
            expected = "aauaaaaada";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = SmallestEquivalentString("gnlbsmgqirncukrlnrbbpbidjaiqjheqqfdssisfpamfiepddtmdedirtbrmelluoueeohgubpgcfcqf", "efamhphuhikcedgqmmpefblgofsphrlttnghhmcnqhommogbncmisqagbcarukrposmucjdduttdumul", "ovfstopkljamwtgarwezkufbzvbmtqhyvxsczndujqpbimnuunvjmnioodspudtxlhbszqjehwidlqkb");
            expected = "avaaaaaaaaaawaaaawazaaaazvaaaaayvxaazaaaaaaaaaaaaavaaaaaaaaaaaaxaaaazaaaawaaaaaa";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }
        
        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            List<string> pairs = new List<string>();
            for (int i = 0; i < s1.Length; i++)
            {
                Add(pairs, "" + s1[i] + s2[i]);
                Add(pairs, "" + s1[i] + s1[i]);
                Add(pairs, "" + s2[i] + s1[i]);
                Add(pairs, "" + s2[i] + s2[i]);
            }

            int count = pairs.Count;
            while (count != pairs.Count)
            {
                count = pairs.Count;
                for (int i = 0; i < pairs.Count - 1; i++)
                {
                    for (int j = 0; j < pairs.Count; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        if (pairs[i][1] == pairs[j][0])
                        {
                            string n = "" + pairs[i][0] + pairs[j][1];
                            if (!pairs.Contains(n))
                            {
                                pairs.Add(n);
                            }
                            n = "" + pairs[j][1] + pairs[i][0];
                            if (!pairs.Contains(n))
                            {
                                pairs.Add(n);
                            }
                        }
                    }
                }
            }

            pairs.Sort();

            char c = pairs[0][0];
            for (int i = 1; i < pairs.Count; i++)
            {
                if (c == pairs[i][0])
                {
                    pairs.RemoveAt(i);
                    i--;
                }
                else 
                {
                    c = pairs[i][0];
                }
            }

            string result = "";

            for (int i = 0; i < baseStr.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < pairs.Count; j++)
                {
                    if (pairs[j][0] == baseStr[i])
                    {
                        found = true;
                        result += pairs[j][1];
                        break;
                    }
                }
                if (!found)
                {
                    result+=baseStr[i];
                }
            }

            return result;
        }

        private void Add(List<string> l, string s)
        {
            if (l.Contains(s))
            {
                return;
            }
            l.Add(s);

            for (int i = 0; i < l.Count-1; i++)
            {
                for (int j = 0; j < l.Count; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (l[i][1] == l[j][0])
                    {
                        string n = "" + l[i][0] + l[j][1];
                        if (!l.Contains(n))
                        {
                            l.Add(n);
                        }
                        n = "" + l[j][1] + l[i][0];
                        if (!l.Contains(n))
                        {
                            l.Add(n);
                        }
                    }
                }
            }
        }
    }
}
