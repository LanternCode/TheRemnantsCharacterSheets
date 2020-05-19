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
    }
}
