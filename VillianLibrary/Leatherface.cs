using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChateauLibrary;


namespace VillianLibrary
{
    public class Leatherface : Villian
    {

        public Weapons EquippedWeapon { get; set; }

        public Leatherface(string name, int life, int maxLife, int hitBonus, int block, int minDamage, int maxDamage, string description, Weapons equippedWeapon)
            : base(name, life, maxLife, hitBonus, block, minDamage, maxDamage, description)
        {
            EquippedWeapon = equippedWeapon;
        }

        public override string ToString()
        {
            return string.Format($"{(base.ToString())}Weapon of choice: {EquippedWeapon}");
        }

    }
}