using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class LangLocalization
    {
        private string id;
        private string name;
        private string localizedName;
        private string langINIFile;
        private Dictionary<string, string> localizationDic;
        public string ID { get { return id; } }
        public string Name { get { return name; } }
        public string LocalizedName { get { return localizedName; } }

        public LangLocalization(string langINIFile)
        {
            localizationDic = new Dictionary<string, string>();
            this.langINIFile = langINIFile;
            ParseINIFile();
        }

        public string this[string index]
        {
            get
            {
                return localizationDic[index];
            }
        }

        private void ParseINIFile()
        {
            using (StreamReader reader = new StreamReader(langINIFile))
            {
                while (reader.Peek() > -1)
                {
                    string line = reader.ReadLine();
                    
                    if (string.IsNullOrEmpty(line) || line.StartsWith(";"))
                        continue;
                    
                    string[] tokens = line.Split('=');
                    string key = tokens[0].Trim();
                    string value = tokens[1].Trim();
                    if (key == "ui_lang_id")
                    {
                        id = value;
                    }
                    else if (key == "ui_lang_name")
                    {
                        name = value;
                    }
                    else if (key == "ui_lang_localized_name")
                    {
                        localizedName = value;
                    }
                    else
                    {
                        localizationDic[key] = value;
                    }
                }
            }
        }

		public bool IsLocalizedStringExisted(string stringID)
		{
            return localizationDic.ContainsKey(stringID);
		}
	}
}
