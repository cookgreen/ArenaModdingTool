using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class Helper
    {
        public static string LOC(string stringID)
        {
            return LanguageManager.Instance.GetLocalizationString(LanguageManager.Instance.CurrentLocalization, stringID);
        }
    }
}
