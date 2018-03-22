using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SWP
{
    [XmlInclude(typeof(Weapon))]
    [Serializable]
    public abstract class Item
    {
        public string ItemType;
    }
}
