using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLackjackGame
{
    public class Dealer 
    {
        public string Name { get; set; }
        public Deck Deck { get; set; } // "HAS A" IS WHY THIS IS A PROPERTY OF DEALER INSTEAD OF "IS A" WHERE YOU WOULD HAVE IT INHERIRATE FROM DECK CLASS
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");
            Deck.Cards.RemoveAt(0);
        }
    }
}
