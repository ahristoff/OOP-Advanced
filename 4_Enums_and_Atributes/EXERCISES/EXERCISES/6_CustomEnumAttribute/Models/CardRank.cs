using _6_CustomEnumAttribute.Attributes;

namespace _6_CustomEnumAttribute.Models
{
    [Type("Enumeration", "Rank", "Provides rank constants for a Card class.")]
    public enum CardRank
    {
        Two = 2,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
