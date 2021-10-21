using System;
using System.Collections.Generic;
using System.Linq;

namespace Alert_Using_Same_Key_Card_Three_or_More_Times_in_a_One_Hour_Period
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] keyName = { "daniel", "daniel", "daniel", "luis", "luis", "luis", "luis" };
            string[] keyTime = { "10:00", "10:40", "11:00", "09:00", "11:00", "13:00", "15:00" };


            Console.WriteLine(AlertNames(keyName,keyTime));
        }

        private static IList<string> AlertNames(string[] keyName, string[] keyTime)
        {
            var map = new Dictionary<String, List<int>>();
            var rst = new List<String>();
            for (int i = 0; i < keyName.Length; i++)
            {
                if (!map.ContainsKey(keyName[i]))
                {
                    map[keyName[i]] = new List<int>();
                }
                map[keyName[i]].Add(ConvertToMinutes(keyTime[i]));
            }
            foreach (String name in map.Keys)
            {
                if (isValid(map[name]))
                {
                    rst.Add(name);
                }
            }
            rst.Sort();
            return rst;
        }

        private static bool isValid(List<int> times)
        {
            if(times.Count()<3)
            {
                return false; 


            }
            times.Sort();
            for(int i =2; i<times.Count();i++)
            {
                if (times[i] - times[i - 2] <= 60)
                {
                    return true;
                }
                
               
            }

            return false;
        }

        private static int ConvertToMinutes(string time)
        {
            var arr = time.Split(":");

            return (int.Parse(arr[0]) * 60) + int.Parse(arr[1]);
        }
    }
}
