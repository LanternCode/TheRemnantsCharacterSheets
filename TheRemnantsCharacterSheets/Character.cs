using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRemnantsCharacterSheets
{
    public static class Character
    {
        //About the character
        public static string Name { get; internal set; }
        public static string Title { get; internal set; }
        public static string Group { get; internal set; }
        public static string Rank { get; internal set; }

        //The character's stats
        public static int Level { get; internal set; }
        public static string Class { get; internal set; }
        public static int HP { get; internal set; }
        public static int Agility { get; internal set; }
        public static int Speed { get; internal set; }
        public static int Appearance { get; internal set; }
        public static int Dexterity { get; internal set; }
        public static int Dodge { get; internal set; }
        public static int Strength { get; internal set; }
        public static int BaseAttack { get; internal set; }
        public static int Resistance { get; internal set; }

        //The character's talents
        public static int TacticAnalysis { get; internal set; }
        public static int Tactics { get; internal set; }
        public static int Knowledge { get; internal set; }
        public static int MeleeRange { get; internal set; }
        public static int ShortRange { get; internal set; }
        public static int Sorcery { get; internal set; }
        public static int Faith { get; internal set; }
        public static int Symbolics { get; internal set; }
        public static int PassiveIncome { get; internal set; }
        public static int WeaponMastery { get; internal set; }
        public static int SpellMastery { get; internal set; }
        public static int RavenAgility { get; internal set; }

        //Skills owned by the character
        public static List<Skill> Skills { get; internal set; } = new List<Skill>();

        //Equipment owned by the character
        public static List<Equipment> Equipment { get; internal set; } = new List<Equipment>();

        //Consumable items owned by the character
        public static int Oasis { get; internal set; }
        public static int Monster { get; internal set; }
        public static int Doritos { get; internal set; }
        public static int Coke { get; internal set; }
        public static int ColaOriginal { get; internal set; }
        public static int Crawford { get; internal set; }
        public static int HotDog { get; internal set; }
        public static int Brownie { get; internal set; }
        public static int WhitePotion { get; internal set; }
        public static int YellowPotion { get; internal set; }
        public static int Maltesers { get; internal set; }
        public static int RedPotion { get; internal set; }
        public static int GreenPotion { get; internal set; }
        public static int Gfuel { get; internal set; }
        public static int HoolaHoops { get; internal set; }
        public static int AppSeed { get; internal set; }
        public static int MauvePotion { get; internal set; }
        public static int DairyMilk { get; internal set; }
        public static int Coffee { get; internal set; }
        public static int Dobrowianka { get; internal set; }
        public static int MtnDew { get; internal set; }
        public static int DrPepper { get; internal set; }
        public static int BarrCreamSoda { get; internal set; }
        public static int StrSeed { get; internal set; }
        public static int AgiSeed { get; internal set; }
        public static int ResSeed { get; internal set; }
        public static int SpdSeed { get; internal set; }
        public static int HpSeed { get; internal set; }
        public static int ItemCount { get; internal set; }
    }
}
