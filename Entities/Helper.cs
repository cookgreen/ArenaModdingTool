using ArenaModdingTool.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool
{
    public static class Helper
    {
        public static string LOC(string stringID)
        {
			if (LanguageManager.Instance.CheckLocalizedStringExisted(LanguageManager.Instance.CurrentLocalization, stringID))
			{
				return LanguageManager.Instance.GetLocalizationString(LanguageManager.Instance.CurrentLocalization, stringID);
			}
			else
			{
				DebugMessageManager.Instance.AppendDebugMessage(string.Format("String with ID '{0}' not found", stringID), DebugMessageLevel.Error);
				return null;
			}
        }

        public static string ToHexString(this Color color)
        {
            return color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2") + color.A.ToString("X2");
        }

        public static string ToHexStringPrefix(this Color color, string prefix)
        {
            return prefix + color.R.ToString("x2") + color.G.ToString("x2") + color.B.ToString("X2") + color.A.ToString("x2");
        }

		public static string RenameSnakeCase(string str)
		{
			var builder = new StringBuilder();
			var name = str;
			var previousUpper = false;

			for (var i = 0; i < name.Length; i++)
			{
				var c = name[i];
				if (char.IsUpper(c))
				{
					if (i > 0 && !previousUpper)
					{
						builder.Append("_");
					}
					builder.Append(char.ToLowerInvariant(c));
					previousUpper = true;
				}
				else
				{
					builder.Append(c);
					previousUpper = false;
				}
			}
			return builder.ToString();
		}

		public static void ShowMessageInfo(string info, string title)
		{
			MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public static void ShowMessageError(string error, string title)
		{
			MessageBox.Show(error, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static DialogResult ShowMessageQuestion(string notice, string title)
		{
			return MessageBox.Show(notice, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}
