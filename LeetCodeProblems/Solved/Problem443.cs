using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem443 : Solution
    {
        public void Run()
        {
            int actual = Compress(new char[] { 'a', 'a', 'b', 'b', 'c', 'c', 'c' });
            int expected = 6;
            Console.WriteLine("Outcome: {0}", actual == (expected));

            actual = Compress(new char[] { 'a' });
            expected = 1;
            Console.WriteLine("Outcome: {0}", actual == (expected));

            actual = Compress(new char[] { 'a', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b', 'b' });
            expected = 4;
            Console.WriteLine("Outcome: {0}", actual == (expected));
        }

        public int Compress(char[] chars)
        {
            int ptr = 0;

            char currentChar = chars[0];
            int currentCharCount = 1;

            for (int i = 1; i < chars.Length; i++)
            {

                if(chars[i] == currentChar)
                {
                    currentCharCount++;
                }
                else
                {
                    ptr = UpdateBuffer(chars, currentChar, currentCharCount, ptr);
                    currentChar = chars[i];
                    currentCharCount = 1;
                }
            }

            ptr = UpdateBuffer(chars, currentChar, currentCharCount, ptr);
            return ptr;
        }

        private int UpdateBuffer(char[] chars, char currentChar, int currentCharCount, int ptr)
        {
            chars[ptr] = currentChar;
            ptr++;

            if (currentCharCount > 1)
            {
                string len = currentCharCount.ToString();
                for (int i = 0; i < len.Length; i++)
                {
                    chars[ptr] = len[i];
                    ptr++;
                }
            }
            return ptr;
        }
    }
}
