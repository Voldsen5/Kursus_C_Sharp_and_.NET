using Lektion04_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class CardGame<Card>
{
    private List<Card> cards = new List<Card>();

    public List<Card> Cards
    {
        get { return cards; }
    }

    public void AddCard(Suit s, Number n)
    {
        Card card = new Card(s, n);
        cards.Add(card);
    }

    public void RemoveCard(Card card)
    {
        cards.Remove(card);
    }
}

