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
            IList<int> res = new List<int>();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for(int i =0; i<nums.Length; i++)
            {
                if(!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], 1);

                }
                else
                {
                    dict[nums[i]]++;
                }
            }
            foreach(KeyValuePair<int,int> item in dict.OrderByDescending(key=>key.Value))
            {
                if(k>0)
                {
                    Console.WriteLine(item.Key + "  " + item.Value);
                    res.Add(item.Key);
                    k--;
                }
            }

            return res;
        }
    }
}
