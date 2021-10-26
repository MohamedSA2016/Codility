using System;
using System.Collections.Generic;
using System.Linq;

namespace TopNCompitior
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCompetitors = 6;
            int topNCompetitors = 2;
            int numReviews = 6;
            var competitors = new string[] { "newshop", "shopnow", "afashion", "fashionbeats", "mymarket", "tcellular" };
            var reviews = new string[] { "newshop is providing good services in the city; everyone should use newshop",
"best services by newshop",
"fashionbeats has great services in the city",
"I am proud to have fashionbeats",
"mymarket has awesome services",
"Thanks Newshop for the quick delivery"};




            var res = topNCompetitor(numCompetitors,topNCompetitors,numReviews,competitors,reviews);
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
           
        }

        private static IList<string> topNCompetitor(int numCompetitors, int topNCompetitors, int numReviews, string[] competitors, string[] reviews)
        {
            if (competitors == null || reviews == null) return null;

            Dictionary<string, int> competitorsFreqMap = competitors.ToDictionary(k => k, v => 0);
            for (int i = 0; i < numReviews; i++)
            {
                string currentReview = reviews[i].ToLower();
                foreach (string competitor in competitors.Where(comp => currentReview.Contains(comp)))
                {
                    competitorsFreqMap[competitor]++; //increase freq count if present in review
                }
            }

            List<string> result = competitorsFreqMap.OrderByDescending(descKv => descKv.Value)
                .Take(topNCompetitors)
                .Select(kv => kv.Key)
                .ToList();

            return result;
        }

       
    }
}
