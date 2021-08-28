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

        public MBNPCCharacters()
        {
            NPCCharacters = new List<MBNPCCharacter>();
        }
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
        public bool is_companion { get; set; }
        public bool is_female { get; set; }
        public bool is_hero { get; set; }
        public bool is_mecenary { get; set; }
        public string voice { get; set; }
        public string civilian_template { get; set; }

        [XmlElement("face")]
        public MBNPCCharacterFace Face { get; set; }

        [XmlArray("skills")]
        [XmlArrayItem("skill")]
        public List<MBNPCCharacterSkill> Skills { get; set; }

        [XmlElement("equipmentSet")]
        public List<MBNPCCharacterEquipmentSet> EquipmentSets { get; set; }

        [XmlElement("equipment")]
        public List<MBNPCCharacterEquipment> OtherEquipments { get; set; }

        [XmlArray("upgrade_targets")]
        [XmlArrayItem("upgrade_target")]
        public List<MBNPCCharacterUpgradeTarget> UpgradeTargets { get; set; }

        public MBNPCCharacter()
        {
            Skills = new List<MBNPCCharacterSkill>();
            EquipmentSets = new List<MBNPCCharacterEquipmentSet>();
            UpgradeTargets = new List<MBNPCCharacterUpgradeTarget>();
            OtherEquipments = new List<MBNPCCharacterEquipment>();
        }
    }

    [XmlRoot("face")]
    public class MBNPCCharacterFace
    {
        [XmlElement]
        public MBSubModuleInfoElement face_key_template { get; set; }
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
        [XmlAttribute("civilian")]
        public bool IsCivilian { get; set; }

        [XmlElement("equipment")]
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
