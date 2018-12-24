﻿using _4_CardToString.Models;
using System;

namespace _4_CardToString
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
            Console.WriteLine(card.ToString());
        }
    }
}