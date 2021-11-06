using System;

namespace ZigZagConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string s= "PAYPALISHIRING";
            int numRows = ( 3 );
            Console.WriteLine(Convert(s,numRows));
        }

        private static string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            int currRow;
            bool goDown;
            string ret = "";
            for (int r = 1; r <= numRows; r++)
            {
                currRow = 1;
                goDown = true;
                for (int i = 0; i < s.Length; i++)
                {
                    if (currRow == r)
                        ret += s[i];
                    if (currRow != numRows && goDown)
                        currRow++;
                    else if (currRow == numRows)
                    {
                        currRow--;
                        goDown = false;
                    }
                    else if (currRow != 1 && !goDown)
                        currRow--;
                    else if (currRow == 1)
                    {
                        currRow++;
                        goDown = true;
                    }
                }
            }
            return ret;
        }
    }
}
