using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRemnantsCharacterSheets
{
    public class Skill
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public int Priority { get; internal set; }
        public bool Passive { get; internal set; }
    }
}
