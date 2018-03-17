using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP
{
    [Serializable]
    public class WeaponMelee : Weapon
    {
        public WeaponMelee(){}
        public WeaponMelee(string name, WeaponType wType, Quality wQuality, int durability, int value, int attack, int speed) : base(name, wType, wQuality, durability, value, attack, speed)
        {
        }
    }
}
