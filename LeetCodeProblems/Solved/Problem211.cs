using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem211 : Solution
    {
        public void Run()
        {
            WordDictionary wordDictionary = new WordDictionary();
            wordDictionary.AddWord("bad");
            wordDictionary.AddWord("dad");
            wordDictionary.AddWord("mad");
            bool answer = wordDictionary.Search("pad"); // return False
            Console.WriteLine($"Passed {answer == false}");
            answer = wordDictionary.Search("bad"); // return True
            Console.WriteLine($"Passed {answer == true}");
            answer = wordDictionary.Search(".ad"); // return True
            Console.WriteLine($"Passed {answer == true}");
            answer = wordDictionary.Search("b.."); // return True
            Console.WriteLine($"Passed {answer == true}");

            wordDictionary = new WordDictionary();
            wordDictionary.AddWord("a");
            wordDictionary.AddWord("a");
            answer = wordDictionary.Search("."); // return False
            Console.WriteLine($"Passed {answer == true}");
            answer = wordDictionary.Search("a"); // return True
            Console.WriteLine($"Passed {answer == true}");
            answer = wordDictionary.Search("aa"); // return False
            Console.WriteLine($"Passed {answer == false}");
            answer = wordDictionary.Search("a"); // return True
            Console.WriteLine($"Passed {answer == true}");
            answer = wordDictionary.Search(".a"); // return False
            Console.WriteLine($"Passed {answer == false}");
            answer = wordDictionary.Search("a."); // return False
            Console.WriteLine($"Passed {answer == false}");
        }
    }

    public class WordDictionary
    {
        private List<string> _words = new List<string>();

        public WordDictionary()
        {

        }

        public void AddWord(string word)
        {
            _words.Add(word);
        }

        public bool Search(string word)
        {
            if (word.Contains('.'))
            {
                return SearchPattern(word);
            }

            return _words.Contains(word);
        }

        private bool SearchPattern(string word)
        {
            foreach (string item in _words)
            {
                if(item.Length != word.Length)
                {
                    continue;
                }

                bool isWord = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == '.' )
                    {
                        continue;
                    }
                    else if(word[i] != item[i])
                    {
                        isWord = false;
                        continue;
                    }
                }
                if (isWord)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
