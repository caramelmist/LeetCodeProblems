using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class MyCalendarThree
    {
        private List<Room> _rooms = new List<Room>();

        public MyCalendarThree()
        {
            _rooms.Add(new Room());
        }

        public int Book(int start, int end)
        {
            foreach (Room room in _rooms)
            {
                if (room.Book(start, end))
                {
                    return _rooms.Count;
                }
            }

            Room r = new Room();
            r.Book(start, end);
            _rooms.Add(r);
            return _rooms.Count;
        }
    }

    public class Room
    {
        private List<Booking> _bookings = new List<Booking>();

        public bool Book(int start, int end)
        {
            foreach (Booking booking in _bookings)
            {
                if(start >= booking.Start && start < booking.End)
                {
                    return false;
                }

                if (end > booking.Start && end <= booking.End)
                {
                    return false;
                }
            }

            _bookings.Add(new Booking(start, end));

            return true;
        }

        public override string ToString()
        {
            string ret = "";
            _bookings.Sort((a, b) => a.Start - b.Start);
            foreach(Booking booking in _bookings)
            {
                ret+= booking.ToString();
            }
            return ret;
        }
    }

    public class Booking
    {
        public int Start;
        public int End;

        public Booking(int start, int end)
        {
            Start = start;
            End = end;
        }

        public override string ToString()
        {
            return "["+Start+"]["+End+"]";
        }
    }
}
