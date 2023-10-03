using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArenaModdingTool.ModdingFiles
{
    [XmlRoot("SPCultures")]
    public class MBBannerlordCultures
    {
        [XmlElement("Culture")]
        public List<MBBannerlordCulture> Cultures { get; set; }
        [XmlIgnore]
        public string FilePath { get; set; }

        public MBBannerlordCultures()
        {
            Cultures = new List<MBBannerlordCulture>();
        }
    }

    public class MBBannerlordCulture
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string name { get; set; }
        [XmlAttribute]
        public string is_main_culture { get; set; }
        [XmlAttribute]
        public string color { get; set; }
        [XmlAttribute]
        public string color2 { get; set; }
        [XmlAttribute]
        public string elite_basic_troop { get; set; }
        [XmlAttribute]
        public string basic_troop { get; set; }
        [XmlAttribute]
        public string melee_militia_troop { get; set; }
        [XmlAttribute]
        public string ranged_militia_troop { get; set; }
        [XmlAttribute]
        public string melee_elite_militia_troop { get; set; }
        [XmlAttribute]
        public string ranged_elite_militia_troop { get; set; }
        [XmlAttribute]
        public string can_have_settlement { get; set; }
        [XmlAttribute]
        public string town_edge_number { get; set; }
        [XmlAttribute]
        public string villager_party_template { get; set; }
        [XmlAttribute]
        public string default_party_template { get; set; }
        [XmlAttribute]
        public string caravan_party_template { get; set; }
        [XmlAttribute]
        public string elite_caravan_party_template { get; set; }
        [XmlAttribute]
        public string militia_party_template { get; set; }
        [XmlAttribute]
        public string rebels_party_template { get; set; }
        [XmlAttribute]
        public string prosperity_bonus { get; set; }
        [XmlAttribute]
        public string encounter_background_mesh { get; set; }
        [XmlAttribute]
        public string default_face_key { get; set; }
        [XmlAttribute]
        public string text { get; set; }
        [XmlAttribute]
        public string tournament_master { get; set; }
        [XmlAttribute]
        public string villager { get; set; }
        [XmlAttribute]
        public string caravan_master { get; set; }
        [XmlAttribute]
        public string armed_trader { get; set; }
        [XmlAttribute]
        public string caravan_guard { get; set; }
        [XmlAttribute]
        public string veteran_caravan_guard { get; set; }
        [XmlAttribute]
        public string duel_preset { get; set; }
        [XmlAttribute]
        public string prison_guard { get; set; }
        [XmlAttribute]
        public string guard { get; set; }
        [XmlAttribute]
        public string steward { get; set; }
        [XmlAttribute]
        public string blacksmith { get; set; }
        [XmlAttribute]
        public string weaponsmith { get; set; }
        [XmlAttribute]
        public string townswoman { get; set; }
        public string townswoman_infant { get; set; }
        [XmlAttribute]
        public string townswoman_child { get; set; }
        [XmlAttribute]
        public string townswoman_teenager { get; set; }
        [XmlAttribute]
        public string townsman { get; set; }
        [XmlAttribute]
        public string townsman_infant { get; set; }
        [XmlAttribute]
        public string townsman_child { get; set; }
        [XmlAttribute]
        public string village_woman { get; set; }
        [XmlAttribute]
        public string villager_male_child { get; set; }
        [XmlAttribute]
        public string villager_male_teenager { get; set; }
        [XmlAttribute]
        public string villager_female_child { get; set; }
        [XmlAttribute]
        public string villager_female_teenager { get; set; }
        [XmlAttribute]
        public string townsman_teenager { get; set; }
        [XmlAttribute]
        public string ransom_broker { get; set; }
        [XmlAttribute]
        public string gangleader_bodyguard { get; set; }
        [XmlAttribute]
        public string merchant_notary { get; set; }
        [XmlAttribute]
        public string artisan_notary { get; set; }
        [XmlAttribute]
        public string preacher_notary { get; set; }
        [XmlAttribute]
        public string rural_notable_notary { get; set; }
        [XmlAttribute]
        public string shop_worker { get; set; }
        [XmlAttribute]
        public string tavernkeeper { get; set; }
        [XmlAttribute]
        public string taverngamehost { get; set; }
        [XmlAttribute]
        public string musician { get; set; }
        [XmlAttribute]
        public string tavern_wench { get; set; }
        [XmlAttribute]
        public string armorer { get; set; }
        [XmlAttribute]
        public string horseMerchant { get; set; }
        [XmlAttribute]
        public string barber { get; set; }
        [XmlAttribute]
        public string merchant { get; set; }
        [XmlAttribute]
        public string beggar { get; set; }
        [XmlAttribute]
        public string female_beggar { get; set; }
        [XmlAttribute]
        public string female_dancer { get; set; }
        [XmlAttribute]
        public string gear_practice_dummy { get; set; }
        [XmlAttribute]
        public string weapon_practice_stage_1 { get; set; }
        [XmlAttribute]
        public string weapon_practice_stage_2 { get; set; }
        [XmlAttribute]
        public string weapon_practice_stage_3 { get; set; }
        [XmlAttribute]
        public string gear_dummy { get; set; }
        [XmlAttribute]
        public string board_game_type { get; set; }

        [XmlArray("male_names")]
        [XmlArrayItem("name")]
        public List<MBCultureName> MaleNames { get; set; }

        [XmlArray("female_names")]
        [XmlArrayItem("name")]
        public List<MBCultureName> FemaleNames { get; set; }

        [XmlArray("clan_names")]
        [XmlArrayItem("name")]
        public List<MBCultureName> ClanNames { get; set; }

        [XmlArray("tournament_team_templates_one_participant")]
        [XmlArrayItem("template")]
        public List<MBCultureTemplateName> tournament_team_templates_one_participant { get; set; }

        [XmlArray("tournament_team_templates_two_participant")]
        [XmlArrayItem("template")]
        public List<MBCultureTemplateName> tournament_team_templates_two_participant { get; set; }

		[XmlArray("tournament_team_templates_three_participant")]
		[XmlArrayItem("template")]
		public List<MBCultureTemplateName> tournament_team_templates_three_participant { get; set; }

		[XmlArray("tournament_team_templates_four_participant")]
        [XmlArrayItem("template")]
        public List<MBCultureTemplateName> tournament_team_templates_four_participant { get; set; }

        public MBBannerlordCulture()
        {
            MaleNames = new List<MBCultureName>();
            FemaleNames = new List<MBCultureName>();
            ClanNames = new List<MBCultureName>();
            tournament_team_templates_one_participant = new List<MBCultureTemplateName>();
            tournament_team_templates_two_participant = new List<MBCultureTemplateName>();
            tournament_team_templates_three_participant = new List<MBCultureTemplateName>();
			tournament_team_templates_four_participant = new List<MBCultureTemplateName>();
        }
    }

    [XmlRoot("name")]
    public class MBCultureName
    {
        [XmlAttribute]
        public string name { get; set; }
    }

    [XmlRoot("template")]
    public class MBCultureTemplateName
    {
        [XmlAttribute]
        public string name { get; set; }
    }
}
