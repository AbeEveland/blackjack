using System;
using System.Collections.Generic;

namespace blackjack
{
    class Hands
    {
        public List<Card> Hand = new List<Card>();

        public void HoldCard(Card dealtCard)
        {
            Hand.Add(dealtCard);
        }

        public void DisplayCards()
        {
            foreach (var card in Hand)
            {
                Console.WriteLine($"{card.Rank} of {card.Suit}");

            }
        }
        public int GiveValueToHand()
        {
            var total = 0;

            foreach (var card in Hand)
            {
                var valueOfCard = card.CardValue();

                total = total + valueOfCard;
            }
            return total;
        }
    }
}