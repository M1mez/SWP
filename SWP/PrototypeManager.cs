

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
        public Item Clone(ItemClass itemClass, string itemType)
        {
            //var itemClassStr = "SWP." + itemClass;
            var item = GetXmlItem(itemClass.ToString(), itemType);

            if (item == null)
            {
                Console.WriteLine("item is null " + itemType);
                Console.Read();
            }


            return item;
        }


        private Item GetXmlItem(string type, string itemType)
        {
            var path = $"O:/GIT/SWP/SWP/XML/{type}.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Item>));
            List<Item> deserializedList;

            using (FileStream stream = File.OpenRead(path))
            {
                deserializedList = (List<Item>)serializer.Deserialize(stream);
            }
            
            return deserializedList.Find(x => x.ItemType == itemType);
        }
    }
}
