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
    public class MBBannerlordMod
    {
        private MBBannerlordModule moduleInfo;
        private List<MBBannerlordKingdoms> moduleKingdoms;
        private List<MBBannerlordCultures> moduleCultures;
        private List<MBBannerlordHeroes> moduleHeroes;
        private List<MBBannerlordItems> moduleItems;
        private List<MBBannerlordNPCCharacters> moduleNPCCharacters;
        private string path;

        public string ModuleDataPath
        {
            get { return Path.Combine(path, "ModuleData"); }
		}

		public MBBannerlordModule ModuleInfo
		{
			get { return moduleInfo; }
		}

		public List<MBBannerlordItems> ModuleItems
		{
			get { return moduleItems; }
		}

		public List<MBBannerlordKingdoms> ModuleKingdoms
		{
			get { return moduleKingdoms; }
		}

		public List<MBBannerlordCultures> ModuleCultures
		{
			get { return moduleCultures; }
		}

		public List<MBBannerlordHeroes> ModuleHeroes
		{
			get { return moduleHeroes; }
		}

		public List<MBBannerlordNPCCharacters> ModuleNPCCharacters
		{
			get { return moduleNPCCharacters; }
		}

		public MBBannerlordMod()
        {

        }

        public MBBannerlordMod(string path)
        {
            this.path = path;

            moduleKingdoms = new List<MBBannerlordKingdoms>();
            moduleCultures = new List<MBBannerlordCultures>();
            moduleHeroes = new List<MBBannerlordHeroes>();
            moduleItems = new List<MBBannerlordItems>();
            moduleNPCCharacters = new List<MBBannerlordNPCCharacters>();

            loadMod();
        }

        private void loadMod()
        {
            XmlObjectLoader xmlLoader = new XmlObjectLoader(Path.Combine(path, "SubModule.xml"));
            xmlLoader.Load(out moduleInfo);

            var findedSPKingdomsNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "Kingdoms");
            foreach (var node in findedSPKingdomsNode)
            {
                string kingdomsXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path) + ".xml";
                if (File.Exists(kingdomsXmlPath))
                {
                    LoadKingdoms(kingdomsXmlPath);
                }
            }

            var findedSPCulturesNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "SPCultures");
            foreach (var node in findedSPCulturesNode)
            {
                MBBannerlordCultures cultures;
                string culturesXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path) + ".xml";
                if (File.Exists(culturesXmlPath))
                {
                    xmlLoader = new XmlObjectLoader(Path.Combine(culturesXmlPath));
                    xmlLoader.Load(out cultures);
                    cultures.FilePath = culturesXmlPath;
                    moduleCultures.Add(cultures);
                }
            }

            var findedHeroesNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "Heroes");
            foreach (var node in findedHeroesNode)
            {
                MBBannerlordHeroes heroes;
                string heroesXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path) + ".xml";
                if (File.Exists(heroesXmlPath))
                {
                    xmlLoader = new XmlObjectLoader(heroesXmlPath);
                    xmlLoader.Load(out heroes);
                    heroes.FilePath = heroesXmlPath;
                    moduleHeroes.Add(heroes);
                }
            }

            var findedItemNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "Items");
            foreach (var node in findedItemNode)
            {
                MBBannerlordItems items;
                string itemsXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path);
                if (Directory.Exists(itemsXmlPath))
                {
                    DirectoryInfo di = new DirectoryInfo(itemsXmlPath);
                    foreach (var file in di.EnumerateFiles())
                    {
                        if (file.Extension == ".xml")
                        {
                            xmlLoader = new XmlObjectLoader(file.FullName);
                            xmlLoader.Load(out items);
                            items.FilePath = file.FullName;
                            moduleItems.Add(items);
                        }
                    }
                }
                else if (File.Exists(itemsXmlPath + ".xml"))
                {
                    itemsXmlPath = itemsXmlPath + ".xml";
                    xmlLoader = new XmlObjectLoader(itemsXmlPath);
                    xmlLoader.Load(out items);
                    items.FilePath = itemsXmlPath;
                    moduleItems.Add(items);
                }
            }

            var findedNPCCharacterNodes = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "NPCCharacters");
            foreach (var node in findedNPCCharacterNodes)
            {
                string charactersXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path);
                if (Directory.Exists(charactersXmlPath))
                {
                    DirectoryInfo di = new DirectoryInfo(charactersXmlPath);
                    foreach (var file in di.EnumerateFiles())
                    {
                        if (file.Extension == ".xml")
                        {
                            LoadNPCCharacters(file.FullName);
                        }
                    }
                }
                else if (File.Exists(charactersXmlPath + ".xml"))
                {
                    charactersXmlPath = charactersXmlPath + ".xml";
                    LoadNPCCharacters(charactersXmlPath);
                }
            }
        }

        public void LoadKingdoms(string destFileFullPath)
        {
            MBBannerlordKingdoms kingdoms;
            var xmlLoader = new XmlObjectLoader(destFileFullPath);
            xmlLoader.Load(out kingdoms);
            kingdoms.FilePath = destFileFullPath;
            moduleKingdoms.Add(kingdoms);
        }

        public void LoadNPCCharacters(string destFileFullPath)
        {
            MBBannerlordNPCCharacters characters;
            var xmlLoader = new XmlObjectLoader(destFileFullPath);
            xmlLoader.Load(out characters);
            characters.FilePath = destFileFullPath;
            moduleNPCCharacters.Add(characters);
        }

        public string ModulePath { get { return path; } }

        public bool HasModuleCharacterFile
        {
            get { return moduleNPCCharacters.Count > 0; }
        }

        public bool HasModuleKingdomFile 
        {
            get { return moduleKingdoms.Count > 0; }
        }

        public void CreateNew()
        {
        }
    }
}
