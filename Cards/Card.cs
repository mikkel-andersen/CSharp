namespace Cards;

public class Card
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }

    public enum Number
    {
        Ace,
        Two,
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
        King
    }

    public Suit CardSuit { get; set; }
    public Number CardNumber { get; set; }

    public Card(Suit suit, Number number)
    {
        CardSuit = suit;
        CardNumber = number;
    }

    public override string ToString()
    {
        return $"Card: {CardNumber} of {CardSuit}";
    }

    public delegate bool FilterCardDelegate(Card card);
}