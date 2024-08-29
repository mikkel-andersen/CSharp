using Cards;

class Program
{
    static void Main(string[] args)
    {
        CardGame game = new CardGame();
        game.AddCard(Card.Suit.Hearts, Card.Number.Ace);
        game.AddCard(Card.Suit.Spades, Card.Number.King);
        game.AddCard(Card.Suit.Clubs, Card.Number.Two);
        game.AddCard(Card.Suit.Diamonds, Card.Number.Queen);
        game.AddCard(Card.Suit.Hearts, Card.Number.Jack);

        List<Card> billedKort = game.filterCardGame(FilterByBilledKort);
        Console.WriteLine("BilledKort:");
        foreach (var card in billedKort)
        {
            Console.WriteLine(card);
        }

        List<Card> nonBilledKort = game.filterCardGame(FilterByNonBilledKort);
        Console.WriteLine("Non-BilledKort:");
        foreach (var card in nonBilledKort)
        {
            Console.WriteLine(card);
        }
    }

    static public bool FilterByBilledKort(Card card)
    {
        return card.CardNumber == Card.Number.Jack || 
               card.CardNumber == Card.Number.Queen || 
               card.CardNumber == Card.Number.King;
    }

    static public bool FilterByNonBilledKort(Card card)
    {
        return card.CardNumber != Card.Number.Jack && 
               card.CardNumber != Card.Number.Queen && 
               card.CardNumber != Card.Number.King;
    }
}