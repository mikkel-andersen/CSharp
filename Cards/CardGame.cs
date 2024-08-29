namespace Cards;

public class CardGame
{
    private List<Card> _cards = new List<Card>();

    public void AddCard(Card.Suit suit, Card.Number number)
    {
        _cards.Add(new Card(suit, number));
    }

    public List<Card> filterCardGame(Card.FilterCardDelegate filter)
    {
        List<Card> filteredCards = new List<Card>();
        foreach (var card in _cards)
        {
            if (filter(card))
            {
                filteredCards.Add(card);
            }
        }
        return filteredCards;
    }

    public override string ToString()
    {
        return string.Join(", ", _cards);
    }
}