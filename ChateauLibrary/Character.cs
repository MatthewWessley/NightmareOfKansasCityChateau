using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChateauLibrary
{
    public abstract class Character
    {
        private int _life;

        public string Name { get; set; }
        public int MaxLife { get; set; }
        public int Block { get; set; }
        public int HitBonus { get; set; }
        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }
        }

        public Character(string name, int life, int maxLife, int block, int hitBonus)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            Block = block;
            HitBonus = hitBonus;
        }
        

        public virtual int CalcBlock()
        {
            return Block;
        }
      

        public virtual int CalcHitBonus()
        {
            return HitBonus;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

    }
}
