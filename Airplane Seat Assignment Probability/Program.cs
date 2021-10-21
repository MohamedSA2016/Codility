using System;

namespace Airplane_Seat_Assignment_Probability
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = (1);
            Console.WriteLine(NthPersonGetsNthSeat(n));
        }

        private static double NthPersonGetsNthSeat(int n)
        {
            if(n <=1)
            {
                return 1;
            }

            return 0.5;
        }
    }
}
