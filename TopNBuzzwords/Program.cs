using System;
using System.Collections.Generic;
using System.Linq;
using static TopNBuzzwords.TopWord;

namespace TopNBuzzwords
{
    /*
     Input:
numToys = 6
topToys = 2
toys = ["elmo", "elsa", "legos", "drone", "tablet", "warcraft"]
numQuotes = 6
quotes = [
"Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
"The new Elmo dolls are super high quality",
"Expect the Elsa dolls to be very popular this year, Elsa!",
"Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
"For parents of older kids, look into buying them a drone",
"Warcraft is slowly rising in popularity ahead of the holiday season"
];
Output:
["elmo", "elsa"]
Explanation:
elmo - 4
elsa - 4
"elmo" should be placed before "elsa" in the result because "elmo" appears in 3
different quotes and "elsa" appears in 2 different quotes.
*/
    class Program
    {
        static void Main(string[] args)
        {
            int topToys = 6;
            int numToys = 6;
            var toys = new string[] { "elmo", "elsa", "legos", "drone", "tablet", "warcraft" };

            int numQuotes = 6;
            var quotes = new string[]
            {
                "Elmo is the hottest of the season! Elmo will be on every kid's wishlist!",
"The new Elmo dolls are super high quality",
"Expect the Elsa dolls to be very popular this year, Elsa!",
"Elsa and Elmo are the toys I'll be buying for my kids, Elsa is good",
"For parents of older kids, look into buying them a drone",
"Warcraft is slowly rising in popularity ahead of the holiday season"
            };


            var res = TopNBuzzwords(numToys, topToys, numQuotes, quotes ,toys);
            foreach(var item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }

        private static IList<string> TopNBuzzwords(int numToys, int topToys, int numQuotes, string[] quotes, string[] toys)
        {
            var orderedWords = new SortedSet<TopWord>(new WordComparer());

            foreach (var item in toys)
            {
                string toy = item.ToLower();
                int quotaId = 0;
                var wordObject = new TopWord(toy, 0);
                foreach (var line in quotes)
                {
                    var lower = line.ToLower();
                    var count = lower.Split(new[] { ' ', ',', '.', ':', '!', '?', '\'' }, StringSplitOptions.RemoveEmptyEntries).Count(k => toy == k);
                    if (count > 0)
                    {
                        wordObject.count += count;
                        wordObject.quotaIds.Add(quotaId);
                    }
                    quotaId++;
                }
                orderedWords.Add(wordObject);
            }

            return orderedWords.Take(topToys).Select(x => x.word).ToList();
        }

        
    }
}
