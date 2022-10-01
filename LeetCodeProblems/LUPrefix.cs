using System;
namespace LeetCodeProblems
{
    public class LUPrefix
    {
        List<int> _saved;
        int committed = 0;

        public LUPrefix(int n)
        {
            _saved = new List<int>();
        }

        public void Upload(int video)
        {
            if(video == committed + 1)
            {
                committed = video;

                while (_saved.Count > 0 && _saved.Contains(committed + 1))
                {
                    committed++;
                    _saved.Remove(committed);
                }
            }
            else
            {
                _saved.Add(video);
            }
        }

        public int Longest()
        {
            return committed;
        }
    }
}

