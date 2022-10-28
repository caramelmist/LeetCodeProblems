using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using LeetCodeProblems;
using LeetCodeProblems.Solved;

namespace LeetCodeProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            //A: Setup and stuff you don't want timed
            var timer = new Stopwatch();
            timer.Start();

            //B: Run stuff you want timed
            Solution s = new Problem49();
            s.Run();

            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");

            Console.WriteLine(foo);

            Console.ReadLine();
        }

        public static string Print2DArray(IList<IList<string>> matrix)
        {
            string ret = "[";
            foreach(IList<string> row in matrix)
            {
                string value = "[";
                for (int j = 0; j < row.Count; j++)
                {
                    value += row[j] + ", ";
                }
                value += "]";
                value = value.Replace(", ]", "]");
                ret += value + ",";
            }
            ret += "]";
            return ret.Replace("],]", "]]");
        }

        public static string Print2DArray<T>(T[,] matrix)
        {
            string ret = "[";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string value = "[";
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    value += matrix[i, j] + ", ";
                }
                value += "]";
                value = value.Replace(", ]", "]");
                ret += value + ",";
            }
            ret += "]";
            return ret.Replace("],]", "]]");
        }

        public static string Print2DArray(IList<IList<int>> matrix)
        {
            string ret = "[";
            for (int i = 0; i < matrix.Count; i++)
            {
                string value = "[";
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    value += matrix[i][j] + ", ";
                }
                value += "]";
                value = value.Replace(", ]", "]");
                ret += value + ",";
            }
            ret += "]";
            return ret.Replace("],]", "]]");
        }

        /*
        public static void RunBagOfTokensScore()
        {
            int[] tokens = new int[] { 100 };
            int power = 50;
            int actual = BagOfTokensScore(tokens, power);
            int expected = 0;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 100, 200 };
            power = 150;
            actual = BagOfTokensScore(tokens, power);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 100, 200, 300, 400 };
            power = 200;
            actual = BagOfTokensScore(tokens, power);
            expected = 2;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 25, 99 };
            power = 99;
            actual = BagOfTokensScore(tokens, power);
            expected = 1;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            tokens = new int[] { 52, 65, 35, 88, 28, 1, 4, 68, 56, 95 };
            power = 94;
            actual = BagOfTokensScore(tokens, power);
            expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public static int BagOfTokensScore(int[] tokens, int power)
        {
            List<int> ts = tokens.ToList();
            ts.Sort();

            int score = 0;

            while (ts.Count > 0)
            {
                while (ts.Count > 0 && ts[0] <= power)
                {
                    power -= ts[0];
                    ts.Remove(ts[0]);
                    score++;
                }

                if (ts.Count <= 1)
                {
                    break;
                }

                int k = 0;
                int reqPower = ts[0];
                while (ts.Count > 0 && reqPower > power && (score + k) > 0)
                {
                    int value = ts[ts.Count - 1];
                    power += value;
                    k++;
                    if (reqPower <= power)
                    {
                        score -= k;
                        ts.RemoveAt(ts.Count - 1);
                    }
                    else if (ts.Count > k)
                    {
                        reqPower += ts[k];
                    }
                }

                if (k == 0)
                {
                    break;
                }
            }


            return score;
        }

        public static int BagOfTokensScore3(int[] tokens, int power)
        {
            List<int> ts = tokens.ToList();
            ts.Sort();

            int score = 0;
            int powerUpsUsed = 0;
            int committedPowerUps = 0;

            for (int i = 0; i < tokens.Length - (powerUpsUsed + committedPowerUps); i++)
            {
                if (tokens[i] <= power)
                {
                    score++;
                    powerUpsUsed += committedPowerUps;
                    committedPowerUps = 0;
                }
                else if (score > 0)
                {
                    power += ts[tokens.Length - powerUpsUsed - committedPowerUps - 1];
                    committedPowerUps++;
                    i--;
                }
            }

            return score - powerUpsUsed;
        }

        public static int BagOfTokensScor2(int[] tokens, int power)
        {
            Command cm = new Command(tokens, -1, power, 0);
            return cm.GetBestScore();
        }

        public static void RunTree2str()
        {
            TreeNode node = new TreeNode(1, new TreeNode(2, new TreeNode(4)), new TreeNode(3));
            string answer = Tree2str(node);
            Console.WriteLine("Should be 1(2(4))(3) was: {0}", answer.ToString());
            Console.WriteLine("Test Passed: {0}", answer == "1(2(4))(3)");

            node = new TreeNode(1, new TreeNode(2, null, new TreeNode(4)), new TreeNode(3));
            answer = Tree2str(node);
            Console.WriteLine("Should be 1(2()(4))(3) was: {0}", answer.ToString());
            Console.WriteLine("Test Passed: {0}", answer == "1(2()(4))(3)");
        }

        public static string Tree2str(TreeNode root)
        {
            TreeNode pointer = root;

            string output = root.GetTreeString();

            return output;
        }

        public static void RunAddTwoNumbers()
        {
            ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
            ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
            ListNode answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Should be 708 was: {0}", answer.ToString());


            l1 = new ListNode(0);
            l2 = new ListNode(0);
            answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Should be 0 was: {0}", answer.ToString());

            l2 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9)))))));
            l1 = new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))));
            answer = AddTwoNumbers(l1, l2);
            Console.WriteLine("Should be 89990001 was: {0}", answer.ToString());
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode answer = new ListNode();
            ListNode pointer = answer;
            int carryOver = 0;

            while (l1 != null || l2 != null)
            {
                if (l1 == null)
                {
                    l1 = new ListNode();
                }
                else if (l2 == null)
                {
                    l2 = new ListNode();
                }

                int amount = l1.val + l2.val + carryOver;
                carryOver = amount / 10;
                pointer.val = amount % 10;

                l1 = l1.next;
                l2 = l2.next;

                if (l1 != null || l2 != null)
                {
                    pointer.next = new ListNode();
                    pointer = pointer.next;
                }
                else if (carryOver > 0)
                {
                    pointer.next = new ListNode(carryOver);
                    pointer = pointer.next;
                }
            }

            return answer;
        }

        public static void RunRotate()
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] expected = new int[3, 3] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i, j] != expected[i, j])
                    {
                        Console.WriteLine("Matrix does not match expected.");
                        break;
                    }
                }
            }
            Console.WriteLine("Test Passed.");
        }

        public static void Rotate(int[][] matrix)
        {

        }

        public static void RunBuddyStrings()
        {
            bool solved = BuddyStrings("ab", "ba");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("sideshj", "jsidesh");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("ab", "ab");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("aa", "aa");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("abcd", "cbad");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("abed", "cbad");
            Console.WriteLine("[{0}]", solved);

            solved = BuddyStrings("cbadd", "cbad");
            Console.WriteLine("[{0}]", solved);
        }

        public static bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length || s.Length <= 1)
            {
                return false;
            }

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    string other = s.Remove(i, 1).Insert(i, s[j].ToString());
                    other = other.Remove(j, 1).Insert(j, s[i].ToString());

                    Console.WriteLine(other);
                    if (goal.Equals(other))
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        int[] sol = { i, j };
                        return sol;
                    }
                }
            }
            // should not ever get here according to assumptions
            return new int[] { 0 };
        }

        public static bool IsPalindrome(int x)
        {
            string value = x.ToString();
            int first = 0;
            int last = value.Length - 1;
            for (int i = 0; i < value.Length / 2; i++)
            {
                if (value[first + i] != value[last - i])
                {
                    return false;
                }
            }

            return true;
        }
    }

    public static class TreeExtensions
    {
        public static string GetTreeString(this TreeNode node)
        {
            string output = "";
            if (node != null)
            {
                output += node.val;
            }
            if (node.left != null)
            {
                output += "(" + node.left.GetTreeString() + ")";
            }
            else if (node.right != null)
            {
                output += "()";
            }

            if (node.right != null)
            {
                output += "(" + node.right.GetTreeString() + ")";
            }

            return output;
        }
        */
    }
}