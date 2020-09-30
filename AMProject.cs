using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlLoader;

namespace ArenaModdingTool
{
    public class AMProject
    {
        private MBBannerlordModule bannerlordModule;
        private string path;

        public string Name { get; set; }
        public string ModuleName { get; set; }
        public string Location { get; set; }
        public List<string> IncludedFiles { get; set; }
        public MBBannerlordModule BannerlordModule { get { return bannerlordModule; } }
        public AMProject()
        {
            bannerlordModule = new MBBannerlordModule();
        }

        public AMProject(string path)
        {
            this.path = path;
            DirectoryInfo di = new DirectoryInfo(path);
            Name = di.Name;
            bannerlordModule = new MBBannerlordModule(path);
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
                TemplateFileManager.Instance.FindFileByTypeAndCopy(type, destFileFullPath);
                if (File.Exists(destFileFullPath))
                {
                    if (type == "Kingdom")
                    {
                        BannerlordModule.LoadKingdoms(destFileFullPath);
                    }
                    else if (type == "NPCCharacter")
                    {
                        BannerlordModule.LoadNPCCharacters(destFileFullPath);
                    }
                    return true;
                }
                else
                {
                    errorMessage = Helper.LOC("str_file_copy_error");
                    return false;
                }
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
