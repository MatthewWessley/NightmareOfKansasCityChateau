using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChateauLibrary
{
    public class Villian : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }
        public string Description { get; set; }
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = value > 0 && value <= MaxDamage ? value : MaxDamage / 2;
            }
        }
        

        public Villian(string name, int life, int maxLife, int hitBonus, int block, int minDamage, int maxDamage, string description)
            : base(name, life, maxLife, block, hitBonus)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = Description;
        }

        public override string ToString()
        {
            return string.Format($"**{Name}**\nLife: {Life} of {MaxLife}\nDamage: {MinDamage} to {MaxDamage}\nBlock: {Block}\n{Description}");
        }
        

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);
        }
    }
}
