using System;

namespace SlowestKey2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] releaseTimes = { 9, 29, 49, 50 };
            string keyPressed = ("cbcd");
            Console.WriteLine(SlowestKey(releaseTimes,keyPressed));
        }

        private static char SlowestKey(int[] releaseTimes, string keyPressed)
        {

            if (keyPressed.Length == 1)
                return keyPressed[0];

            char res = 'a';
            int max = int.MinValue;

            int startTime = 0;
            for (int i = 0; i < keyPressed.Length; i++)
            {
                int pressTime = releaseTimes[i] - startTime;
                if (pressTime == max)
                {
                    if (keyPressed[i] > res)
                        res = keyPressed[i];
                }
                else if (pressTime > max)
                {
                    res = keyPressed[i];
                    max = pressTime;
                }
                startTime = releaseTimes[i];
            }

            return res;

        }
    }
}
