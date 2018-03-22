using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP
{
    [Serializable]
    public class Weapon : Item
    {
        public string Name;
        public string WType;
        public string WQuality;
        public int Durability;
        public int Value;
        public int Attack;
        public int Speed;
        

        public void WeaponInformationPlease()
        {
            Console.WriteLine(
                "name: {0}\n" +
                "WeaponType: {1}\n" +
                "WeaponQuality: {2}\n" +
                "durability: {3}\n" +
                "value: {4}\n" +
                "attack: {5}\n" +
                "speed: {6}\n" +
                "itemType: {7}",
                Name, WType,WQuality, Durability, Value, Attack, Speed, ItemType);
        }
        
    }
}
