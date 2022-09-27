using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem622 : Solution
    {
        public void Run()
        {
            Run1();
        }

        private void Run1()
        {
            MyCircularQueue q = new MyCircularQueue(3);
            Console.WriteLine("Expect True: {0}", q.EnQueue(1)); // return True
            Console.WriteLine("Expect True: {0}", q.EnQueue(2)); // return True
            Console.WriteLine("Expect True: {0}", q.EnQueue(3)); // return True
            Console.WriteLine("Expect False: {0}", q.EnQueue(4)); // return False
            Console.WriteLine("Expect 3: {0}", q.Rear());     // return 3
            Console.WriteLine("Expect True: {0}", q.IsFull());   // return True
            Console.WriteLine("Expect True: {0}", q.DeQueue());  // return True
            Console.WriteLine("Expect True: {0}", q.EnQueue(4)); // return True
            Console.WriteLine("Expect 4: {0}", q.Rear());     // return 4
        }
    }
}
