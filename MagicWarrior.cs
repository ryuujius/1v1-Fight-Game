using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight1v1
{
    class MagicWarrior : Warrior
    {
        int TeleportChance = 0;

        public MagicWarrior(string name, double health, double attackMax, double blockMax, int teleportChance) : base(name, health, attackMax, blockMax)
        {
            this.TeleportChance = teleportChance;
        }

        CanTeleport teleportType = new CanTeleport();

        public override double Block()
        {
            Random rn = new Random();
            int blockChance = rn.Next(1, 100);
            if(TeleportChance >= blockChance)
            {
                Console.WriteLine($"{Name} is {teleportType.teleport()}");
                return 10000;
            }
            else
            {
                return base.Block();
            }
        }
    }
}
