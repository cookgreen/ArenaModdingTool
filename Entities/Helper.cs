using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public static class Helper
    {
        public static string LOC(string stringID)
        {
            return LanguageManager.Instance.GetLocalizationString(LanguageManager.Instance.CurrentLocalization, stringID);
        }

        public static string ToHexString(this Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + color.A.ToString("X2");
        }

        public static string ToHexStringPrefix(this Color color, string prefix)
        {
            return prefix + color.R.ToString("x2") + color.G.ToString("x2") + color.B.ToString("X2") + color.A.ToString("x2");
        }
    }
}
