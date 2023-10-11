using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion04_2
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
        King,
        Ace
    }

    public class Card
    {
        public Suit Suit;
        public Number Number;

        public Card(Suit suit, Number number)
        {
            this.Suit = suit;
            this.Number = number;
        }

        public override string ToString()
        {
            return Suit + " " + Number;
        }
    }

}
