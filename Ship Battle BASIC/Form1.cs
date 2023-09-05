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

        GameManager gameManager = new GameManager();

        public Form1()
        {
            InitializeComponent();
            InitTableView();
            FillNewBombsIntoTable();


        }


        private void InitTableView()
        {
            for (int i = 0; i < 10; i++)
            {
                var col = new DataGridViewButtonColumn();
                col.Name = i.ToString();
                col.Width = 40;
                dataGridView1.Columns.Add(col);

                var row = new DataGridViewRow();
                row.HeaderCell.Value = Convert.ToChar(65 + i).ToString();
                row.Height = 40;
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.AllowUserToAddRows = false; 
        }
        private void FillNewBombsIntoTable()
        {
            Random random = new Random();   
            for(int i = 0;i < dataGridView1.Rows.Count; i++) 
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++) 
                {
                    dataGridView1[i, j].Value = random.Next(0,2);
                }
            }   
        }




        //handlers
        private void loginButton_Click(object sender, EventArgs e)
        {
            string userInput = userNameInputBox.Text;
            if (userInput != "")
            {
                gameManager.CurrPlayer = new Player(userInput, 0, 0);
                userName.Text = userInput;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var aaa = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.Equals(1))
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 10;
                gameManager.AddScore();
                currentScore.Text = gameManager.CurrPlayer.CurrentScore.ToString();
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 10;
                gameManager.SubtractScore();
                currentScore.Text = gameManager.CurrPlayer.CurrentScore.ToString();
            }
                
        }

    }
}
