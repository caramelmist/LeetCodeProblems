using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem692 : Solution
    {
        public void Run()
        {
            IList<string> actual = TopKFrequent(new string[] { "i", "love", "leetcode", "i", "love", "coding" }, 2);
            IList<string> expected = new string[] { "i", "love" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = TopKFrequent(new string[] { "the","day","is","sunny","the","the","the","sunny","is","is" }, 4);
            expected = new string[] { "the","is","sunny","day" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = TopKFrequent(new string[] { "the", "day", "is", "sunny", "the", "the", "the", "sunny", "is", "is" }, 3);
            expected = new string[] { "the", "is", "sunny" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = TopKFrequent(new string[] { "the", "day", "is", "sunny", "the", "is", "the", "the", "sunny", "is", "is" }, 3);
            expected = new string[] { "is", "the", "sunny" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));

            actual = TopKFrequent(new string[] { "the", "side", "side", "day", "is", "sunny", "the", "is", "the", "the", "sunny", "is", "is" }, 4);
            expected = new string[] { "is", "the", "side", "sunny" };
            Console.WriteLine("Expected matches actual: {0}", expected.SequenceEqual(actual));
        }

        public IList<string> TopKFrequent(string[] words, int k)
        {
            Array.Sort(words);
            words = words.Reverse().ToArray();

            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (map.ContainsKey(word))
                {
                    map[word]++;
                }
                else
                {
                    map.Add(word, 1);
                }
            }

            IEnumerable<KeyValuePair<string,int>> m = map.OrderBy(a => a.Value).Reverse().Take(k);

            List<string> ret = m.Select(a => a.Key).ToList();
            return ret;
        }
    }

}
