using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class AppSetting
    {
        private string appSettingINI;

        public string Localization { get; set; }

        public AppSetting(string appSettingINI)
        {
            this.appSettingINI = appSettingINI;
            parseAppSettingINI();
        }

        private void parseAppSettingINI()
        {
            using (StreamReader reader = new StreamReader(appSettingINI))
            {
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine().Replace(" ", string.Empty);
                    string[] tokens = line.Split('=');
                    string key = tokens[0];
                    if (key == "Localization")
                    {
                        Localization = tokens[1];
                    }
                }
            }
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(appSettingINI))
            {
                writer.WriteLine(string.Format("Localization={0}", Localization));
            }
        }
    }
}
