using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArenaModdingTool.ModdingFiles
{
    [XmlRoot("Module")]
    public class MBModule
    {
        [XmlElement]
        public MBSubModuleInfoElement Name { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement Id { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement Version { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement DefaultModule { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement SingleplayerModule { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement MultiplayerModule { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement Official { get; set; }
        [XmlElement]
        public MBSubModuleDepencyModules DependedModules { get; set; }

        [XmlArray("SubModules")]
        [XmlArrayItem("SubModule")]
        public List<MBSubModule> SubModules { get; set; }

        [XmlArray("Xmls")]
        [XmlArrayItem("XmlNode")]
        public List<MBXmlNode> XmlNodes { get; set; }

        public MBModule()
        {
            Name = new MBSubModuleInfoElement();
            Id = new MBSubModuleInfoElement();
            Version = new MBSubModuleInfoElement();
            DefaultModule = new MBSubModuleInfoElement();
            SingleplayerModule = new MBSubModuleInfoElement();
            MultiplayerModule = new MBSubModuleInfoElement();
            Official = new MBSubModuleInfoElement();
            DependedModules = new MBSubModuleDepencyModules();

            SubModules = new List<MBSubModule>();
            XmlNodes = new List<MBXmlNode>();
        }
    }
    public class MBSubModule
    {
        [XmlElement]
        public MBSubModuleInfoElement Name { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement DLLName { get; set; }
        [XmlElement]
        public MBSubModuleInfoElement SubModuleClassType { get; set; }

        [XmlArray("Tags")]
        [XmlArrayItem("Tag")]
        public List<MBModuleTag> Tags { get; set; }

        public MBSubModule()
        {
            Name = new MBSubModuleInfoElement();
            DLLName = new MBSubModuleInfoElement();
            SubModuleClassType = new MBSubModuleInfoElement();
            Tags = new List<MBModuleTag>();
        }
    }

    [XmlRoot("Tag")]
    public class MBModuleTag
    {
        [XmlAttribute]
        public string key { get; set; }
        [XmlAttribute]
        public string value { get; set; }
    }

    [XmlRoot("Placeholder")]
    public class MBSubModuleInfoElement
    {
        [XmlAttribute]
        public string value { get; set; }
    }

    [XmlRoot("DependedModules")]
    public class MBSubModuleDepencyModules
    {
        [XmlElement("DependedModule")]
        public List<MBSubModuleDepencyModule> DependencyModules { get; set; }

        public MBSubModuleDepencyModules()
        {
            DependencyModules = new List<MBSubModuleDepencyModule>();
        }
    }

    public class MBSubModuleDepencyModule
    {
        [XmlAttribute]
        public string Id { get; set; }
    }

    public class MBXmlNode
    {
        [XmlElement]
        public MBXmlNodeName XmlName { get; set; }
        [XmlElement]
        public MBXmlNodeIncludedGameTypes IncludedGameTypes { get; set; }

        public MBXmlNode()
        {
            XmlName = new MBXmlNodeName();
            IncludedGameTypes = new MBXmlNodeIncludedGameTypes();
        }
    }

    public class MBXmlNodeName
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string path { get; set; }
    }

    [XmlRoot("IncludedGameTypes")]
    public class MBXmlNodeIncludedGameTypes
    {
        [XmlElement("GameType")]
        public List<MBSubModuleInfoElement> GameTypes { get; set; }

        public MBXmlNodeIncludedGameTypes()
        {
            GameTypes = new List<MBSubModuleInfoElement>();
        }
    }
}
