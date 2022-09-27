using System;
namespace LeetCodeProblems
{
    public class Problem990 : Solution
    {
        public Problem990()
        {
        }

        public void Run()
        {
            bool actual = EquationsPossible(new string[] { "a==b", "b!=a" });
            bool expected = false;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EquationsPossible(new string[] { "b==a", "a==b"});
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EquationsPossible(new string[] { "c==c","b==d","x!=z" });
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);

            actual = EquationsPossible(new string[] { "a!=b", "b!=c", "c!=a" });
            expected = true;
            Console.WriteLine("Outcome: {0} {1}", expected, actual);
        }

        public bool EquationsPossible(string[] equations)
        {
            List<Token> tokens = new List<Token>();

            foreach(string eq in equations)
            {
                char id = eq[0];
                Token? t = tokens.Find(a => a.id == id);
                if (t == null)
                {
                    t = new Token(id);
                    tokens.Add(t);
                }

                id = eq[3];
                Token? t2 = tokens.Find(a => a.id == id);
                if (t2 == null)
                {
                    t2 = new Token(id);
                    tokens.Add(t2);
                }

                char op = eq[1];
                if (op == '!')
                {
                    t.notEqualTo.Add(t2);
                    t2.notEqualTo.Add(t);
                }
                else
                {
                    t.equalTo.Add(t2);
                    t2.equalTo.Add(t);
                }
            }

            foreach (Token t in tokens)
            {
                t.SetValue(1);
                foreach(Token other in t.equalTo)
                {
                    other.SetValue(1);
                }
                foreach (Token other in t.notEqualTo)
                {
                    other.SetValue(2);
                }
                if (!t.IsValid())
                {
                    return false;
                }
            }

            foreach (Token t in tokens)
            {
                if(!t.IsValid())
                {
                    return false;
                }
            }

            return true;
        }
    }

    public class Token
    {
        public char id;

        public List<Token> equalTo = new List<Token>();
        public List<Token> notEqualTo = new List<Token>();

        private int _value = -1;

        public Token(char i)
        {
            id = i;
        }

        public void SetValue(int v)
        {
            _value = v;
        }

        public int GetValue()
        {
            return _value;
        }

        public bool IsValid()
        {
            foreach(Token other in equalTo)
            {
                if (_value != other.GetValue())
                {
                    return false;
                }
            }

            foreach (Token other in notEqualTo)
            {
                if (_value == other.GetValue())
                {
                    return false;
                }
            }

            return true;
        }
    }
}

