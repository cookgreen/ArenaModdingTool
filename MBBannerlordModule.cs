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
        private MBKingdoms kingdoms;
        private string path;
        public MBBannerlordModule()
        {

        }
        public MBBannerlordModule(string path)
        {
            this.path = path;
            loadMod();
        }

        private void loadMod()
        {
            XmlObjectLoader xmlLoader = new XmlObjectLoader(Path.Combine(path, "SubModule.xml"));
            xmlLoader.Load<MBModule>(out moduleInfo);

            var findedSPKingdomsNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "Kingdoms");
            if (findedSPKingdomsNode.Count() == 1)
            {
                xmlLoader = new XmlObjectLoader(Path.Combine(path, "ModuleData\\" + findedSPKingdomsNode.First().XmlName.path) + ".xml");
                xmlLoader.Load<MBKingdoms>(out kingdoms);
            }
        }

        public MBModule ModuleInfo
        {
            get { return moduleInfo; }
        }
        public MBKingdoms Kingdoms
        {
            get { return kingdoms; }
        }
        public void CreateNew()
        {
        }
    }
}
