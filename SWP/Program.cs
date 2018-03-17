using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP
{
    class Program
    {
        static void Main(string[] args)
        {
            var defaultAxe = new WeaponMelee();

            var firstAxe = new WeaponMelee("firstAxe", WeaponType.Axe, Quality.Rare, 80, 15, 7, 6);

            var secondAxe = firstAxe.Clone();
            secondAxe.Name = "secondAxe";

            var thirdAxe = firstAxe.Clone("thirdAxe", WeaponType.Axe, Quality.Legendary, 90, 30, 11, 7);

            var fourthAxe = thirdAxe.Clone();
            fourthAxe.Name = "fourthAxe";

            defaultAxe.WeaponInformationPlease();
            firstAxe.WeaponInformationPlease();
            secondAxe.WeaponInformationPlease();
            thirdAxe.WeaponInformationPlease();
            fourthAxe.WeaponInformationPlease();

            Console.Read();
        }
    }
}