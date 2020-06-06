namespace blackjack
{
    class Card
    {
        public string Rank { get; set; }
        public string Suit { get; set; }
        public int CardValue()
        {
            switch (Rank)
            {
                case "10":

                case "Jack":

                case "Queen":

                case "King":
                    return 10;

                case "Ace":
                    return 11;

                default:
                    return int.Parse(Rank);

            }
        }
    }
}