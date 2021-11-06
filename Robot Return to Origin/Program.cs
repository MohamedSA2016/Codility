using System;

namespace Robot_Return_to_Origin
{
    class Program
    {
        static void Main(string[] args)
        {
            string move = "UD";
            Console.WriteLine(JudgeCircle(move));
        }

        private static bool JudgeCircle(string move)
        {
            int L_R = 0, U_D = 0;
            foreach (char i in move)
            {
                if (i == 'L')
                    L_R++;
                else if (i == 'R')
                    L_R--;
                else if (i == 'U')
                    U_D++;
                else if (i == 'D')
                    U_D--;
            }
            return (L_R == 0 && U_D == 0);
        }
    }
}
