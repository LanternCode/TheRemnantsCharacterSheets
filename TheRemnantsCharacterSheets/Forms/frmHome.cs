using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheRemnantsCharacterSheets.Classes;

namespace TheRemnantsCharacterSheets
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStatistics newChar = new frmStatistics();
            newChar.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCredits_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsUserSettings.languageChoice = 0;
            btnEnglish.Font = new Font(btnEnglish.Font, FontStyle.Bold);
            btnPolish.Font = new Font(btnPolish.Font, FontStyle.Regular);
        }

        private void btnPolish_Click(object sender, EventArgs e)
        {
            clsUserSettings.languageChoice = 0;
            btnEnglish.Font = new Font(btnEnglish.Font, FontStyle.Regular);
            btnPolish.Font = new Font(btnPolish.Font, FontStyle.Bold);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            btnBegin.Text = "Begin creating";
            btnExit.Text = "Exit the generator";
            btnCredits.Text = "Credits";
        }
    }
}
