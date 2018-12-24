using System;

namespace _3_CardPower.Models
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

        public void CardPower()
        {
            Console.WriteLine($"Card name: {this.CardRank} of {this.CardSuit}; Card power: {(int)this.CardSuit + (int)this.CardRank}");
        }
    }
}
