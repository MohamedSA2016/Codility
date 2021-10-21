using System;

namespace Maximize_Distance_to_Closest_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Seats = { 1, 0, 0, 0, 1, 0, 1 };
            Console.WriteLine(MaxDistToClosest(Seats));
        }

        public static int MaxDistToClosest(int[] seats)
        {
            int[] min = new int[seats.Length];
            int oo = Int32.MaxValue;

            //Base
            for (int i = 0; i < min.Length; i++) min[i] = oo;

            //"Construction"
            int max = 0;

            //1.L->R
            int anchor = -1;
            for (int i = 0; i < min.Length; i++)
            {
                if (seats[i] == 1) anchor = i;
                else if (anchor != -1) min[i] = Math.Min(min[i], i - anchor);
            }

            //2.R->L
            anchor = -1;
            for (int i = min.Length - 1; i >= 0; i--)
            {
                if (seats[i] == 1) anchor = i;
                else if (anchor != -1) min[i] = Math.Min(min[i], anchor - i);
                max = (min[i] != oo) ? Math.Max(max, min[i]) : max;
            }

            return max;
        }
    }
}
