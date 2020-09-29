using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArenaModdingTool
{
    [XmlRoot("RecentOperations")]
    public class RecentOperations
    {
        [XmlElement]
        public List<RecentOperation> RecentOperationList { get; set; }
    }

    [XmlRoot("RecentOperation")]
    public class RecentOperation
    {
        [XmlAttribute]
        public string Type { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
