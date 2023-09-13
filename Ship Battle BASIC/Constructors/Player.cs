using Ship_Battle_BASIC.DataBaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.Constructors
{
    [Table("Player")]
    public class Player
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int CurrentScore { get; set; }
        public int TotalScore { get; set; }
        public int TotalMachesPlayed { get; set; }
        public bool MachInProgress { get; set; }
        public int CurrentHits { get; set; }


        public List<PlayersLog> PlayersLogs { get; set; } = new List<PlayersLog>();


        public Player(string name, int currentScore,int totalScore, int totalMachesPlayed, bool machInProgress)
        {
            Id = Guid.NewGuid();
            Name = name;
            CurrentScore = currentScore;
            TotalScore = totalScore;
            TotalMachesPlayed = totalMachesPlayed;
            MachInProgress = machInProgress;
        }       

        public Player()
        {
        }

        public void SetGameStarted()
        {
            MachInProgress = true;
        }

        public void SetGameEnd()
        {
            TotalMachesPlayed++;
            TotalScore += CurrentScore;
            CurrentScore = 0;
            MachInProgress = false;
            CurrentHits = 0;
        }

    }
}
