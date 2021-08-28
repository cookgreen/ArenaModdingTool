using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArenaModdingTool.ModdingFiles
{
    [XmlRoot("Items")]
    public class MBItems
    {
        [XmlElement("Item")]
        public List<MBItem> Items { get; set; }
        [XmlElement("CraftedItem")]
        public List<MBCraftedItems> CraftedItems { get; set; }
        [XmlIgnore]
        public string FilePath { get; set; }

        public MBItems()
        {
            Items = new List<MBItem>();
            CraftedItems = new List<MBCraftedItems>();
        }
    }

    [XmlRoot("Item")]
    public class MBItem
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string is_merchandise { get; set; }
        [XmlAttribute]
        public string body_name { get; set; }
        [XmlAttribute]
        public string recalculate_body { get; set; }
        [XmlAttribute]
        public string mesh { get; set; }
        [XmlAttribute]
        public string prefab { get; set; }
        [XmlAttribute]
        public string culture { get; set; }
        [XmlAttribute]
        public string value { get; set; }
        [XmlAttribute]
        public string weight { get; set; }
        [XmlAttribute]
        public string difficulty { get; set; }
        [XmlAttribute]
        public string Type { get; set; }
        [XmlAttribute]
        public string AmmoOffset { get; set; }
        [XmlAttribute]
        public string subtype { get; set; }
        [XmlAttribute]
        public string item_holsters { get; set; }
        [XmlAttribute]
        public string holster_position_shift { get; set; }
        [XmlAttribute]
        public string appearance { get; set; }

        [XmlElement]
        public MBItemComponent ItemComponent { get; set; }
    }

    [XmlRoot("ItemComponent")]
    public class MBItemComponent
    {
        [XmlElement]
        public MBItemArmour Armour { get; set; }

        [XmlElement]
        public MBItemWeapon Weapon { get; set; }
    }

    public class MBItemArmour
    {
        [XmlAttribute]
        public string head_armor { get; set; }
        [XmlAttribute]
        public string has_gender_variations { get; set; }
        [XmlAttribute]
        public string hair_cover_type { get; set; }
        [XmlAttribute]
        public string beard_cover_type { get; set; }
        [XmlAttribute]
        public string modifier_group { get; set; }
        [XmlAttribute]
        public string material_type { get; set; }
        [XmlAttribute]
        public string leg_armor { get; set; }
        [XmlAttribute]
        public string covers_legs { get; set; }
        [XmlAttribute]
        public string arm_armor { get; set; }
        [XmlAttribute]
        public string covers_hands { get; set; }
        [XmlAttribute]
        public string body_armor { get; set; }
        [XmlAttribute]
        public string covers_body { get; set; }
    }

    public class MBItemWeapon
    {
        [XmlAttribute]
        public string weapon_class { get; set; }
        [XmlAttribute]
        public string weapon_balance { get; set; }
        [XmlAttribute]
        public string thrust_speed { get; set; }
        [XmlAttribute]
        public string speed_rating { get; set; }
        [XmlAttribute]
        public string missile_speed { get; set; }
        [XmlAttribute]
        public string weapon_length { get; set; }
        [XmlAttribute]
        public string swing_damage { get; set; }
        [XmlAttribute]
        public string swing_damage_type { get; set; }
        [XmlAttribute]
        public string item_usage { get; set; }
        [XmlAttribute]
        public string physics_material { get; set; }
    }

    public class MBCraftedItems
    {
        public string id { get; set; }
        public string name { get; set; }
        public string crafting_template { get; set; }
        public string is_merchandise { get; set; }
        public string culture { get; set; }

        [XmlArray("Pieces")]
        [XmlArrayItem("Piece")]
        public List<MBCraftedItemPiece> Pieces { get; set; }

        public MBCraftedItems()
        {
            Pieces = new List<MBCraftedItemPiece>();
        }
    }

    public class MBCraftedItemPiece
    {
        public string id { get; set; }
        public string Type { get; set; }
        public string scale_factor { get; set; }
    }
}
