using _3_CardPower.Models;
using System;

namespace _3_CardPower
{
    public class Program
    {
        public static void Main()
        {
            var rankInput = Console.ReadLine();
            var suitInput = Console.ReadLine();

            var cardRank = (CardRank)Enum.Parse(typeof(CardRank), rankInput);
            var cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), suitInput);

            var card = new Card(cardRank, cardSuit);
            card.CardPower();
        }
    }
}