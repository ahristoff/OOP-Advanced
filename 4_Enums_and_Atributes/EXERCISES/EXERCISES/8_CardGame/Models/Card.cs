using System;

namespace _8_CardGame.Models
{
    public class Card : IComparable<Card>
    {
        public Card(CardRank rank, CardSuit suit)
        {
            this.CardRank = rank;
            this.CardSuit = suit;
        }

        public CardRank CardRank { get; private set; }

        public CardSuit CardSuit { get; private set; }

        public int CardPower()
        {
            return (int)this.CardSuit * 13 + (int)this.CardRank;
        }

        public int CompareTo(Card other)
        {
            return other.CardPower().CompareTo(this.CardPower());
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var otherCard = obj as Card;
            return this.CardRank == otherCard.CardRank &&
                   this.CardSuit == otherCard.CardSuit;
        }

        public override string ToString()
        {
            return $"{this.CardRank} of {this.CardSuit}";
        }
    }
}