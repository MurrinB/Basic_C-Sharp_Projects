using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLackjackGame
{
    public abstract class Game // ABSTRACT LOCKS THE CLASS SO YOU CAN NEVER CREATE AN INSTANCE OF THE CLASS
    {
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
       
        public abstract void Play(); // ANY CLASS INHERITING GAME CLASS WILL HAVE THIS METHOD
        
        public virtual void ListPlayers() // METHOD GETS INHERITED BY INHERITING CLASS BUT CAN BE OVERRIDEN
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
