using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRemnantsCharacterSheets
{
    public class Equipment
    {
        //Name of the equipment piece

        public string Name { get; internal set; }

        //Statistics bonus added by the equipment

        public int HP { get; internal set; }
        public int Agility { get; internal set; }
        public int Speed { get; internal set; }
        public int Appearance { get; internal set; }
        public int Dexterity { get; internal set; }
        public int Dodge { get; internal set; }
        public int Strength { get; internal set; }
        public int BaseAttack { get; internal set; }
        public int Armor { get; internal set; }

        //Talent bonus added by the equipment

        public int TacticAnalysis { get; internal set; }
        public int Tactics { get; internal set; }
        public int Knowledge { get; internal set; }
        public int MeleeRange { get; internal set; }
        public int ShortRange { get; internal set; }
        public int Sorcery { get; internal set; }
        public int Symbolics { get; internal set; }
        public int PassiveIncome { get; internal set; }
        public int WeaponMastery { get; internal set; }
        public int SpellMastery { get; internal set; }
        public int RavenAgility { get; internal set; }

        public static string listBuffs(Equipment equipment)
        {
            String equipmentLine = "";

            Boolean commaRequired = false;
            Boolean commaAdded = false;
            Boolean bracketAdded = false;

            equipmentLine += equipment.Name + " ";

            if (equipment.HP != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                equipmentLine += "HP+" + equipment.HP;
                commaRequired = true;
            }

            if (equipment.Agility != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Agi+" + equipment.Agility;
                commaRequired = true;
            }
            if (equipment.Speed != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Spd+" + equipment.Speed;
                commaRequired = true;
            }
            if (equipment.Appearance != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "App+" + equipment.Appearance;
                commaRequired = true;
            }
            if (equipment.Dexterity != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Dex+" + equipment.Dexterity;
                commaRequired = true;
            }
            if (equipment.Dodge != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Ddg+" + equipment.Dodge;
                commaRequired = true;
            }
            if (equipment.Strength != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Str+" + equipment.Strength;
                commaRequired = true;
            }
            if (equipment.BaseAttack != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Atk+" + equipment.BaseAttack;
                commaRequired = true;
            }
            if (equipment.Armor != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Res+" + equipment.Armor;
                commaRequired = true;
            }

            if (equipment.TacticAnalysis != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "TacticAnalysis+" + equipment.TacticAnalysis;
                commaRequired = true;
            }
            if (equipment.Tactics != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Tactics+" + equipment.Tactics;
                commaRequired = true;
            }
            if (equipment.Knowledge != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Knowledge+" + equipment.Knowledge;
                commaRequired = true;
            }
            if (equipment.MeleeRange != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "MeleeRange+" + equipment.MeleeRange;
                commaRequired = true;
            }
            if (equipment.ShortRange != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "ShortRange+" + equipment.ShortRange;
                commaRequired = true;
            }
            if (equipment.Sorcery != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Sorcery+" + equipment.Sorcery;
                commaRequired = true;
            }
            if (equipment.Symbolics != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "Symbolics+" + equipment.Symbolics;
                commaRequired = true;
            }
            if (equipment.PassiveIncome != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "PassiveIncome+" + equipment.PassiveIncome;
                commaRequired = true;
            }
            if (equipment.WeaponMastery != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "WeaponMastery+" + equipment.WeaponMastery;
                commaRequired = true;
            }
            if (equipment.SpellMastery != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "SpellMastery+" + equipment.SpellMastery;
                commaRequired = true;
            }
            if (equipment.RavenAgility != 0)
            {
                if (commaRequired == false && commaAdded == false && bracketAdded == false) { equipmentLine += "("; bracketAdded = true; }
                if (commaAdded)
                {
                    commaRequired = true;
                    commaAdded = false;
                }
                if (commaRequired)
                {
                    equipmentLine += ", ";
                    commaRequired = false;
                    commaAdded = true;
                }
                equipmentLine += "RavenAgility+" + equipment.RavenAgility;
            }

            if (bracketAdded) equipmentLine += ")";
            equipmentLine += Environment.NewLine;

            return equipmentLine;

        }
    }
}
