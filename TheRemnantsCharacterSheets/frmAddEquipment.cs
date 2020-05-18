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
            if (Character.Equipment.Count == 0) lblEquipmentAdded.Text = "No items were added yet!";
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

            anItem.Name = txtName.Text;

            anItem.HP = Convert.ToInt32(txtHP.Text);
            anItem.Agility = Convert.ToInt32(txtAgi.Text);
            anItem.Speed = Convert.ToInt32(txtSpd.Text);
            anItem.Appearance = Convert.ToInt32(txtApp.Text);
            anItem.Dexterity = Convert.ToInt32(txtDex.Text);
            anItem.Dodge = Convert.ToInt32(txtDodge.Text);
            anItem.Strength = Convert.ToInt32(txtStr.Text);
            anItem.BaseAttack = Convert.ToInt32(txtAtt.Text);
            anItem.Armor = Convert.ToInt32(txtRes.Text);

            anItem.TacticAnalysis = Convert.ToInt32(txtTacticAnalysis.Text);
            anItem.Tactics = Convert.ToInt32(txtTactics.Text);
            anItem.Knowledge = Convert.ToInt32(txtKnowledge.Text);
            anItem.MeleeRange = Convert.ToInt32(txtMeleeRange.Text);
            anItem.ShortRange = Convert.ToInt32(txtShortRange.Text);
            anItem.Sorcery = Convert.ToInt32(txtSorcery.Text);
            anItem.Symbolics = Convert.ToInt32(txtSymbolics.Text);
            anItem.PassiveIncome = Convert.ToInt32(txtPassiveIncome.Text);
            anItem.WeaponMastery = Convert.ToInt32(txtWeaponMastery.Text);
            anItem.SpellMastery = Convert.ToInt32(txtSpellMastery.Text);
            anItem.RavenAgility = Convert.ToInt32(txtRavenAgility.Text);

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
            newItems.ShowDialog();
            this.Close();
        }
    }
}
