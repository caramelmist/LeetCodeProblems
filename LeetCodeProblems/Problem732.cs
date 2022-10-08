using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class Problem732 : Solution
    {
        public void Run()
        {
            MyCalendarThree calender = new MyCalendarThree();
            int value = calender.Book(10, 20);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(50, 60);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(10, 40);
            Console.WriteLine("Passed: {0}", value == 2);
            value = calender.Book(5, 15);
            Console.WriteLine("Passed: {0}", value == 3);
            value = calender.Book(5, 10);
            Console.WriteLine("Passed: {0}", value == 3);
            value = calender.Book(25, 55);
            Console.WriteLine("Passed: {0}", value == 3);


            calender = new MyCalendarThree();
            value = calender.Book(47, 50);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(1, 10);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(27, 36);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(40, 47);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(20, 27);
            Console.WriteLine("Passed: {0}", value == 1);
            value = calender.Book(15, 23);
            Console.WriteLine("Passed: {0}", value == 2);
            value = calender.Book(10, 18);
            Console.WriteLine("Passed: {0}", value == 2);
            value = calender.Book(27, 36);
            Console.WriteLine("Passed: {0}", value == 2);
            value = calender.Book(17, 25);
            Console.WriteLine("Passed: {0}", value == 3);
            value = calender.Book(8, 17);
            Console.WriteLine("Passed: {0}", value == 3);
            value = calender.Book(24, 33);
            Console.WriteLine("Passed: {0}", value == 3);
            value = calender.Book(23, 28);
            Console.WriteLine("Passed: {0}", value == 4);
            value = calender.Book(21, 27);
            Console.WriteLine("Passed: {0}", value == 5);
            value = calender.Book(47, 50);
            Console.WriteLine("Passed: {0}", value == 5);
            value = calender.Book(14, 21);
            Console.WriteLine("Passed: {0}", value == 5);
            value = calender.Book(26, 32);
            Console.WriteLine("Passed: {0}", value == 5);
            value = calender.Book(16, 21);
            Console.WriteLine("Passed: {0}", value == 5);
            value = calender.Book(2, 7);
            Console.WriteLine("Passed: {0}", value == 5);
            value = calender.Book(24, 33);
            Console.WriteLine("Passed: {0}", value == 6);
            value = calender.Book(6, 13);
            Console.WriteLine("Passed: {0}", value == 6);
            value = calender.Book(44, 50);
            Console.WriteLine("Passed: {0}", value == 6);
            value = calender.Book(33, 39);
            Console.WriteLine("Passed: {0}", value == 6);
            value = calender.Book(30, 36);
            Console.WriteLine("Passed: {0}", value == 6);
            value = calender.Book(6, 15);
            Console.WriteLine("Passed: {0}", value == 6);
            value = calender.Book(21, 27);
            Console.WriteLine("Passed: {0}", value == 7);
            value = calender.Book(49, 50);
            Console.WriteLine("Passed: {0}", value == 7);
            value = calender.Book(38, 45);
            Console.WriteLine("Passed: {0}", value == 7);
            value = calender.Book(4, 12);
            Console.WriteLine("Passed: {0}", value == 7);
            value = calender.Book(46, 50);
            Console.WriteLine("Passed: {0}", value == 7);
            value = calender.Book(13, 21);
            Console.WriteLine("Passed: {0}", value == 7);
        }
    }
}
