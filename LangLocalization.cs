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
                    string line = reader.ReadLine().Replace(" ", string.Empty);
                    string[] tokens = line.Split('=');
                    string key = tokens[0];
                    if (key == "ui_lang_id")
                    {
                        id = tokens[1];
                    }
                    else if (key == "ui_lang_name")
                    {
                        name = tokens[1];
                    }
                    else if (key == "ui_lang_localized_name")
                    {
                        localizedName = tokens[1];
                    }
                    else
                    {
                        localizationDic[key] = tokens[1];
                    }
                }
            }
        }
    }
}
