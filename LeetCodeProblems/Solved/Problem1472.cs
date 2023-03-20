using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    internal class Problem1472 : Solution
    {
        public void Run()
        {
            BrowserHistory browserHistory = new BrowserHistory("leetcode.com");
            browserHistory.Visit("google.com");       // You are in "leetcode.com". Visit "google.com"
            browserHistory.Visit("facebook.com");     // You are in "google.com". Visit "facebook.com"
            browserHistory.Visit("youtube.com");      // You are in "facebook.com". Visit "youtube.com"
            string value = browserHistory.Back(1);    // You are in "youtube.com", move back to "facebook.com" return "facebook.com"
            Console.WriteLine($"You are at: {value} . Should be at : facebook.com");
            value = browserHistory.Back(1);           // You are in "facebook.com", move back to "google.com" return "google.com"
            Console.WriteLine($"You are at: {value} . Should be at : google.com");
            value = browserHistory.Forward(1);        // You are in "google.com", move forward to "facebook.com" return "facebook.com"
            Console.WriteLine($"You are at: {value} . Should be at : facebook.com");
            browserHistory.Visit("linkedin.com");     // You are in "facebook.com". Visit "linkedin.com"
            value = browserHistory.Forward(2);        // You are in "linkedin.com", you cannot move forward any steps.
            Console.WriteLine($"You are at: {value} . Should be at : linkedin.com");
            value = browserHistory.Back(2);           // You are in "linkedin.com", move back two steps to "facebook.com" then to "google.com". return "google.com"
            Console.WriteLine($"You are at: {value} . Should be at : google.com");
            value = browserHistory.Back(7);           // You are in "google.com", you can move back only one step to "leetcode.com". return "leetcode.com"
            Console.WriteLine($"You are at: {value} . Should be at : leetcode.com");
        }
    }
    internal class BrowserHistory
    {
        private List<string> _history = new List<string>();
        private int _index = 0;

        public BrowserHistory(string homepage)
        {
            _history.Add(homepage);
        }

        public void Visit(string url)
        {
            int numTrim = _history.Count - _index - 1;
            for (int i = 0; i < numTrim; i++)
            {
                _history.RemoveAt(_history.Count - 1);
            }

            _history.Add(url);
            _index++;
        }

        public string Back(int steps)
        {
            _index = _index - steps;
            _index = _index <= 0 ? 0 : _index;

            return _history[_index];
        }

        public string Forward(int steps)
        {
            _index = steps + _index;
            _index = _index > _history.Count - 1 ? _history.Count - 1 : _index;

            return _history[_index];
        }
    }

}
