using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem981 : Solution
    {
        public void Run()
        {
            TimeMap map = new TimeMap();
            map.Set("foo", "bar", 1);
            string value = map.Get("foo", 1);
            Console.WriteLine("Passed: {0}", value == "bar");
            value = map.Get("foo", 3);
            Console.WriteLine("Passed: {0}", value == "bar");
            map.Set("foo", "bar2", 4);
            value = map.Get("foo", 4);
            Console.WriteLine("Passed: {0}", value == "bar2");
            value = map.Get("foo", 5);
            Console.WriteLine("Passed: {0}", value == "bar2");  
            value = map.Get("fdoo", 5);
            Console.WriteLine("Passed: {0}", value == "");

            map = new TimeMap();
            map.Set("love", "high", 10);
            map.Set("love", "low", 20);
            value = map.Get("love", 5);
            Console.WriteLine("Passed: {0}", value == "");
            value = map.Get("love", 10);
            Console.WriteLine("Passed: {0}", value == "high");
            value = map.Get("love", 15);
            Console.WriteLine("Passed: {0}", value == "high");
            value = map.Get("love", 20);
            Console.WriteLine("Passed: {0}", value == "low");
            value = map.Get("love", 25);
            Console.WriteLine("Passed: {0}", value == "low");
        }
    }
}
