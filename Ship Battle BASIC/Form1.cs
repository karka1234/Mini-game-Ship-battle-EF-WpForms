using Ship_Battle_BASIC.Constructors;
using Ship_Battle_BASIC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Ship_Battle_BASIC
{
    public partial class Form1 : Form
    {
        //Lentelej prisijungia vartotojas ir jei irasomas esamaas tada tesia zaidima,
        //jei irasomas naujas sukuria vartotoja

        //padaryt kad gamemanageris suformuotu grida datasete gal kokiam ir tada uploadintu

        GameManager GameManager = new GameManager();        

        public Form1(GameManager gameManager)
        {
            InitializeComponent();
            GameManager = gameManager;
        }
        private void gameStartButton_Click(object sender, EventArgs e)
        {
            gameStartButton.Enabled = false;
            InitTableView();
            GameManager.FillNewBombsIntoTable(dataGridView1);
            dataGridView1.ClearSelection();
            labelUserName.Text = GameManager.CurrPlayer.Name;
            labelTotalScore.Text = GameManager.CurrPlayer.TotalScore.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(GameManager.greenHit))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = GameManager.usedCell;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DarkGreen;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.DarkGreen;

                    GameManager.AddScore();                
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(GameManager.redHit))
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = GameManager.usedCell;                
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.DarkRed;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.DarkRed;                

                    GameManager.Hit();
                }

            currentScore.Text = GameManager.CurrPlayer.CurrentScore.ToString();
            dataGridView1.ClearSelection();

            if(GameManager.CheckIfUserHitsReachedLimit()) 
            {
                MessageBox.Show($"Game Over\r\n" +
                    $"Collected Score: {GameManager.CurrPlayer.CurrentScore} / {GameManager.TotalGameHits}\r\n" +
                    $"Total Score: {GameManager.CurrPlayer.TotalScore}");

                GameManager.ResetGame();
                GameManager.ResetPlayerDate();

                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();

                gameStartButton.Enabled = true;
            }
        }

        private void InitTableView()
        {
            for (int i = 0; i < 10; i++)
            {
                var col = new DataGridViewButtonColumn();
                col.FlatStyle = FlatStyle.Flat;
               
                col.DefaultCellStyle.BackColor = Color.Gray;
                col.DefaultCellStyle.ForeColor = Color.Gray;

                col.Name = i.ToString();
                col.Width = 40;
                dataGridView1.Columns.Add(col);

                var row = new DataGridViewRow();
                row.HeaderCell.Value = Convert.ToChar(65 + i).ToString();
                row.Height = 40;
                dataGridView1.Rows.Add(row);
            }
        }





    }
}
