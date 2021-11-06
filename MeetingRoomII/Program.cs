using System;
using System.Collections.Generic;

namespace MeetingRoomII
{
    class Program
    {

        struct Interval
        {
            public int S;

            public int E;

            public Interval(int s, int e)
            {
                S = s;
                E = e;
            }
        }
        static void Main(string[] args)
        {
            var times = new List<Interval> {
            new Interval(2, 3),
            new Interval(1, 4),
            new Interval(3, 5),
            new Interval(4, 6)
        };
            var res = Rooms(times);

            Console.WriteLine(res);
         
        }

        private static int Rooms(List<Interval> times)
        {
            if(times ==null || times.Count==0)
            {
                return 0;
            }
            times.Sort((a, b) => a.S.CompareTo(b.S));
            var c = 1;
            var q = new LinkedList<Interval>();
            q.AddLast(times[0]);
            for(var i =1; i<times.Count;i++)
            {
                if(times[i].S<q.Last.Value.E)
                {
                    c++;
                }
                else
                {
                    c--;
                    q.RemoveLast();

                }
                q.AddLast(times[i]);
            }
            return c;
        }
    }
}
