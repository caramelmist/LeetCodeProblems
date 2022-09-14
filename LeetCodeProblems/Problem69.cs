using System;
namespace LeetCodeProblems
{
    public class Problem69 : Solution
    {
        public Problem69()
        {
        }

        public void Run()
        {
            int actual = MySqrt(4);
            int expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(8);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(9);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(15);
            expected = 3;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(0);
            expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(1);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(2);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(2147395599);
            expected = 46339;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MySqrt(2147483647);
            expected = 46340;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public int MySqrt(int x)
        {
            if( x <= 1)
            {
                return x;
            }

            for(int i = 1; i <= x; i++)
            {
                int val = i * i;

                // cater for wrap around on max constraint
                if(val < 0)
                {
                    return 46340;
                }

                if (val == x)
                {
                    return i;
                }
                else if(val > x)
                {
                    return i - 1;
                }
            }

            return 0;
        }
    

        public int MySqrt2(int x)
        {
            int high = x;
            int low = 0;
            int mid = (high - low) / 2;
            int next = -1;

            do
            {
                if (mid * mid > x)
                {
                    next = mid - 1;
                    if(next * next <= x)
                    {
                        return next;
                    }
                    high = mid;
                }
                else if (mid * mid < x)
                {
                    next = mid + 1;
                    int v = next * next;
                    if (v > x)
                    {
                        return mid;
                    }
                    else if (v == x)
                    {
                        return next;
                    }

                    low = mid;
                }
                else
                {
                    return mid;
                }
                mid = ((high - low) / 2) + low;

            } while (mid > 1);

            return mid;
        }
    }
}

