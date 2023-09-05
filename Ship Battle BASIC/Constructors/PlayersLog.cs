using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.Constructors
{
    internal class PlayersLog
    {
        public Guid Id { get; set; }
        public List<Player> Players { get; set; }   = new List<Player>();

        public PlayersLog(List<Player> players)
        {
            Id = Guid.NewGuid();
            Players = players;
        }

        public PlayersLog() { }
    }
}
