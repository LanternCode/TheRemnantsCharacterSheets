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
                lblEquipmentAdded.Text = "";
                Boolean commaRequired = false;
                Boolean commaAdded = false;
                Boolean bracketAdded = false;
                foreach (Equipment equipment in Character.Equipment)
                {
                    lblEquipmentAdded.Text += equipment.Name + " ";

                    if (equipment.HP != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        lblEquipmentAdded.Text += "HP+" + equipment.HP;
                        commaRequired = true;
                    }

                    if (equipment.Agility != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Agi+" + equipment.Agility;
                        commaRequired = true;
                    }
                    if (equipment.Speed != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Spd+" + equipment.Speed;
                        commaRequired = true;
                    }
                    if (equipment.Appearance != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "App+" + equipment.Appearance;
                        commaRequired = true;
                    }
                    if (equipment.Dexterity != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Dex+" + equipment.Dexterity;
                        commaRequired = true;
                    }
                    if (equipment.Dodge != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Ddg+" + equipment.Dodge;
                        commaRequired = true;
                    }
                    if (equipment.Strength != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Str+" + equipment.Strength;
                        commaRequired = true;
                    }
                    if (equipment.BaseAttack != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Atk+" + equipment.BaseAttack;
                        commaRequired = true;
                    }
                    if (equipment.Armor != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Res+" + equipment.Armor;
                        commaRequired = true;
                    }

                    if (equipment.TacticAnalysis != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "TacticAnalysis+" + equipment.TacticAnalysis;
                        commaRequired = true;
                    }
                    if (equipment.Tactics != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Tactics+" + equipment.Tactics;
                        commaRequired = true;
                    }
                    if (equipment.Knowledge != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Knowledge+" + equipment.Knowledge;
                        commaRequired = true;
                    }
                    if (equipment.MeleeRange != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "MeleeRange+" + equipment.MeleeRange;
                        commaRequired = true;
                    }
                    if (equipment.ShortRange != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "ShortRange+" + equipment.ShortRange;
                        commaRequired = true;
                    }
                    if (equipment.Sorcery != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Sorcery+" + equipment.Sorcery;
                        commaRequired = true;
                    }
                    if (equipment.Symbolics != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "Symbolics+" + equipment.Symbolics;
                        commaRequired = true;
                    }
                    if (equipment.PassiveIncome != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "PassiveIncome+" + equipment.PassiveIncome;
                        commaRequired = true;
                    }
                    if (equipment.WeaponMastery != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "WeaponMastery+" + equipment.WeaponMastery;
                        commaRequired = true;
                    }
                    if (equipment.SpellMastery != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "SpellMastery+" + equipment.SpellMastery;
                        commaRequired = true;
                    }
                    if (equipment.RavenAgility != 0)
                    {
                        if (commaRequired == false && commaAdded == false && bracketAdded == false){lblEquipmentAdded.Text += "("; bracketAdded = true;}
                        if (commaAdded)
                        {
                            commaRequired = true;
                            commaAdded = false;
                        }
                        if (commaRequired)
                        {
                            lblEquipmentAdded.Text += ", ";
                            commaRequired = false;
                            commaAdded = true;
                        }
                        lblEquipmentAdded.Text += "RavenAgility+" + equipment.RavenAgility;
                    }

                    if (bracketAdded) lblEquipmentAdded.Text += ")";
                    lblEquipmentAdded.Text += Environment.NewLine;
                    commaRequired = false;
                    commaAdded = false;
                    bracketAdded = false;
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
