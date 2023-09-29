using ArenaModdingTool.ModdingFiles;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XmlLoader;

namespace ArenaModdingTool
{
    public class MBBannerlordModManager
    {
        private static MBBannerlordModManager instance;
        public static MBBannerlordModManager Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new MBBannerlordModManager();
                }
                return instance; 
            }
        }
        private string bannerlordExePath;
        public string BannerlordExePath
        {
            get { return bannerlordExePath; }
        }
        private List<MBBannerlordMod> officalMods;
        public List<MBBannerlordMod> OfficialMods
        {
            get { return officalMods; }
        }
        public MBBannerlordModManager()
        {
            officalMods = new List<MBBannerlordMod>();
        }

        public void Init()
        {
            RegistryKey key = Registry.LocalMachine;
            RegistryKey keySteam = key.OpenSubKey("software\\wow6432Node\\Valve\\Steam", true);
            if (keySteam != null)
            {
                string steamPath = keySteam.GetValue("InstallPath").ToString();
                string bannerlordPath = Path.Combine(steamPath, "steamapps\\common\\Mount & Blade II Bannerlord\\bin\\Win64_Shipping_Client\\TaleWorlds.MountAndBlade.Launcher.exe");
                if (File.Exists(bannerlordPath))
                {
                    bannerlordExePath = bannerlordPath;

                    string bannerlordModulePath = Path.Combine(steamPath, "steamapps\\common\\Mount & Blade II Bannerlord\\Modules");
                    DirectoryInfo di = new DirectoryInfo(bannerlordModulePath);
                    foreach (var dii in di.EnumerateDirectories())
                    {
                        if (dii.EnumerateFiles().Where(o => o.Name == "SubModule.xml").Count() == 1)
                        {
                            ModdingFiles.MBBannerlordModule module;
                            var moduleFile = dii.EnumerateFiles().Where(o => o.Name == "SubModule.xml").FirstOrDefault();
                            XmlObjectLoader xmlObjectLoader = new XmlObjectLoader(moduleFile.FullName);
                            xmlObjectLoader.Load(out module);
                            if (module.Official != null && module.Official.value == "true")
                            {
                                MBBannerlordMod officalModule = new MBBannerlordMod(dii.FullName);
                                OfficialMods.Add(officalModule);
                            }
                        }
                    }
                }
            }
        }
    }
}
