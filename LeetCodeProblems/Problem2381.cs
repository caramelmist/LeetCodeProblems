using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem2381 : Solution
    {
        public void Run()
        {
            string actual = ShiftingLetters("abc", new int[][] { new int[] { 0, 1, 0 }, new int[] { 1, 2, 1 }, new int[] { 0, 2, 1 } });
            string expected = "ace";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ShiftingLetters("dztz", new int[][] { new int[] { 0,0,0 }, new int[] { 1,1,1 } });
            expected = "catz";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string ShiftingLetters(string s, int[][] shifts)
        {
            int[] consolidated = new int[s.Length];
            for (int i = 0; i < shifts.Length; i++)
            {
                int[] shift = shifts[i];
                int start = shift[0];
                int end = shift[1];
                int shiftPos = shift[2];
                for (int j = start; j <= end; j++)
                {
                    consolidated[j] += shiftPos == 0 ? -1 : 1;
                }
            }

            StringBuilder sb = new StringBuilder();
            sb.Append(s);
            for (int i = 0;i < consolidated.Length; i++)
            {
                if (consolidated[i] != 0)
                {
                    char c = GetChar(s[i], consolidated[i]);
                    sb.Replace(s[i], c, i, 1);
                }
            }

            return sb.ToString();
        }
        private Dictionary<char, Dictionary<int, char>> _cache = new Dictionary<char, Dictionary<int, char>>();

        private char GetChar(char c, int shift)
        {
            if (!_cache.ContainsKey(c))
            {
                _cache.Add(c, new Dictionary<int, char>());
            }
            else if(_cache[c].ContainsKey(shift))
            {
                return _cache[c][shift];
            }

            const string chars = "abcdefghijklmnopqrstuvwxyz";
            int pos = chars.IndexOf(c);
            pos += shift;
            while (pos < 0)
            {
                pos += 26;
            }
            while (pos > 25)
            {
                pos -= 26;
            }
            char result = chars[pos];

            _cache[c].Add(shift, result);

            return result;
        }
    }
}
