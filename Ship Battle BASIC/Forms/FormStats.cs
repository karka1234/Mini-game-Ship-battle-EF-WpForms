using Ship_Battle_BASIC.DataBaseModels;
using Ship_Battle_BASIC.Forms.Models;
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
    public partial class FormStats : Form
    {
        public FormStats()
        {
            InitializeComponent();
            InitDataGridView();
        }
        private void InitDataGridView()
        {
            DataBaseManager.GetAllPlayersStatsAndSetToView(dataGridView1);
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PrevForm.Show();
        }
    }
}
