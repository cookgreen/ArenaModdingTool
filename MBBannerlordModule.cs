using ArenaModdingTool.ModdingFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class MBBannerlordModule
    {
        private MBModule moduleInfo;
        private MBSPKingdoms kingdoms;
        public MBModule ModuleInfo
        {
            get { return moduleInfo; }
        }
        public MBSPKingdoms Kingdoms
        {
            get { return kingdoms; }
        }
        public void CreateNew()
        {
        }
    }
}
