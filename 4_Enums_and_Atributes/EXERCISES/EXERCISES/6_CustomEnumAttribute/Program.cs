using _6_CustomEnumAttribute.Models;
using System;
using System.Reflection;

namespace _6_CustomEnumAttribute
{
    public class Program
    {
        public static void Main()
        {
            var typeInput = Console.ReadLine();
            
            if (typeInput == "Suit")
            {
               var attributes = typeof(CardSuit).GetCustomAttributes();
                Console.WriteLine(string.Join(Environment.NewLine, attributes));
            }

            else if (typeInput == "Rank")
            {
                var attributes = typeof(CardRank).GetCustomAttributes();
                Console.WriteLine(string.Join(Environment.NewLine, attributes));
            }
        }
    }
}
