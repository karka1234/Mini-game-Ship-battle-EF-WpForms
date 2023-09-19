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

namespace Ship_Battle_BASIC
{
    public partial class FormModeChoose : Form
    {
        private GameManager gameManager;
        public FormModeChoose(GameManager manager)
        {
            InitializeComponent();
            gameManager = manager;
        }

        private void buttonSingle_Click(object sender, EventArgs e)
        {
            FormState.PrevForm = this;//naudot ir kitose
            FormSinglePlayer form = new FormSinglePlayer(gameManager);
            form.Show();
            this.Hide();
        }

        private void buttonPlayerStats_Click(object sender, EventArgs e)
        {
            FormState.PrevForm = this;//naudot ir kitose
            FormStats form = new FormStats();
            form.Show();
            this.Hide();
        }

        private void buttonMulti_Click(object sender, EventArgs e)
        {

        }
    }
}
