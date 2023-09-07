using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public void SetTotalScoreAndResetCurrentScore()
        {
            TotalScore += CurrentScore;
            CurrentScore = 0;
        }
    }
}
