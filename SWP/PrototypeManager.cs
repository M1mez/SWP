

using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace SWP
{

    class PrototypeManager
    {
        private PrototypeManager()
        {
            readItems();
        }
        private static PrototypeManager _pm = null;
        public static PrototypeManager GetInstance() => _pm ?? (_pm = new PrototypeManager());
        private Dictionary<string, Item> _itemList = new Dictionary<string, Item>();
        public Item Clone(string ItemType) => Constants.DeepClone(_itemList[ItemType]);

        private void readItems()
        {
            var path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName + "/Items.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
            List<Item> deserializedList;

            using (FileStream stream = File.OpenRead(path))
            {
                deserializedList = (List<Item>)serializer.Deserialize(stream);
            }

            deserializedList.ForEach(el =>
            {
                if (!_itemList.ContainsKey(el.ItemType))
                {
                    _itemList.Add(el.ItemType, el);
                }
                else throw new Exception($"Item {el.ItemType} already exists in List!");
            });
        }
    }
}
