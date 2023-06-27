using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight1v1
{
    class Battle
    {
        public static void StartFight(Warrior Warr1, Warrior Warr2)
        {
            while (true)
            {
                if(GetAttackResult(Warr1, Warr2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if(GetAttackResult(Warr2, Warr1) =="Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }
        
        public static string GetAttackResult(Warrior attacker,Warrior blocker)
        {
            double attackerDmg = attacker.Attack();
            double blockerAbs = blocker.Block();
            double damage = attackerDmg - blockerAbs;

            if (damage > 0)
            {
                blocker.Health -= damage;
            }else damage = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",attacker.Name,blocker.Name,damage);
            Console.WriteLine("{0} has {1} Health",blocker.Name,blocker.Health);
            Console.WriteLine("---------------------------------------------------------------------");
            System.Threading.Thread.Sleep(1000);

            if (blocker.Health <= 0)
            {
                Console.WriteLine("{0} is dead {1} is WIN!!!", blocker.Name, attacker.Name);
                return "Game Over";
            }
            else return "Fight Again";
        }
    }
}
