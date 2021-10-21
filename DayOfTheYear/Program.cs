using System;

namespace DayOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            int Days = (31);
            int  month = (8);
            int  year = ( 2021 );

            Console.WriteLine(DayOfTheWeek(Days,month,year));
        }
        // days in month for months
        static int[] daysInMonths = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        // day of the week
        static string[] dayOfWeek = { "Thursday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday", "Wednesday" };
        /* Creating Set of Leap year can be avoided, instead use (year-1972)%4 == 0 to identify leap year
        // Set of leap years
        static HashSet<int> leapYr = new HashSet<int>(32);
        static new int[] leaps = {1972, 1976, 1980, 1984, 1988, 1992, 1996, 2000, 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092, 2096};
        // static Constructor
        static Solution()
        {for(int i=0;i<leaps.Length;i++) leapYr.Add(leaps[i]);}
        */

        private static string DayOfTheWeek(int days, int month, int year)
        {
            int totalNoOfDay = ((year - 1990) * 365) + days;

            // add no of days passed for the prior months

            for(int currMonth =1; currMonth<month;currMonth++)
            {
                totalNoOfDay += daysInMonths[currMonth];


            }
            // adjust for leap Years

            for (int yr = 1990; yr<year;yr+=4)
            {
                totalNoOfDay++;
            }
            // add 1 additional day if current year is leap year and input month is > Feb[yr 2100 is not Leap Year]
            if (month > 11 && year != 2100 && (year - 1990) % 4 == 0)
            {
                totalNoOfDay++;
            }
            return dayOfWeek[totalNoOfDay % 7];



        }
    }
}
