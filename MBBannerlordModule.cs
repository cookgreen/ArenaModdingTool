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
        private List<MBCultures> moduleCultures;
        private List<MBHeroes> moduleHeroes;
        private List<MBItems> moduleItems;
        private List<MBNPCCharacters> moduleNPCCharacters;
        private string path;
        public MBBannerlordModule()
        {

        }
        public MBBannerlordModule(string path)
        {
            this.path = path;

            moduleKingdoms = new List<MBKingdoms>();
            moduleCultures = new List<MBCultures>();
            moduleHeroes = new List<MBHeroes>();
            moduleItems = new List<MBItems>();
            moduleNPCCharacters = new List<MBNPCCharacters>();

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
                if (File.Exists(kingdomsXmlPath))
                {
                    xmlLoader = new XmlObjectLoader(kingdomsXmlPath);
                    xmlLoader.Load(out kingdoms);
                    kingdoms.FilePath = kingdomsXmlPath;
                    moduleKingdoms.Add(kingdoms);
                }
            }

            var findedSPCulturesNode = moduleInfo.XmlNodes.Where(o => o.XmlName.id == "SPCultures");
            foreach (var node in findedSPCulturesNode)
            {
                MBCultures cultures;
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
                MBHeroes heroes;
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
                MBItems items;
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
                MBNPCCharacters characters;
                string charactersXmlPath = Path.Combine(path, "ModuleData\\" + node.XmlName.path);
                if (Directory.Exists(charactersXmlPath))
                {
                    DirectoryInfo di = new DirectoryInfo(charactersXmlPath);
                    foreach (var file in di.EnumerateFiles())
                    {
                        if (file.Extension == ".xml")
                        {
                            xmlLoader = new XmlObjectLoader(file.FullName);
                            xmlLoader.Load(out characters);
                            characters.FilePath = file.FullName;
                            moduleNPCCharacters.Add(characters);
                        }
                    }
                }
                else if (File.Exists(charactersXmlPath + ".xml"))
                {
                    charactersXmlPath = charactersXmlPath + ".xml";
                    xmlLoader = new XmlObjectLoader(charactersXmlPath);
                    xmlLoader.Load(out characters);
                    characters.FilePath = charactersXmlPath;
                    moduleNPCCharacters.Add(characters);
                }
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
        public List<MBCultures> ModuleCultures
        {
            get { return moduleCultures; }
        }
        public void CreateNew()
        {
        }
    }
}
