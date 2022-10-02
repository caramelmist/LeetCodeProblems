using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class StringTree
    {
        string val;

        public StringTree? left;
        public StringTree? right;

        public StringTree(string val, string suffix)
        {
            this.val = val;

            if (suffix.Length >= 1)
            {
                string one = suffix.Substring(0, 1);
                string two = suffix.Substring(1);
                if (IsValid(one))
                {
                    right = new StringTree(one, two);
                }
            }

            if(suffix.Length >= 2)
            {
                string one = suffix.Substring(0, 2);
                string two = suffix.Substring(2);
                if (IsValid(one))
                {
                    left = new StringTree(one, two);
                }
            }
        }

        public List<string> GetStrings(int length)
        {
            List<string> list = new List<string>();
            List<string> strings = new List<string>();
            if(right != null)
            {
                strings.AddRange(right.GetStrings(length - val.Length));
            }

            if (left != null)
            {
                strings.AddRange(left.GetStrings(length - val.Length));
            }

            if (length == val.Length)
            {
                list.Add(val);
            }

            for (int i = 0; i < strings.Count; i++)
            {
                string v = val + strings[i];
                if(v.Length == length)
                {
                    list.Add(v);
                }
            }

            return list;
        }

        public int NumBranches(int length)
        {
            return GetStrings(length).Count();
        }

        private bool IsValid(string s)
        {
            if (s[0] == '0')
            {
                return false;
            }

            if (s.Length == 2)
            {
                if (s[0] == '1')
                {
                    // second digit can be 0 - 9
                    return true;
                }

                if (s[0] == '2')
                {
                    // second digit can be 0 - 6
                    switch (s[1])
                    {
                        case '7':
                        case '8':
                        case '9':
                            return false;
                        default:
                            return true;
                    }
                }
            }

            return s.Length == 1;
        }
    }
}
