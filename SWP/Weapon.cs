using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP
{
    [Serializable]
    public abstract class Weapon
    {
        public string Name;
        public WeaponType WType;
        public Quality WQuality;
        public int Durability;
        public int Value;
        public int Attack;
        public int Speed;

        protected Weapon() : this("Default", WeaponType.Default, Quality.Common, 100, 0, 0, 0){}
        protected Weapon(string name, WeaponType wType, Quality wQuality, int durability, int value, int attack, int speed)
        {
            Name = name;
            WType = wType;
            WQuality = wQuality;
            Durability = durability;
            Value = value;
            Attack = attack;
            Speed = speed;
        }

        public void WeaponInformationPlease()
        {
            Console.WriteLine(
                "name: {0}\n" +
                "WeaponType: {1}\n" +
                "WeaponQuality: {2}\n" +
                "durability: {3}\n" +
                "value: {4}\n" +
                "attack: {5}\n" +
                "speed: {6}\n",
                Name, Enum.GetName(typeof(WeaponType), WType), Enum.GetName(typeof(Quality), WQuality), Durability, Value, Attack, Speed);
        }

        public Weapon Clone() => Clone(Name, WType, WQuality, Durability, Value, Attack, Speed);
        public Weapon Clone(string name, WeaponType wType, Quality wQuality, int durability, int value, int attack, int speed)
        {
            var clone = Functions.DeepClone(this);
            clone.Name = name;
            clone.WType = wType;
            clone.WQuality = wQuality;
            clone.Durability = durability;
            clone.Value = value;
            clone.Attack = attack;
            clone.Speed = speed;

            return clone;
        }
    }
}
