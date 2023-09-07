using Ship_Battle_BASIC.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ship_Battle_BASIC.Models
{
    public class GameManager//saugoti info db gal kartu su datasetu
    {
        public int greenHit { get; } = 1;
        public int redHit { get; } = 0;
        public int usedCell { get; } = 99;



        public Player CurrPlayer { get; set; }

        public int CurrentHits = 0;

        public int TotalGameHits = 5;



        public void AddScore(int scoreToAdd = 1)
        {
            CurrPlayer.CurrentScore += scoreToAdd;
            Hit();
        }

        public void Hit()
        {
            CurrentHits++;
        }

        public bool CheckIfUserHitsReachedLimit()        
        { 
            return (CurrentHits >= TotalGameHits) ? true : false;
        }

        public void ResetGame()
        {
            CurrentHits = 0;
        }
        public void ResetPlayerDate()
        {
            CurrPlayer.SetTotalScoreAndResetCurrentScore();
        }

        public void FillNewBombsIntoTable(DataGridView dataGridView1)//uzpildysim su data setu ir custom laivais/ data seta paleidziant tikrint ir pazymet laukus raudonai
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridView1[i, j].Value = random.Next(0, 2);
                }
            }
        }

    }
}
