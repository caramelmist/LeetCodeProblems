using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem520 : Solution
    {
        public void Run()
        {
            bool actual = DetectCapitalUse("USA");
            bool expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("FlaG");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("Test");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("test");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("tEst");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("TEst");
            expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("G");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("GG");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = DetectCapitalUse("Gg");
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool DetectCapitalUse(string word)
        {
            if(word.Length == 1)
            {
                return true;
            }

            if (char.IsUpper(word[0]))
            {
                bool up = char.IsUpper(word[1]);

                for (int i = 2; i < word.Length; i++)
                {
                    bool other = char.IsUpper(word[i]);
                    if(other != up)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = 1; i < word.Length; i++)
                {
                    bool up = char.IsUpper(word[i]);
                    if (up)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
