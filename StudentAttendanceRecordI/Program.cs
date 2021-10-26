using System;

namespace StudentAttendanceRecordI
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "PPALLP";
            Console.WriteLine(CheckRecord(s));
        }

        private static bool CheckRecord(string s)
        {
            // A should be less than 2
            //L consecutively should be less than 3
            int conL = 0;
            int a = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'A') a++;
                if (a > 1) return false;
                if (s[i] == 'L') conL++;
                else conL = 0;
                if (conL > 2) return false;
            }
            return true;
        }
    }
}
