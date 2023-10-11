using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lektion04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CardGame<Card> list = new CardGame<Card>();

            list.AddCard(Suit.Clubs, Number.Queen);


        }
    }
}
