using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChateauLibrary
{
    public class Players : Character
    {

        public SelectPlayer PlayerChoice { get; set; }
        public Weapons EquippedWeapon { get; set; }


        public Players(string name, int life, int maxLife, int block, int hitBonus, Weapons equippedWeapon, SelectPlayer playerChoice)
            : base(name, life, maxLife, block, hitBonus)
        {
            EquippedWeapon = equippedWeapon;

            switch (PlayerChoice)
            {
                case SelectPlayer.Attacker:
                    MaxLife += 10;
                    break;
                case SelectPlayer.Defender:
                    Block += 10;
                    break;
                case SelectPlayer.Analytic:
                    HitBonus += 10;
                    break;
                default:
                    break;
            }
        }

        public override string ToString()
        {
            return string.Format($"****{Name}****\nLife: {Life} of {MaxLife}\nHit Bonus: {CalcHitBonus()}\nBlock: {Block}\nPlayer Chosen: {PlayerChoice}");
        }

        public override int CalcHitBonus()
        {
            return HitBonus;
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

    }
}
