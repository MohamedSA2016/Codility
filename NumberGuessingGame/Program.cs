using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {

                Console.WriteLine("Guess a Number inbetween 0 and 100:");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if(i>winNum)
                {
                    Console.WriteLine("To High ! Guess lower...");

                }
                else if(i<winNum)
                {
                    Console.WriteLine("Go low! Guess higher...");
                }
                else if( i==winNum)
                {
                    Console.WriteLine("You Win");
                    win = true;
                }
                  
            } while (win == false);
            Console.WriteLine("Thank you for Playing the game");
            Console.WriteLine("Press any Key to finish");
            Console.ReadKey(true);
        }
    }
}
