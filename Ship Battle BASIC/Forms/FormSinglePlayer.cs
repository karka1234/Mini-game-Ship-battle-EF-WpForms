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
    public partial class FormSinglePlayer : Form
    {
        private GameManager GameManager = new GameManager();
        public FormSinglePlayer(GameManager gameManager)
        {
            InitializeComponent();
            GameManager = gameManager;
            GameManager.dataGridViewObject = dataGridView1;
            SetLabelsForPlayerInfo();
        }
        private void gameStartButton_Click(object sender, EventArgs e)
        {
            InitTableView();
            gameStartButton.Enabled = false;
            GameManager.CheckAndFillBombsField();
            GameManager.CurrPlayer.SetGameStarted();
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
                col.Width = 45;
                dataGridView1.Columns.Add(col);
                var row = new DataGridViewRow();
                row.HeaderCell.Value = Convert.ToChar(65 + i).ToString();
                row.Height = 45;
                dataGridView1.Rows.Add(row);
            }
        }
        private void SetLabelsForPlayerInfo()
        {
            if (GameManager.CurrPlayer.MachInProgress == true)
                gameStartButton.Text = "Continue";
            labelUserName.Text = GameManager.CurrPlayer.Name;
            labelTotalScore.Text = $"{GameManager.CurrPlayer.TotalScore.ToString()}";
            labelMaxGamePoints.Text = $"/ {GameManager.TotalGameHits}";
            labelTotalMach.Text = GameManager.CurrPlayer.TotalMachesPlayed.ToString();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ManageHitAndSetCellColors(e);

            currentScore.Text = GameManager.CurrPlayer.CurrentScore.ToString();
            dataGridView1.ClearSelection();

            ChekIfGameEnded();
        }
        private void ChekIfGameEnded()
        {
            if (GameManager.CheckIfUserHitsReachedLimit())
            {
                ShowGameResults();
                GameManager.UpdatePlayerAndResetPlayer();
                ResetGameWindow();
            }
        }
        private void ShowGameResults()
        {
            MessageBox.Show($"Game Over\r\n" +
                $"Collected Score: {GameManager.CurrPlayer.CurrentScore} / {GameManager.TotalGameHits}\r\n" +
                $"Total Score: {GameManager.CurrPlayer.TotalScore}");
            SetLabelsForPlayerInfo();
        }
        private void ManageHitAndSetCellColors(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                char cellVValue = (char)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;//castinu jauciu ner gerai
                if (cellVValue.Equals(GameManager.greenHit))
                {
                    SetDataGridViewColorsAndSetUsed(e, Color.DarkGreen, GameManager.usedCellGreen);
                    GameManager.AddScore();
                }
                else if (cellVValue.Equals(GameManager.redHit))
                {
                    SetDataGridViewColorsAndSetUsed(e, Color.DarkRed, GameManager.usedCellRed);
                    GameManager.Hit();
                }
            }
        }
        private void SetDataGridViewColorsAndSetUsed(DataGridViewCellEventArgs e, Color hitColor, char usedCellColor)
        {
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = usedCellColor;
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = hitColor;
            dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = hitColor;
        }
        private void ResetGameWindow()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            gameStartButton.Enabled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            GameManager.RageQuit();
            System.Environment.Exit(0);
        }
        private void buttonResetTableView_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GameManager.GetGameTable());
        }
    }
}
