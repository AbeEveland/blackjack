using System;

namespace blackjack
{

    class Program
    {
        static void Main(string[] args)
        {
            var keepPlaying = true;

            while (keepPlaying)
            {
                var game = new Game();
                game.PlayGame();

                Console.WriteLine("Would you like to play again? (Y/N):");
                var playAgain = Console.ReadLine();

                keepPlaying = (playAgain == "Y");


            }
            Console.WriteLine("Thanks for playing");

        }
    }


}



