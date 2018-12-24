using _7_DeckOfCards.Models;
using System;
using System.Collections.Generic;

namespace _7_DeckOfCards
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            if (input == "Card Deck")
            {
                HashSet<Card> cards = GetCards();
                Console.WriteLine(string.Join(Environment.NewLine, cards));
            }
        }

        private static HashSet<Card> GetCards()
        {
            var suits = Enum.GetNames(typeof(CardSuit));
            var ranks = Enum.GetNames(typeof(CardRank));

            var cards = new HashSet<Card>();

            for (int i = 0; i < suits.Length; i++)
            {               
                for (int j = 1; j <= ranks.Length; j++)
                {
                    cards.Add(new Card((CardRank)j, (CardSuit)i));
                }               
            }

            return cards;
        }
    }
}