using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem944 : Solution
    {
        public void Run()
        {
            int actual = MinDeletionSize(new string[] { "cba", "daf", "ghi", "zzz" });
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDeletionSize(new string[] { "a", "b" });
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MinDeletionSize(new string[] { "zyx", "wvu", "tsr" });
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MinDeletionSize(string[] strs)
        {
            int num = strs[0].Length;
            int words = strs.Length;

            List<int> skip = new List<int>();

            for (int i = 1; i < words; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (skip.Contains(j))
                    {
                        continue;
                    }

                    if(strs[i-1][j] > strs[i][j])
                    {
                        skip.Add(j);
                    }
                }
            }

            return skip.Count();
        }
    }
}
