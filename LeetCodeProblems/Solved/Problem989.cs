using System;
namespace LeetCodeProblems.Solved
{
    public class Problem989 : Solution
    {
        public Problem989()
        {
        }

        public void Run()
        {
            IList<int> actual = AddToArrayForm(new int[] { 1, 2, 0, 0 }, 34);
            IList<int> expected = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = AddToArrayForm(new int[] { 2, 7, 4 }, 181);
            expected = new int[] { 4, 5, 5 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = AddToArrayForm(new int[] { 2, 1, 5 }, 806);
            expected = new int[] { 1, 0, 2, 1 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = AddToArrayForm(new int[] { 3, 4 }, 1200);
            expected = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = AddToArrayForm(new int[] { 9, 9 }, 99);
            expected = new int[] { 1, 9, 8 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));

            actual = AddToArrayForm(new int[] { 1 }, 99);
            expected = new int[] { 1, 0, 0 };
            Console.WriteLine("Outcome: {0} {1}", string.Join(',', expected), string.Join(',', actual));
        }

        public IList<int> AddToArrayForm(int[] num, int k)
        {
            List<int> ret = new List<int>();
            int carry = 0;
            int div = k / 10;
            int len = num.Length;
            int i = 0;

            while (k > 0 || i < num.Length)
            {
                int v = k % 10;
                if (i < num.Length)
                {
                    v += num[num.Length - 1 - i];
                }

                v += carry;
                carry = v / 10;
                v = v % 10;
                ret.Insert(0, v);

                k = k / 10;
                i++;
            }

            if (carry > 0)
            {
                ret.Insert(0, carry);
            }

            return ret.ToArray();
        }
    }
}