using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlLoader;

namespace ArenaModdingTool
{
    public class ModdingProject
    {
        private string path;
        private XmlObjectLoader xmlObjectLoader;
        private MBBannerlordMod bannerlordModule;

        public string Name { get; set; }
        public string ModuleName { get; set; }
        public string Location { get; set; }
        public List<string> IncludedFiles { get; set; }
        public MBBannerlordMod BannerlordModule { get { return bannerlordModule; } }
        
        public ModdingProject()
        {
            bannerlordModule = new MBBannerlordMod();
        }

        public ModdingProject(string path)
        {
            this.path = path;
            DirectoryInfo di = new DirectoryInfo(path);
            Name = di.Name;
            bannerlordModule = new MBBannerlordMod(path);
            ModuleName = bannerlordModule.ModuleInfo.Name.value;
            Location = path;
        }

        public void CreateNew()
        {
            bannerlordModule.CreateNew();
        }

        public bool CopyFileIntoCurrentModuleAndLoad(string type, string fileName, out string errorMessage)
        {
            errorMessage = string.Empty;
            try
            {
                string destFileFullPath = Path.Combine(BannerlordModule.ModuleDataPath, fileName + ".xml");
                xmlObjectLoader = new XmlObjectLoader(destFileFullPath);

                if (type == "Kingdom")
                {
                    MBBannerlordKingdoms mbKingdoms = new MBBannerlordKingdoms();
                    xmlObjectLoader.Save(mbKingdoms);
                    mbKingdoms.FilePath = destFileFullPath;
                    bannerlordModule.ModuleKingdoms.Add(mbKingdoms);
                }
                else if (type == "NPCCharacters")
                {
                    MBBannerlordNPCCharacters mbNPCCharacters = new MBBannerlordNPCCharacters();
                    xmlObjectLoader.Save(mbNPCCharacters);
                    mbNPCCharacters.FilePath = destFileFullPath;
                    bannerlordModule.ModuleNPCCharacters.Add(mbNPCCharacters);
                }
                else if (type == "Items")
                {
                    MBBannerlordItems mbItems = new MBBannerlordItems();
                    xmlObjectLoader.Save(mbItems);
                    mbItems.FilePath = destFileFullPath;
                    bannerlordModule.ModuleItems.Add(mbItems);
                }
                else if (type == "Heroes")
                {
                    MBBannerlordHeroes mbHeroes = new MBBannerlordHeroes();
                    xmlObjectLoader.Save(mbHeroes);
                    mbHeroes.FilePath = destFileFullPath;
                    bannerlordModule.ModuleHeroes.Add(mbHeroes);
                }
                else if (type == "Cultures")
                {
                    MBBannerlordCultures mbCultures = new MBBannerlordCultures();
                    xmlObjectLoader.Save(mbCultures);
                    mbCultures.FilePath = destFileFullPath;
                    bannerlordModule.ModuleCultures.Add(mbCultures);
                }
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }

        public void SaveModuleInfo()
        {
            XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(Path.Combine(BannerlordModule.ModulePath, "SubModule.xml"));
            xmlObjectLoader.Save(bannerlordModule.ModuleInfo);
        }
    }
}
