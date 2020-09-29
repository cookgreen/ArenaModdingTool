using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArenaModdingTool.ModdingFiles
{
    [XmlRoot("NPCCharacters")]
    public class MBNPCCharacters
    {
        [XmlElement("NPCCharacter")]
        public List<MBNPCCharacter> NPCCharacters { get; set; }
        public string FilePath { get; set; }
    }

    [XmlRoot("NPCCharacter")]
    public class MBNPCCharacter
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string default_group { get; set; }
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string level { get; set; }
        [XmlAttribute]
        public string occupation { get; set; }
        [XmlAttribute]
        public string culture { get; set; }

        [XmlElement("face")]
        public MBNPCCharacterFace Face { get; set; }

        [XmlArray("skills")]
        [XmlArrayItem("skill")]
        public List<MBNPCCharacterSkill> Skills { get; set; }

        [XmlElement("equipmentSet")]
        public List<MBNPCCharacterEquipmentSet> EquipmentSets { get; set; }

        [XmlArray("upgrade_targets")]
        [XmlArrayItem("upgrade_target")]
        public List<MBNPCCharacterUpgradeTarget> UpgradeTargets { get; set; }
    }

    [XmlRoot("face")]
    public class MBNPCCharacterFace
    {
        [XmlElement]
        public MBNPCCharacterBody BodyProperties { get; set; }
        [XmlElement]
        public MBNPCCharacterBody BodyPropertiesMax { get; set; }
    }

    public class MBNPCCharacterBody
    {
        [XmlAttribute]
        public string version { get; set; }
        [XmlAttribute]
        public string age { get; set; }
        [XmlAttribute]
        public string weight { get; set; }
        [XmlAttribute]
        public string build { get; set; }
        [XmlAttribute]
        public string key { get; set; }
    }

    [XmlRoot("skill")]
    public class MBNPCCharacterSkill
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string value { get; set; }
    }

    [XmlRoot("equipmentSet")]
    public class MBNPCCharacterEquipmentSet
    {
        [XmlElement]
        public List<MBNPCCharacterEquipment> Equipments { get; set; }
    }

    [XmlRoot("equipment")]
    public class MBNPCCharacterEquipment
    {
        [XmlAttribute]
        public string slot { get; set; }
        [XmlAttribute]
        public string id { get; set; }
    }

    [XmlRoot("upgrade_target")]
    public class MBNPCCharacterUpgradeTarget
    {
        [XmlAttribute]
        public string id { get; set; }
    }
}
