using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChateauLibrary
{
    public class Weapons
    {

        private int _minDamage;     
                

        public string Name { get; set; }

        public int BonusHitChance { get; set; }

        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value < MaxDamage ? value : MaxDamage / 2;
            }
        }


        public Weapons(string name, int minDamage, int maxDamage, int bonusHitChance)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;
        }


        public override string ToString()
        {
            return string.Format(
                $"{Name}\n" +
                $"{MinDamage} to " +
                $"{MaxDamage}\n" +
                $"Bonus Hit: +{BonusHitChance}");
        }
        

    }
}
