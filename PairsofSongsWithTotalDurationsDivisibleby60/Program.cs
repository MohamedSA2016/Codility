using System;
using System.Collections.Generic;

namespace PairsofSongsWithTotalDurationsDivisibleby60
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = { 30, 20, 150, 100, 40 };
            Console.WriteLine(NumPairsDivisibleBy60(time));
        }

        private static int NumPairsDivisibleBy60(int[] time)
        {
            int result = 0;
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < time.Length; i++)
            {
                var mod = time[i] % 60;
                int key = mod != 0 ? 60 - mod : 0;

                if (dict.TryGetValue(key, out int count))
                    result += count;

                if (!dict.TryAdd(mod, 1))
                    dict[mod]++;
            }
            return result;
        }
        }
    }


