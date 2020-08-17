using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChateauLibrary
{
    public class Combat
    {
        public static void DoAttack(Character attacker, Character defender)
        {            
            int diceRoll = new Random().Next(1, 21);
            System.Threading.Thread.Sleep(30);
            if (diceRoll + attacker.CalcHitBonus() >= defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage.\n");
                Console.ResetColor();
            }

            else
            {
                Console.WriteLine($"{attacker.Name} missed!\n");
            }

        }

        public static void DoBattle(Players players, Villian villian)
        {
            DoAttack(players, villian);

            if (villian.Life > 0)
            {
                DoAttack(villian, players);
            }

        }
    }
}
