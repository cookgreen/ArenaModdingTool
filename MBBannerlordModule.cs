using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using XmlLoader;

namespace ArenaModdingTool
{
    public class MBBannerlordModule
    {
        private MBModule moduleInfo;
        private List<MBKingdoms> moduleKingdoms;
        private string path;
        public MBBannerlordModule()
        {

        }
        public MBBannerlordModule(string path)
        {
            this.path = path;

            moduleKingdoms = new List<MBKingdoms>();


            loadMod();
        }

        private void loadMod()
        {
            XmlObjectLoader xmlLoader = new XmlObjectLoader(Path.Combine(path, "SubModule.xml"));
            xmlLoader.Load<MBModule>(out moduleInfo);

            var findedSPKingdomsNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "Kingdoms");
            foreach (var node in findedSPKingdomsNode)
            {
                MBKingdoms kingdoms;
                string kingdomsXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path) + ".xml";
                xmlLoader = new XmlObjectLoader(Path.Combine(path, "ModuleData\\" + node.XmlName.path) + ".xml");
                xmlLoader.Load<MBKingdoms>(out kingdoms);
                kingdoms.FilePath = kingdomsXmlPath;
                moduleKingdoms.Add(kingdoms);
            }
        }

        public MBModule ModuleInfo
        {
            get { return moduleInfo; }
        }
        public List<MBKingdoms> ModuleKingdoms
        {
            get { return moduleKingdoms; }
        }
        public void CreateNew()
        {
        }
    }
}
