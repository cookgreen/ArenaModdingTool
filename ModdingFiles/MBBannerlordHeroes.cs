﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArenaModdingTool.ModdingFiles
{
    [XmlRoot("Heroes")]
    public class MBBannerlordHeroes
    {
        [XmlElement("Hero")]
        public List<MBBannerlordHero> Heroes { get; set; }
        [XmlIgnore]
        public string FilePath { get; set; }

        public MBBannerlordHeroes()
        {
            Heroes = new List<MBBannerlordHero>();
        }
    }

    [XmlRoot("Hero")]
    public class MBBannerlordHero
    {
        [XmlAttribute]
        public string id { get; set; }
        [XmlAttribute]
        public string is_noble { get; set; }
        [XmlAttribute]
        public string father { get; set; }
        [XmlAttribute]
        public string mother { get; set; }
        [XmlAttribute]
        public string alive { get; set; }
        [XmlAttribute]
        public string faction { get; set; }
        [XmlAttribute]
        public string spouse { get; set; }
        [XmlAttribute]
        public string banner_key { get; set; }
        [XmlAttribute]
        public string text { get; set; }
    }
}
