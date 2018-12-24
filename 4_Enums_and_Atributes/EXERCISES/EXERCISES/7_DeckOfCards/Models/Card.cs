
namespace _7_DeckOfCards.Models
{
    public class Card 
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.CardRank = rank;
            this.CardSuit = suit;
        }

        public CardRank CardRank { get; private set; }

        public CardSuit CardSuit { get; private set; }

        private int CardPower()
        {
            return (int)this.CardSuit + (int)this.CardRank;
        }

        public override string ToString()
        {
            return $"{this.CardRank} of {this.CardSuit}";
        }
    }
}
