using System;

namespace blackjack
{
    public class Game
    {
        public void PlayGame()
        {
            var deck = new Deck();

            deck.CreateCards();

            var playerHand = new Hands();
            var houseHand = new Hands();
            var firstPlayerCard = deck.Deal();
            playerHand.HoldCard(firstPlayerCard);

            var secondPlayerCard = deck.Deal();
            playerHand.HoldCard(secondPlayerCard);

            var firstHouseCard = deck.Deal();
            houseHand.HoldCard(firstHouseCard);

            var secondHouseCard = deck.Deal();
            houseHand.HoldCard(secondHouseCard);

            while (playerHand.GiveValueToHand() <= 21)
            {
                playerHand.DisplayCards();
                Console.WriteLine($"you have a total value of {playerHand.GiveValueToHand()}");

                Console.WriteLine("Would you like to (H)it or (S)tay?");
                var playerDecision = Console.ReadLine();

                if (playerDecision == "H")
                {
                    var hitCard = deck.Deal();
                    playerHand.HoldCard(hitCard);
                }
                else
                {


                    break;

                }
            }
            playerHand.DisplayCards();
            Console.WriteLine($"For a total value of {playerHand.GiveValueToHand()}");
            Console.WriteLine("===========================");

            while (houseHand.GiveValueToHand() < 17)
            {
                var hitCard = deck.Deal();
                houseHand.HoldCard(hitCard);
            }

            var houseHandValue = houseHand.GiveValueToHand();

            houseHand.DisplayCards();
            Console.WriteLine($"The dealer has{houseHandValue} ");

            if (playerHand.GiveValueToHand() > 21)
            {
                Console.WriteLine("PLayer busts and dealer wins!");
            }
            else
                       if (houseHand.GiveValueToHand() > 21)
            {
                Console.WriteLine("Dealer busts and player Wins!");
            }
            else if (houseHand.GiveValueToHand() >= playerHand.GiveValueToHand())
            {
                Console.WriteLine("Dealer Wins!");
            }
            else
            {
                Console.WriteLine("Player Wins!");
            }
        }
    }
}
