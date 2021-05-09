using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Britnee Murrin\OneDrive\Desktop\FolderA\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
        }
    }
}
