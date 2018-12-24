using _6_CustomEnumAttribute.Attributes;

namespace _6_CustomEnumAttribute.Models
{
    [Type("Enumeration", "Suit", "Provides suit constants for a Card class.")]
    public enum CardSuit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}