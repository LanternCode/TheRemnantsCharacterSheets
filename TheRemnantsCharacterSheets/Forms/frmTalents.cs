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
    public partial class frmTalents : Form
    {
        public frmTalents()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Character.TacticAnalysis = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtTacticAnalysis.Text) : 0;
            Character.Tactics = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtTactics.Text) : 0;
            Character.Knowledge = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtKnowledge.Text) : 0;
            Character.MeleeRange = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtMeleeRange.Text) : 0;
            Character.ShortRange = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtShortRange.Text) : 0;
            Character.Sorcery = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtSorcery.Text) : 0;
            Character.Faith = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtFaith.Text) : 0;
            Character.Symbolics = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtSymbolics.Text) : 0;
            Character.PassiveIncome = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtPassiveIncome.Text) : 0;
            Character.WeaponMastery = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtWeaponMastery.Text) : 0;
            Character.SpellMastery = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtSpellMastery.Text) : 0;
            Character.RavenAgility = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtRavenAgility.Text) : 0;

            frmAddSkill stepThree = new frmAddSkill();
            stepThree.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
