using Ship_Battle_BASIC.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ship_Battle_BASIC.Models
{
    internal class GameManager
    {
        /// <summary>
        /// if score minuse tada stabdom game 
        /// </summary>

        public Player CurrPlayer { get; set; }


        public void AddScore(int scoreToAdd = 1)
        {
            CurrPlayer.CurrentScore += scoreToAdd;
        }

        public void SubtractScore(int scoreToSub = 1)
        {
            CurrPlayer.CurrentScore -= scoreToSub;
        }
    }
}
