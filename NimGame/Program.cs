using System;

namespace NimGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            Console.WriteLine(CanWinNim(n));
        }

        private static bool CanWinNim(int n)
        {
            if(n>4)
            {
                return true;
            }
            if(n==4)
            {
                return false;
            }
            var game = new bool[n];
            game[0] = true;
            game[1] = true;
            game[2] = true;
            game[3] = true;
            for(int i = 4; i<n;++i)
            {
                if(!game[i-1] || !game[i-2] || !game[i-3])
                {
                    game[i] = true;

                }
            }
            return game[n - 1];
        }
    }
}
