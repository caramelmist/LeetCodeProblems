using System;
namespace LeetCodeProblems
{
    public class Problem2140 : Solution
    {
        public Problem2140()
        {
        }

        public void Run()
        {
            long actual = MostPoints(new int[][] { new int[] { 3, 2 }, new int[] { 4, 3 }, new int[] { 4, 4 }, new int[] { 2, 5 } });
            long expected = 5;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = MostPoints(new int[][] { new int[] { 1, 1 }, new int[] { 2, 2 }, new int[] { 3, 3 }, new int[] { 4, 4 }, new int[] { 5, 5 } });
            expected = 7;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public long MostPoints(int[][] questions)
        {
            List<QuestionNode> nodes = new List<QuestionNode>();
            for (int i = 0; i < questions.Length; i++)
            {
                QuestionNode n = new QuestionNode(i, questions[i][0]);
            }



        }
    }

    class QuestionNode
    {
        int Index;
        int Score;
        QuestionNode Child = null;

        public long Total { get {
                if (Child != null)
                {
                    return Score + Child.Score;
                }
                return Score; } }

        public QuestionNode(int index, int score)
        {
            Index = index;
            Score = score;
        }

        public bool InChain(int index)
        {
            return Index == index || Child.Index == index;
        }
    }
}

