
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SWP
{
    public enum ItemClass
    {
        Weapon,
        Potion
    }

    public enum Quality
    {
        Broken,
        Common,
        Uncommon,
        Rare,
        Epic,
        Legendary
    }

    public enum WeaponType
    {
        Default,
        Dagger,
        Sword,
        LongSword,
        Hammer
    }

    public class Constants
    {
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }
    }
}
