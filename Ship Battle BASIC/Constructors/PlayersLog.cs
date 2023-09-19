using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.Constructors 
{
    [Table("PlayerLog")]
    public class PlayersLog
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? CloseddDate { get; set; }
        [MaxLength(101)]
        public string GameTable { get; set; }       
        public Guid PlayerId { get; set; }
        public Player Player { get; set; }
        public PlayersLog(Guid playerId, string gameTable)
        {
            PlayerId = playerId;
            GameTable = gameTable;
            CreatedDate = DateTime.Now;
        }
        public PlayersLog() { }
    }
}
