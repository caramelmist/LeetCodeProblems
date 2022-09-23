using System;
namespace LeetCodeProblems
{
    public class Problem1680: Solution
    {
        public Problem1680()
        {
        }

        public void Run()
        {
            int actual = ConcatenatedBinary(1);
            int expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ConcatenatedBinary(3);
            expected = 27;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ConcatenatedBinary(12);
            expected = 505379714;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = ConcatenatedBinary(9374);
            expected = 84103234;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int ConcatenatedBinary(int n)
        {
            int answer = 0;
            int pow = 1;

            for (int i = n; i > 0; i--)
            {
                string val = Convert.ToString(i, 2);
                for (int j = val.Length - 1; j >= 0; j--)
                {
                    if (val[j] == '1')
                    {
                        answer += pow;
                        answer %= 1000000007;
                    }
                    pow = (pow * 2) % 1000000007;
                }
            }

            return answer;
        }

        public int ConcatenatedBinary3(int n)
        {
            string binString = "";
            for (int i = 1; i <= n; i++)
            {
                string val = Convert.ToString(i, 2);
                binString += val;
            }

            int answer = 0;
            int pow = 1;

            for (int i = 0, j = binString.Length - 1; i < binString.Length; i++, j--)
            {
                if (binString[j] == '1')
                {
                    answer += pow;
                    answer %= 1000000007;
                }

                pow = (pow * 2) % 1000000007;
            }

            return answer;
        }


        public int ConcatenatedBinary2(int n)
        {
            string binString = "";
            for (int i = 1; i <= n; i++)
            {
                string val = Convert.ToString(i, 2);
                binString += val;
            }

            int answer = 0;

            int[] pow = new int[binString.Length];
            pow[0] = 1;
            if (binString[binString.Length - 1] == '1')
            {
                answer += pow[0];
                answer %= 1000000007;
            }

            for (int i = 1, j = binString.Length-2; i < binString.Length; i++, j--)
            {
                pow[i] = pow[i - 1] * 2;
                pow[i] %= 1000000007;

                if (binString[j] == '1')
                {
                    answer += pow[i];
                    answer %= 1000000007;
                }
            }

            return answer;
        }
    }
}

