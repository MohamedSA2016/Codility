using System;
using System.Collections.Generic;
using System.Text;

namespace GenerateParentheses
{
    public class ParenthesesGenerating
    {
        public string Str { get; set; }
        public int Open { get; set; }
        public int Close { get; set; }

        public ParenthesesGenerating(int o, int c, string s)
        {
            Str = s;
            Open = o;
            Close = c;
        }
    }
}
