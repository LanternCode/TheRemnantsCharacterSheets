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
            Character.Name = txtName.Text.Length > 0 ? txtName.Text : "Mitch Jones";
            Character.Title = txtTitle.Text.Length > 0 ? txtTitle.Text : "The Legend";
            Character.Group = txtGroup.Text.Length > 0 ? txtGroup.Text : "The Crew";
            Character.Rank = txtRank.Text.Length > 0 ? txtRank.Text : "Boi";

            //stats
            Character.Level = txtLevel.Text.Length > 0 ? Convert.ToInt32(txtLevel.Text) : 1;
            Character.Class = txtClass.Text.Length > 0 ? txtClass.Text : "Twitch Streamer";
            Character.HP = txtHP.Text.Length > 0 ? Convert.ToInt32(txtHP.Text) : 100;
            Character.Agility = txtAgi.Text.Length > 0 ? Convert.ToInt32(txtAgi.Text): 90;
            Character.Speed = txtSpd.Text.Length > 0 ? Convert.ToInt32(txtSpd.Text) : 85;
            Character.Appearance = txtApp.Text.Length > 0 ? Convert.ToInt32(txtApp.Text) : 90;
            Character.Dexterity = txtDex.Text.Length > 0 ? Convert.ToInt32(txtDex.Text): 80;
            Character.Dodge = txtDodge.Text.Length > 0 ? Convert.ToInt32(txtDodge.Text) : 75;
            Character.Strength = txtStr.Text.Length > 0 ? Convert.ToInt32(txtStr.Text) : 75;
            Character.BaseAttack = txtAtt.Text.Length > 0 ? Convert.ToInt32(txtAtt.Text): 15;
            Character.Resistance = txtRes.Text.Length > 0 ? Convert.ToInt32(txtRes.Text) : 8;


            frmTalents formTalents = new frmTalents();
            formTalents.ShowDialog();
            this.Close();
        }
    }
}
