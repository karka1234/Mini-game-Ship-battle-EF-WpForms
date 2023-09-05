using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.Constructors
{
    internal class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CurrentScore { get; set; }
        public int TotalScore { get; set; }
        

        //[ForeignKey("PlayerLogs")]
        //public Guid PlayerLogId { get; set; }

        public Player(string name, int currentScore,int totalScore)
        {
            Id = Guid.NewGuid();
            Name = name;
            CurrentScore = currentScore;
            TotalScore = totalScore;
        }
        public Player()
        {
        }
    }
}
