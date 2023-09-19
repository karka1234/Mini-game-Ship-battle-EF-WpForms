using Ship_Battle_BASIC.Constructors;
using Ship_Battle_BASIC.DataBaseModels;
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
    public partial class Login : Form
    {
        public GameManager gameManager = new GameManager(); 
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string textBoxInput = textBoxUserName.Text.ToString();
            if (textBoxInput != "" && textBoxInput != "Enter your name")
            {
                gameManager.CurrPlayer = DataBaseManager.CheckPlayerAndGetPlayer(textBoxInput);
                labelTotalMaches form = new labelTotalMaches(gameManager);
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
