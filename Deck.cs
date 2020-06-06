using System;
using System.Collections.Generic;
namespace blackjack
{
    class Deck
    {
        private List<Card> Cards = new List<Card>();
        public void CreateCards()
        {
            var ranks = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
            var suits = new string[] { "Clubs", "Spades", "Diamonds", "Hearts" };


            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    var createdCard = new Card
                    {
                        Suit = suit,
                        Rank = rank,
                    };
                    Cards.Add(createdCard);
                }
            }


            var randomNumberGenerator = new Random();

            for (var index = Cards.Count - 1; index >= 1; index--)
            {
                var otherIndex = randomNumberGenerator.Next(index);

                var firstCard = Cards[index];
                var otherCard = Cards[otherIndex];

                Cards[index] = otherCard;
                Cards[otherIndex] = firstCard;
            }
        }
        public Card Deal()
        {
            var card = Cards[0];
            Cards.Remove(card);
            return card;
        }
    }
}
