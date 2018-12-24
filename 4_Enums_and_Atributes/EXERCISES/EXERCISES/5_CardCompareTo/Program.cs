using _5_CardCompareTo.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _5_CardCompareTo
{
    public class Program
    {
        public static void Main()
        {
            var cards = new SortedSet<Card>();

            Card cardA = GetCard();
            Card cardB = GetCard();

            cards.Add(cardA);
            cards.Add(cardB);

            var first = cards.First();
    
            Console.WriteLine(first.ToString());
        }

        private static Card GetCard()
        {
            var rankInput = Console.ReadLine();
            var suitInput = Console.ReadLine();

            var cardRank = (CardRank)Enum.Parse(typeof(CardRank), rankInput);
            var cardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), suitInput);

            return new Card(cardRank, cardSuit);
        }
    }
}
