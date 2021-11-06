using System;
using System.Collections.Generic;
using System.Linq;

namespace Top_K_Frequent_Elements
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums = new int[6] { 1, 1, 1, 2, 2, 3 };

            int k=2;
            Solution sol = new Solution();
            sol.TopKFrequent(nums, k);
        }
    }

    public class Solution
    {
        public IList<int>  TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
                 //Frequency count Dictionary
        Dictionary<int, int> dict = new Dictionary<int, int>();
            //Make bucket
            List<int>[] bucket = new List<int>[nums.Length + 1];

            //Intialize each list of the array
            for (int i = 0; i <= nums.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            //Count the frequency of each element
            foreach (int n in nums)
            {
                if (!dict.ContainsKey(n))
                    dict.Add(n, 1);
                else
                    dict[n]++;
            }

            //Add it to the buckets
            foreach (var e in dict)
            {
                bucket[e.Value].Add(e.Key);
            }

            //Result array of length k
            int[] result = new int[k];
            //Index for the result array
            int m = 0;

            for (int i = bucket.Length - 1; i >= 0; i--)
            {
                if (m >= k)
                    break;  //All top k elements added
                for (int j = 0; j < bucket[i].Count; j++)
                {
                    result[m] = bucket[i][j];
                    m++;
                    if (m >= k)
                        break;
                }
            }
            return result;
        }
    }
}
