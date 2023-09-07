using Ship_Battle_BASIC.Constructors;
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
        public GameManager gameManager = new GameManager();//cia del to nes tipo ilgai loadina gal.. 
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string textBoxInput = textBoxUserName.Text.ToString();
            if (textBoxInput != "")
            {





                gameManager.CurrPlayer = new Player(textBoxInput, 0, 0);    
                
                Form1 form = new Form1(gameManager);
                form.Show();

                this.Hide();
            }
        }
    }
}
