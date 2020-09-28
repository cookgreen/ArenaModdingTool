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
    }
}
