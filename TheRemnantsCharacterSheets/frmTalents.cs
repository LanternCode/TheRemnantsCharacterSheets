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
            Character.TacticAnalysis = Convert.ToInt32(txtTacticAnalysis.Text);
            Character.Tactics = Convert.ToInt32(txtTactics.Text);
            Character.Knowledge = Convert.ToInt32(txtKnowledge.Text);
            Character.MeleeRange = Convert.ToInt32(txtMeleeRange.Text);
            Character.ShortRange = Convert.ToInt32(txtShortRange.Text);
            Character.Sorcery = Convert.ToInt32(txtSorcery.Text);
            Character.Faith = Convert.ToInt32(txtFaith.Text);
            Character.Symbolics = Convert.ToInt32(txtSymbolics.Text);
            Character.PassiveIncome = Convert.ToInt32(txtPassiveIncome.Text);
            Character.WeaponMastery = Convert.ToInt32(txtWeaponMastery.Text);
            Character.SpellMastery = Convert.ToInt32(txtSpellMastery.Text);
            Character.RavenAgility = Convert.ToInt32(txtRavenAgility.Text);

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
