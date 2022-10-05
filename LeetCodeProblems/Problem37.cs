using System;
namespace LeetCodeProblems
{
    public class Problem37 : Solution
    {
        public Problem37()
        {
        }

        public void Run()
        {
            char[][] actual = new char[9][];
            actual[0] = new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' };
            actual[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            actual[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            actual[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            actual[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            actual[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            actual[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            actual[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            actual[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };

            SolveSudoku(actual);

            char[][] expected = new char[9][];
            expected[0] = new char[] { '5', '3', '4', '6', '7', '8', '9', '1', '2' };
            expected[1] = new char[] { '6', '7', '2', '1', '9', '5', '3', '4', '8' };
            expected[2] = new char[] { '1', '9', '8', '3', '4', '2', '5', '6', '7' };
            expected[3] = new char[] { '8', '5', '9', '7', '6', '1', '4', '2', '3' };
            expected[4] = new char[] { '4', '2', '6', '8', '5', '3', '7', '9', '1' };
            expected[5] = new char[] { '7', '1', '3', '9', '2', '4', '8', '5', '6' };
            expected[6] = new char[] { '9', '6', '1', '5', '3', '7', '2', '8', '4' };
            expected[7] = new char[] { '2', '8', '7', '4', '1', '9', '6', '3', '5' };
            expected[8] = new char[] { '3', '4', '5', '2', '8', '6', '1', '7', '9' };

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (actual[i][j] != expected[i][j])
                    {
                        Console.WriteLine("There was a problem with your solution!");
                    }
                }
            }

            Console.WriteLine("Sudoku solved!");

            actual = new char[9][];
            actual[0] = new char[] { '.', '.', '9', '7', '4', '8', '.', '.', '.' };
            actual[1] = new char[] { '7', '.', '.', '.', '.', '.', '.', '.', '.' };
            actual[2] = new char[] { '.', '2', '.', '1', '.', '9', '.', '.', '.' };
            actual[3] = new char[] { '.', '.', '7', '.', '.', '.', '2', '4', '.' };
            actual[4] = new char[] { '.', '6', '4', '.', '1', '.', '5', '9', '.' };
            actual[5] = new char[] { '.', '9', '8', '.', '.', '.', '3', '.', '.' };
            actual[6] = new char[] { '.', '.', '.', '8', '.', '3', '.', '2', '.' };
            actual[7] = new char[] { '.', '.', '.', '.', '.', '.', '.', '.', '6' };
            actual[8] = new char[] { '.', '.', '.', '2', '7', '5', '9', '.', '.' };

            SolveSudoku(actual);

            Console.WriteLine("Sudoku solved!");
        }

        public void SolveSudoku(char[][] board)
        {
            Board b = new Board(board);
            b.Solve();
        }
    }

    public class Board
    {
        private char[][] _board;
        private Position[] _positions = new Position[81];

        public Board(char[][] board)
        {
            _board = board;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Position p;
                    if (board[i][j] == '.')
                    {
                        p = new Position(i, j);
                    }
                    else
                    {
                        int val = board[i][j] - '0';
                        p = new Position(i, j, val);
                    }
                    _positions[p.Id] = p;
                }
            }
        }

        public void Solve()
        {
            bool isComplete = false;
            while (!isComplete)
            {
                isComplete = true;
                for (int i = 0; i < _positions.Length; i++)
                {
                    if (!_positions[i].IsSolved())
                    {
                        isComplete = false;
                        UpdatePosition(_positions[i]);
                    }
                    else
                    {
                        Position p = _positions[i];
                        if (_board[p.Row][p.Col] == '.')
                        {
                            _board[p.Row][p.Col] = ("" + p.Value)[0];
                        }
                    }
                }
            }

        }

        public void UpdatePosition(Position p)
        {
            if (p.IsSolved())
            {
                return;
            }

            IEnumerable<Position> rowPoses = _positions.Where(a => a.Row == p.Row && a.Id != p.Id);
            UpdatePosition(p, rowPoses);
            if (!p.IsSolved())
            {
                IEnumerable<Position> colPoses = _positions.Where(a => a.Col == p.Col && a.Id != p.Id);
                UpdatePosition(p, colPoses);

                if (!p.IsSolved())
                {
                    IEnumerable<Position> boxPoses = _positions.Where(a => a.Box == p.Box && a.Id != p.Id);
                    UpdatePosition(p, boxPoses);
                }
            }
        }

        public void UpdatePosition(Position p, IEnumerable<Position> others)
        {
            if (p.IsSolved())
            {
                return;
            }

            foreach(Position o in others)
            {
                if(o.Id == p.Id)
                {
                    continue;
                }
                if(o.IsSolved())
                {
                    p.Remove(o.Value);
                }
                /*else
                {
                    UpdatePosition(o, others.Where(a => a.Id != o.Id));
                }*/
            }
        }

        public string Print()
        {
            string answer = "";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int id = (i * 0) + j;
                    Position p = _positions[id];
                    answer += p.ToString() + ',';
                }
                answer += '\n';
            }
            return answer;
        }
    }

    public class Position
    {
        public int Id = -1;
        private int _row = -1;
        private int _col = -1;
        private int _box = -1;
        private List<int> _possible = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        private int _value = -1;

        public Position(int r, int c, int value): this(r,c)
        {
            _value = value;
            _possible.Clear();
        }

        public Position(int r, int c)
        {
            _row = r;
            _col = c;
            Id = (r * 9) + c;
            int b1 = r / 3;
            int b2 = c / 3;
            _box = (b1 * 3) + b2;
        }

        public int Value { get { return _value; } }
        public int Row { get { return _row; } }
        public int Col { get { return _col; } }
        public int Box { get { return _box; } }

        public void Remove(int value)
        {
            _possible.Remove(value);
            if(_possible.Count == 1)
            {
                SetValue(_possible[0]);
            }
        }

        public void SetValue(int value)
        {
            _value = value;
            _possible.Clear();
        }

        public bool IsSolved()
        {
            return _value != -1;
        }

        public override string ToString()
        {
            return "[" + _row + ", " + _col + "] [" + _box + "]::" + _value;
        }
    }
}

