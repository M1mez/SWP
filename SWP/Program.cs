using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SWP
{
    class Program
    {
        static void Main(string[] args)
        {
            var pm = new PrototypeManager();

            var dagger = (Weapon) pm.Clone(ItemClass.Weapon, WeaponType.Dagger.ToString());
            dagger.WeaponInformationPlease();

            Console.WriteLine();

            var sword = (Weapon) pm.Clone(ItemClass.Weapon, WeaponType.Sword.ToString());
            sword.WeaponInformationPlease();

            Console.Read();
        }
    }
}