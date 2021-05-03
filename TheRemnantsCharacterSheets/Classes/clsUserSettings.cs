using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRemnantsCharacterSheets.Classes
{
    public static class clsUserSettings
    {
        private static LanguageChoice mLanguageChoice;
        public enum LanguageChoice { English, Polish };

        public static LanguageChoice languageChoice
        {
            get
            {
                return mLanguageChoice;
            }
            set
            {
                mLanguageChoice = value;
            }
        }
    }
}
