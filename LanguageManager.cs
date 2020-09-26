using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArenaModdingTool
{
    public class LanguageManager
    {
        private List<LangLocalization> languages;

        private static LanguageManager instance;
        public static LanguageManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LanguageManager();
                }
                return instance;
            }
        }

        public string CurrentLocalization { get; set; }

        public List<string> GetLanguageNames()
        {
            return languages.Select(o => o.LocalizedName).ToList();
        }

        public string GetLocalizationString(string local, string stringID)
        {
            var lang = languages.Where(o => o.LocalizedName == local).FirstOrDefault();
            return lang[stringID];
        }

        public void Init()
        {
            initlization();
        }

        public LanguageManager()
        {
            languages = new List<LangLocalization>();
        }

        private void initlization()
        {
            string langFullDir = Environment.CurrentDirectory + "//languages//";
            DirectoryInfo di = new DirectoryInfo(langFullDir);
            foreach(var file in di.EnumerateFiles())
            {
                if (file.Name.StartsWith("Lang_"))
                {
                    LangLocalization langLocalization = new LangLocalization(file.FullName);
                    languages.Add(langLocalization);
                }
            }
        }
    }
}
