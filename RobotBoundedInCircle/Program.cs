using System;

namespace RobotBoundedInCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructions = "GGGLLGG";
            Console.WriteLine(IsRobotBounded(instructions));
        }

        private static bool IsRobotBounded(string instructions)
        {
            // (CurrentDirection -> Instruction) Map
            // Up    ->G (x++), Right ->L, Left  -> R  ==> Result (Up)
            // Down  ->G (x--), Left  ->L, Right -> R  ==> Result (Down)
            // Left  ->G (y--), Up    ->L, Down  -> R  ==> Result (Left)
            // Right ->G (y++), Up    ->R, Down  -> L  ==> Result (Right)

            char Direction = 'U';

            int x = 0;
            int y = 0;

            foreach (var i in instructions)
            {
                if ((Direction == 'U' && i == 'G') || (Direction == 'R' && i == 'L') || (Direction == 'L' && i == 'R'))
                {
                    if (i == 'G') { x++; }
                    Direction = 'U';
                }
                else if ((Direction == 'D' && i == 'G') || (Direction == 'L' && i == 'L') || (Direction == 'R' && i == 'R'))
                {
                    if (i == 'G') { x--; }
                    Direction = 'D';
                }
                else if ((Direction == 'L' && i == 'G') || (Direction == 'U' && i == 'L') || (Direction == 'D' && i == 'R'))
                {
                    if (i == 'G') { y--; }
                    Direction = 'L';
                }
                else if ((Direction == 'R' && i == 'G') || (Direction == 'U' && i == 'R') || (Direction == 'D' && i == 'L'))
                {
                    if (i == 'G') { y++; }
                    Direction = 'R';
                }
            }

            // If either the movement is 0 or the direction is changed means after every 4 round of movements it will return to same place like the sides of square. With the side of square =
            // Side^2 = x^2 + y^2;
            if ((x == 0 && y == 0) || Direction != 'U')
            {
                return true;
            }

            return false;
        }
    }
}
