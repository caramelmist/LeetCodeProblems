using System;
namespace LeetCodeProblems.Solved
{
    public class Problem1832 : Solution
    {
        public Problem1832()
        {
        }

        public void Run()
        {
            bool actual = CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CheckIfPangram("leetcode");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CheckIfPangram("abcdefghijklmnopqrstuvwxyz");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CheckIfPangram("abcdefghijklmnoprstuvwxyzq");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = CheckIfPangram("abcdefghijklmnoprstuvwxyzz");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);



            actual = CheckIfPangram("abc");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool CheckIfPangram(string sentence)
        {
            if (sentence.Length < 26)
            {
                return false;
            }

            for (int i = 0; i < 26; i++)
            {
                int pos = i + 97;
                char c = (char)pos;
                if (!sentence.Contains(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}

