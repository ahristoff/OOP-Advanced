using _8_CardGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _8_CardGame
{
    public class Program
    {
        public static List<Card> drawnCards = new List<Card>();

        public static void Main()
        {
            HashSet<Card> cards = GetCards();

            var playerA = new Player(Console.ReadLine());
            var playerB = new Player(Console.ReadLine());

            playerA = GetPlayerCards(playerA, cards);
            playerB = GetPlayerCards(playerB, cards);

            PrintWinner(playerA, playerB);
        }

        private static void PrintWinner(Player playerA, Player playerB)
        {
            var winner = playerA.CompareTo(playerB) > 0 ? playerA : playerB;

            Console.WriteLine($"{winner.Name} wins with {winner.GetMaxCard()}.");
        }

        private static Player GetPlayerCards(Player player, HashSet<Card> cards)
        {
            while (player.Cards.Count < 5)
            {
                Card card = null;
                var cardInfo = Console.ReadLine().Split().ToList();

                try
                {
                    var rank = (CardRank)Enum.Parse(typeof(CardRank), cardInfo[0]);
                    var suit = (CardSuit)Enum.Parse(typeof(CardSuit), cardInfo[2]);

                    card = new Card(rank, suit);

                    if (drawnCards.Any(c => c.Equals(card)))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        player.Cards.Add(card);
                        drawnCards.Add(card);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
            }

            return player;
        }

        private static HashSet<Card> GetCards()
        {
            var suits = Enum.GetNames(typeof(CardSuit));
            var ranks = Enum.GetNames(typeof(CardRank));

            var cards = new HashSet<Card>();

            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 2; j <= ranks.Length + 1; j++)
                {
                    cards.Add(new Card((CardRank)j, (CardSuit)i));
                }
            }

            return cards;
        }
    }
}
