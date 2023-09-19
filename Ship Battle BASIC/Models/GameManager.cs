using Ship_Battle_BASIC.Constructors;
using Ship_Battle_BASIC.DataBaseModels;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ship_Battle_BASIC.Models
{
    public class GameManager
    {
        public char greenHit { get; } = '1';
        public char redHit { get; } = '0';
        public char usedCellGreen { get; } = '9';
        public char usedCellRed { get; } = '8';
        public Player CurrPlayer { get; set; }
        public DataGridView dataGridViewObject { get; set; }
        public int TotalGameHits { get; } = 10;
        public void AddScore(int scoreToAdd = 1)
        {
            CurrPlayer.CurrentScore += scoreToAdd;
            Hit();
        }
        public void Hit()
        {
            CurrPlayer.CurrentHits++;
        }
        public bool CheckIfUserHitsReachedLimit()
        {
            return (CurrPlayer.CurrentHits >= TotalGameHits) ? true : false;
        }
        public void UpdatePlayerAndResetPlayer()
        {
            CurrPlayer.SetGameEnd();
            DataBaseManager.UpdatePlayerDataToDb(CurrPlayer, GetGameTable());           
        }
        public void RageQuit()
        {
            if (CurrPlayer.MachInProgress == true)
                DataBaseManager.UpdatePlayerDataToDb(CurrPlayer, GetGameTable());
        }
        public void CheckAndFillBombsField()
        {
            if (CurrPlayer.MachInProgress == true)
            {
                FillUsedBombsIntoTable(CurrPlayer.PlayersLogs.First().GameTable);
                PrepareUsedGameTable();
            }
            else
            {
                FillNewBombsIntoTable();
            }
        }
        public void PrepareUsedGameTable()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    char cellValue = (char)dataGridViewObject.Rows[i].Cells[j].Value;
                    if (cellValue.Equals(usedCellGreen))
                        SetDataGridViewColorsAndSetUsed(i, j, Color.Green);
                    else if (cellValue.Equals(usedCellRed))
                        SetDataGridViewColorsAndSetUsed(i, j, Color.Red);
                }
            };
        }
        private void SetDataGridViewColorsAndSetUsed(int row, int col, Color hitColor)
        {
            dataGridViewObject.Rows[row].Cells[col].Style.BackColor = hitColor;
            dataGridViewObject.Rows[row].Cells[col].Style.ForeColor = hitColor;
        }
        public string GetGameTable()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    stringBuilder.Append(dataGridViewObject[i, j].Value.ToString());
                }
            }
            return stringBuilder.ToString();
        }
        public void FillUsedBombsIntoTable(string gameTable)
        {
            char[] chars = gameTable.ToCharArray();
            Random random = new Random();
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dataGridViewObject[i, j].Value = chars[counter];
                    counter++;
                }
            }
        }
        public void FillNewBombsIntoTable()
        {
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (random.Next(0, 2) == 1)
                        dataGridViewObject[i, j].Value = greenHit;
                    else
                        dataGridViewObject[i, j].Value = redHit;
                }
            }
        }
    }
}