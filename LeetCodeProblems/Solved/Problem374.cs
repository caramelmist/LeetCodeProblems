using System;
namespace LeetCodeProblems
{
    public class Problem374 : Solution
    {
        public Problem374()
        {
        }

        public void Run()
        {
            Solutions s = new Solutions();
            s.Target = 6;
            int actual = s.GuessNumber(10);
            int expected = 6;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

        }
    }

    public class GuessGame
    {
        public int Target { get; set; }

        public int guess(int n)
        {
            if (n > Target)
            {
                return -1;
            }
            if (n < Target)
            {
                return 1;
            }
            return 0;
        }
    }

    public class Solutions : GuessGame
    {
        private int _low = 0;
        private int _high = int.MaxValue;
        private int _guess = -1;

        public int GuessNumber(int n)
        {
            _guess = n;

            int num = guess(n);
            while (num != 0)
            {
                if (num == 1)
                {
                    _low = _guess;
                }
                else if (num == -1)
                {
                    _high = _guess;
                }
                else
                {
                    return _guess;
                }
                _guess = ((_high - _low) / 2) + _low;
                num = guess(_guess);
            }

            return _guess;
        }
    }
}

