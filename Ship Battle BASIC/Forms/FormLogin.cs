using Ship_Battle_BASIC.Constructors;
using Ship_Battle_BASIC.DataBaseModels;
using Ship_Battle_BASIC.Forms.Models;
using Ship_Battle_BASIC.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Ship_Battle_BASIC
{
    public partial class FormLogin : Form
    {
        private SingleGameManager gameManager = new SingleGameManager();
        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string textBoxInput = textBoxUserName.Text.ToString();
            if (textBoxInput != "" && textBoxInput != "Enter your name")
            {
                FormState.PrevForm = this;//naudot ir kitose
                gameManager.CurrPlayer = DataBaseManager.CheckPlayerAndGetPlayer(textBoxInput);
                FormModeChoose form = new FormModeChoose(gameManager);
                form.Show();
                this.Hide();
            }
        }
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
