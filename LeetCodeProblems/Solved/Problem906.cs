using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2116 : Solution
    {
        public void Run()
        {
            IList<string> actual = WordSubsets(new string[] { "amazon", "apple", "facebook", "google", "leetcode" }, new string[] { "e", "o" });
            IList<string> expected = new List<string> { "facebook", "google", "leetcode" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = WordSubsets(new string[] { "amazon", "apple", "facebook", "google", "leetcode" }, new string[] { "l", "e" });
            expected = new List<string> { "apple", "google", "leetcode" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = WordSubsets(new string[] { "warrior", "world" }, new string[] { "wrr" });
            expected = new List<string> { "warrior" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = WordSubsets(new string[] { "warrior", "world" }, new string[] { "wrr", "i" });
            expected = new List<string> { "warrior" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
        }

        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            Array.Sort(words2, (x, y) => x.Length.CompareTo(y.Length));
            List<string> result = new List<string>();

            string sub = Combine(words2);

            for (int i = 0; i < words1.Length; i++)
            {
                if (IsSubSet(words1[i], sub))
                {
                    result.Add(words1[i]);
                }
            }

            return result;
        }

        private string Combine(string[] words)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(words[words.Length - 1]);

            for (int i = 0; i < words.Length - 1; i++)
            {
                string temp = sb.ToString();
                for (int j = 0; j < words[i].Length; j++)
                {
                    int idx = temp.IndexOf(words[i][j]);
                    if (idx == -1)
                    {
                        sb.Append(words[i][j]);
                        continue;
                    }
                    temp = temp.Substring(0, idx) + temp.Substring(idx + 1, temp.Length - idx - 1);
                }
            }

            return sb.ToString();
        }

        private bool IsSubSet(string word, string[] subs)
        {
            string last = subs[subs.Length - 1];
            if (last.Length > word.Length || !IsSubSet(word, last))
            {
                return false;
            }

            for (int i = 0; i < subs.Length - 1; i++)
            {
                if (!IsSubSet(word, subs[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsSubSet(string word, string sub)
        {
            if (IsDuplicateChars(sub))
            {
                return IsSubSetAdvanced(word, sub);
            }

            for (int i = 0; i < sub.Length; i++)
            {
                if (!word.Contains(sub[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsSubSetAdvanced(string word, string sub)
        {
            string temp = word;
            for (int i = 0; i < sub.Length; i++)
            {
                int idx = temp.IndexOf(sub[i]);
                if (idx == -1)
                {
                    return false;
                }
                temp = temp.Substring(0, idx) + temp.Substring(idx + 1, temp.Length - idx - 1);
            }
            return true;
        }

        private bool IsDuplicateChars(string sub)
        {
            if (sub == null || sub.Length <= 1)
            {
                return false;
            }

            for (int i = 0; i < sub.Length - 1; i++)
            {
                for (int j = i + 1; j < sub.Length; j++)
                {
                    if (sub[i] == sub[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
