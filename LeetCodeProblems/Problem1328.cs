using System;
namespace LeetCodeProblems
{
    public class Problem1328: Solution
    {
        public Problem1328()
        {
        }

        public void Run()
        {
            string actual = BreakPalindrome("abccba");
            string expected = "aaccba";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = BreakPalindrome("a");
            expected = "";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = BreakPalindrome("aba");
            expected = "bba";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = BreakPalindrome("abba");
            expected = "aaba";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = BreakPalindrome("baab");
            expected = "aaab";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = BreakPalindrome("aa");
            expected = "ab";
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public string BreakPalindrome(string palindrome)
        {
            string p = palindrome.Trim('a');
            if (p.Length == 0)
            {
                return "";
            }
            else 
            {
                int idx = palindrome.IndexOf(p[0]);
                if (p.Length == 1)
                {
                    int mid = palindrome.Length / 2;
                    if (idx == mid)
                    {
                        return "";
                    }
                }
                else
                {
                    string start = palindrome.Substring(0, idx);
                    string end = palindrome.Substring(idx + 1);
                    return start + 'a' + end;
                }
            }
            return "";
        }
    }
}

