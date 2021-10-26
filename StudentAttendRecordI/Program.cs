using System;

namespace StudentAttendRecordI
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "PPALLL";
            Console.WriteLine(CheckRecord(s));
        }

        private static bool CheckRecord(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                count++;
            }
            if (count >= 2 || s.Contains("LLL"))

            {
                return false;
            }
            return true;
        }
    }
}
