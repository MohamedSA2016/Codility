using System;
using System.Collections.Generic;
using System.Linq;

namespace Amazon_Customer_Reviews_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            string customerQuery = "mouse";
            List<string> repository = new List<string>
            {
                "mobile",
                "mouse",
                "moneypot",
                "monitor",
                "mousepad"
            };

            Console.WriteLine(searchSuggestions(customerQuery,repository));
        }

        private static List<List<string>> searchSuggestions(string customerQuery, List<string> repository)
        {
            List<List<string>> suggestions = new List<List<string>>();
            repository.Sort();
            for(int i =2; i<customerQuery.Length;i++)
            {
                string subStr = customerQuery.Substring(0, i);
                List<string> matches = repository.FindAll(review => review.StartsWith(subStr)).Take(3).ToList();
                suggestions.Add(matches);
            }
            return suggestions;
        }
    }
}
