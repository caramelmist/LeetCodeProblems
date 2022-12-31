using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem66 : Solution
    {
        public void Run()
        {
            int[] actual = PlusOne(new int[] { 1, 2, 3 });
            int[] expected = new int[] { 1, 2, 4 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = PlusOne(new int[] { 4, 3, 2, 1 });
            expected = new int[] { 4, 3, 2, 2 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = PlusOne(new int[] { 9 });
            expected = new int[] { 1, 0 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = PlusOne(new int[] { 1, 9 });
            expected = new int[] { 2, 0 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));
        }

        public int[] PlusOne(int[] digits)
        {
            int len = digits.Length - 1;
            int last = digits[len];

            if(last != 9)
            {
                digits[len]++;
                return digits;
            }
            else
            {
                List<int> result = new List<int>();

                int carry = 1;
                result.Add(0);
                for (int i = 1; i < digits.Length; i++)
                {
                    int idx = digits.Length -1- i;
                    if(carry == 1)
                    {
                        digits[idx]++;
                        if(digits[idx] == 10)
                        {
                            result.Insert(0, 0);
                        }
                        else
                        {
                            result.Insert(0, digits[idx]);
                            carry = 0;
                        }
                    }
                    else
                    {
                        result.Insert(0, digits[idx]);
                    }

                }

                if(carry == 1)
                {
                    result.Insert(0, 1);
                }

                return result.ToArray();
            }
        }
    }
}
