using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Solved
{
    public class Problem2424 : Solution
    {
        public void Run()
        {
            LUPrefix server = new LUPrefix(4);   // Initialize a stream of 4 videos.
            server.Upload(3);                    // Upload video 3.
            int value = server.Longest();        // Since video 1 has not been uploaded yet, there is no prefix.
            Console.WriteLine(value);
            // So, we return 0.
            server.Upload(1);                    // Upload video 1.
            value = server.Longest();            // The prefix [1] is the longest uploaded prefix, so we return 1.
            Console.WriteLine(value);
            server.Upload(2);                    // Upload video 2.
            value = server.Longest();            // The prefix [1,2,3] is the longest uploaded prefix, so we return 3.
            Console.WriteLine(value);
        }
    }
}
