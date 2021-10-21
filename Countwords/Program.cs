using System;
using System.Diagnostics;

namespace Countwords
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Assert(CountWords("Hello world") == 2);
            Debug.Assert(CountWords("    Hello world") == 2);
            Debug.Assert(CountWords("Hello world    ") == 2);
            Debug.Assert(CountWords("Hello      world") == 2);
        }

        private static int CountWords(string test)
        {
            int count = 0;
            bool WasInWord = false;
            bool inWord = false;


            for(int i = 0; i < test.Length; i++)
            {
                if(inWord)
                {
                    WasInWord = true;
                }
                if (Char.IsWhiteSpace(test[i]))
                {
                    if (WasInWord)
                    {
                        count++;
                        WasInWord = false;
                    }
                    inWord = false;
                }
                else
                {
                    inWord = true;
                }
                if (WasInWord)
                {
                    count++;
                }

               
            }
            return count;
        }
    }
}
