using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight1v1
{
    class StrenghtWarrior : Warrior
    {
        public int UltPoints { get; set; } = 1;

        public StrenghtWarrior(string name, double health, double attackMax, double blockMax) : base(name, health, attackMax, blockMax) { }

        public override double Attack()
        {
            UltPoints += 1;
            if (UltPoints % 3 == 0)
            {
                Console.WriteLine($"{Name} use his Ultimate and damage x2.");
                return 2*base.Attack();
            }
            else
            {
                return base.Attack();
            }
        }



    }
}
