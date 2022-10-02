using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem91 : Solution
    {
        public void Run()
        {
            int actual = NumDecodings("12");
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumDecodings("226");
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumDecodings("06");
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumDecodings("0");
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = NumDecodings("111111111111111111111111111111111111111111111");
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int NumDecodings(string s)
        {
            int len = s.Length;
            if(len == 1)
            {
                return s == "0" ? 0 : 1;
            }

            StringTree sTree = new StringTree("", s);
            int ret = sTree.NumBranches(len);
            return ret;
        }
    }
}
