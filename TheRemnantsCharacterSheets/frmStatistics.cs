using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheRemnantsCharacterSheets
{
    public partial class frmStatistics : Form
    {
        public frmStatistics()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //name and title
            Character.Name = txtName.Text.Length > 0 ? txtName.Text : "Mateusz Krzesiński";//"Mitch Jones";
            Character.Title = txtTitle.Text.Length > 0 ? txtTitle.Text : "Legenda Streamingu";
            Character.Group = txtGroup.Text.Length > 0 ? txtGroup.Text : "Twitch.TV";
            Character.Rank = txtRank.Text.Length > 0 ? txtRank.Text : "Szefu";

            //stats
            int value;
            Character.Level = txtLevel.Text.Length > 0 ? (int.TryParse(txtLevel.Text, out value) ? Convert.ToInt32(txtLevel.Text) : 0) : 1;
            Character.Class = txtClass.Text.Length > 0 ? txtClass.Text : "Livestreamer";
            Character.HP = txtHP.Text.Length > 0 ? (int.TryParse(txtHP.Text, out value) ? Convert.ToInt32(txtHP.Text) : 0) : 100;
            Character.Agility = txtAgi.Text.Length > 0 ? (int.TryParse(txtAgi.Text, out value) ? Convert.ToInt32(txtAgi.Text) : 0) : 90;
            Character.Speed = txtSpd.Text.Length > 0 ? (int.TryParse(txtSpd.Text, out value) ? Convert.ToInt32(txtSpd.Text) : 0) : 85;
            Character.Appearance = txtApp.Text.Length > 0 ? (int.TryParse(txtApp.Text, out value) ? Convert.ToInt32(txtApp.Text) : 0) : 90;
            Character.Dexterity = txtDex.Text.Length > 0 ? (int.TryParse(txtDex.Text, out value) ? Convert.ToInt32(txtDex.Text) : 0) : 80;
            Character.Dodge = txtDodge.Text.Length > 0 ? (int.TryParse(txtDodge.Text, out value) ? Convert.ToInt32(txtDodge.Text) : 0) : 75;
            Character.Strength = txtStr.Text.Length > 0 ? (int.TryParse(txtStr.Text, out value) ? Convert.ToInt32(txtStr.Text) : 0) : 75;
            Character.BaseAttack = txtAtt.Text.Length > 0 ? (int.TryParse(txtAtt.Text, out value) ? Convert.ToInt32(txtAtt.Text) : 0) : 15;
            Character.Resistance = txtRes.Text.Length > 0 ? (int.TryParse(txtRes.Text, out value) ? Convert.ToInt32(txtRes.Text) : 0) : 8;


            frmTalents formTalents = new frmTalents();
            formTalents.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
