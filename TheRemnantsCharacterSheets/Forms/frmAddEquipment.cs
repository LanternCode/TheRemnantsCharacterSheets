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
    public partial class frmAddEquipment : Form
    {
        public frmAddEquipment()
        {
            InitializeComponent();
            UpdateEquipmentList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Character.Equipment = new List<Equipment>();
            UpdateEquipmentList();
        }

        public void UpdateEquipmentList()
        {
            if (Character.Equipment.Count == 0) lblEquipmentAdded.Text = "Nie dodano jeszcze ekwipunku!";
            else
            {
                lblEquipmentAdded.Text = ""; //reset the label before adding content to it
                foreach (Equipment equipment in Character.Equipment)
                {
                    lblEquipmentAdded.Text += Equipment.listBuffs(equipment);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Equipment anItem = new Equipment();

            anItem.Name = txtName.Text.Length > 0 ? txtName.Text : "Przedmiot";

            anItem.HP = int.TryParse(txtHP.Text, out _) ? Convert.ToInt32(txtHP.Text) : 0;
            anItem.Agility = int.TryParse(txtAgi.Text, out _) ? Convert.ToInt32(txtAgi.Text) : 0;
            anItem.Speed = int.TryParse(txtSpd.Text, out _) ? Convert.ToInt32(txtSpd.Text) : 0;
            anItem.Appearance = int.TryParse(txtApp.Text, out _) ? Convert.ToInt32(txtApp.Text) : 0;
            anItem.Dexterity = int.TryParse(txtDex.Text, out _) ? Convert.ToInt32(txtDex.Text) : 0;
            anItem.Dodge = int.TryParse(txtDodge.Text, out _) ? Convert.ToInt32(txtDodge.Text) : 0;
            anItem.Strength = int.TryParse(txtStr.Text, out _) ? Convert.ToInt32(txtStr.Text) : 0;
            anItem.BaseAttack = int.TryParse(txtAtt.Text, out _) ? Convert.ToInt32(txtAtt.Text) : 0;
            anItem.Armor = int.TryParse(txtRes.Text, out _) ? Convert.ToInt32(txtRes.Text) : 0;

            anItem.TacticAnalysis = int.TryParse(txtTacticAnalysis.Text, out _) ? Convert.ToInt32(txtTacticAnalysis.Text) : 0;
            anItem.Tactics = int.TryParse(txtTactics.Text, out _) ? Convert.ToInt32(txtTactics.Text) : 0;
            anItem.Knowledge = int.TryParse(txtKnowledge.Text, out _) ? Convert.ToInt32(txtKnowledge.Text) : 0;
            anItem.MeleeRange = int.TryParse(txtMeleeRange.Text, out _) ? Convert.ToInt32(txtMeleeRange.Text) : 0;
            anItem.ShortRange = int.TryParse(txtShortRange.Text, out _) ? Convert.ToInt32(txtShortRange.Text) : 0;
            anItem.Sorcery = int.TryParse(txtSorcery.Text, out _) ? Convert.ToInt32(txtSorcery.Text) : 0;
            anItem.Symbolics = int.TryParse(txtSymbolics.Text, out _) ? Convert.ToInt32(txtSymbolics.Text) : 0;
            anItem.PassiveIncome = int.TryParse(txtPassiveIncome.Text, out _) ? Convert.ToInt32(txtPassiveIncome.Text) : 0;
            anItem.WeaponMastery = int.TryParse(txtWeaponMastery.Text, out _) ? Convert.ToInt32(txtWeaponMastery.Text) : 0;
            anItem.SpellMastery = int.TryParse(txtSpellMastery.Text, out _) ? Convert.ToInt32(txtSpellMastery.Text) : 0;
            anItem.RavenAgility = int.TryParse(txtRavenAgility.Text, out _) ? Convert.ToInt32(txtRavenAgility.Text) : 0;

            Character.Equipment.Add(anItem);

            txtName.Clear();

            txtHP.Text = "0";
            txtAgi.Text = "0";
            txtSpd.Text = "0";
            txtApp.Text = "0";
            txtDex.Text = "0";
            txtDodge.Text = "0";
            txtStr.Text = "0";
            txtAtt.Text = "0";
            txtRes.Text = "1";

            txtTacticAnalysis.Text = "0";
            txtTactics.Text = "0";
            txtKnowledge.Text = "0";
            txtMeleeRange.Text = "0";
            txtShortRange.Text = "0";
            txtSorcery.Text = "0";
            txtSymbolics.Text = "0";
            txtPassiveIncome.Text = "0";
            txtWeaponMastery.Text = "0";
            txtSpellMastery.Text = "0";
            txtRavenAgility.Text = "0";

            UpdateEquipmentList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmItems newItems = new frmItems();
            newItems.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
