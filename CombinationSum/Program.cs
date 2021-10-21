using System;
using System.Collections.Generic;
using System.Linq;

namespace CombinationSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int k =  3 ;
            int n = 7;
            Console.WriteLine(CombinationSum3(k,n));
        }
     

        public static IList<IList<int>> CombinationSum3(int k, int n)
        {
            IList<IList<int>> ans;
            ans = new List<IList<int>>();
            Solve(new List<int>(), 0, 1, n, k);
            return ans;

        }

        public static void Solve(List<int> list, int currSum, int idx, int sum, int count)
        {
            IList<IList<int>> ans;

            if (count==0 || currSum >=sum)
            {
                if(count ==0 && currSum ==sum)
                {
                    ans.Add(list.ToList());
                    return;
                }
            }
           for(int i = idx;i<=9;i++)
            {
                list.Add(i);
                Solve(list, currSum + 1, i + 1, sum, count - 1);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
