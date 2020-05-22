using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRemnantsCharacterSheets
{
    public class Skill
    {
        //A single skill to be used in the game

        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int Priority { get; internal set; }
        public bool Passive { get; internal set; }

        public static string listSkill(Skill skill)
        {
            String line = "";

            //Is the skill passive?
            if (skill.Passive)
                line += "(Pasywna) ";

            //Add name
            line += skill.Name.Length > 0 ? skill.Name : "Umiejętność";

            //Add description
            if (skill.Description.Length > 0)
                line += " - " + skill.Description;

            //Only regular, non-passive skills have priority assigned
            if (!skill.Passive)
                line += " (" + skill.Priority + ")";

            //Add a dot that ends the sentence and put a new line before listing another skill
            line += '.' + Environment.NewLine;

            return line;
        }
    }
}
