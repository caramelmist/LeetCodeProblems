using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem1239 : Solution
    {
        public void Run()
        {
            int actual = MaxLength(new string[] { "un", "iq", "ue" });
            int expected = 4;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxLength(new string[] { "cha", "r", "act", "ers" });
            expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MaxLength(new string[] { "abcdefghijklmnopqrstuvwxyz" });
            expected = 26;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MaxLength(IList<string> arr)
        {

        }

        private bool IsUnique(string s)
        {
            if(s.Length > 26)
            {
                return false;
            }

            for (int i = 0; i < s.Length-1; i++)
            {
                for (int j = i+1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
