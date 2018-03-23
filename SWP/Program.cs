using System;
using System.Collections.Generic;
using System.IO;
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
            var pm = PrototypeManager.GetInstance();

            var dagger = (Weapon) pm.Clone(WeaponType.Dagger.ToString());
            dagger.WeaponInformationPlease();

            Console.WriteLine();

            var sword = (Weapon) pm.Clone(WeaponType.Sword.ToString());
            sword.WeaponInformationPlease();

            Console.WriteLine();

            var hammer = (Weapon) pm.Clone(WeaponType.Hammer.ToString());
            hammer.WeaponInformationPlease();

            Console.WriteLine();

            ((Weapon) hammer.Clone()).WeaponInformationPlease();

            Console.Read();
        }
    }
}