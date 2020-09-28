using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaModdingTool
{
    public class AMProject
    {
        private MBBannerlordModule bannerlordModule;
        public string Name { get; set; }
        public string ModuleName { get; set; }
        public string Location { get; set; }
        public List<string> IncludedFiles { get; set; }
        public MBBannerlordModule BannerlordModule { get { return bannerlordModule; } }
        public AMProject()
        {
            bannerlordModule = new MBBannerlordModule();
        }

        public void CreateNew()
        {
            bannerlordModule.CreateNew();
        }
    }
}
