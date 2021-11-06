using System;
using System.Collections.Generic;

namespace MinimumRemovetoMakeValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ("ab(a(c)fg)9)");
            Console.WriteLine(MinRemoveToMakeValid(s));
        }

        private static string MinRemoveToMakeValid(string s)
        {
            var stack = new Stack<ParenthesesPosition>();

            for (int i = 0; i < s.Length; i++)
            {
                var ch = s[i];
                if (ch == ')')
                {
                    if (stack.Count > 0 && stack.Peek().Type == '(')
                        stack.Pop();
                    else
                        stack.Push(new ParenthesesPosition { Type = ch, Position = i });
                }
                else if (ch == '(')
                    stack.Push(new ParenthesesPosition { Type = ch, Position = i });
            }

            string validString = string.Empty;
            int end = s.Length;
            while (stack.Count > 0)
            {
                var invalidPosition = stack.Pop().Position;
                var validStart = invalidPosition + 1;
                validString = s.Substring(validStart, end - validStart) + validString;
                end = invalidPosition;
            }

            validString = s.Substring(0, end) + validString;

            return validString;
        }
    }
}
