using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight1v1
{
    class Warrior
    {
        public string Name { get; set; }
        public double Health { get; set; }
        public double AttackMax { get; set; }
        public double BlockMax { get; set;}

        public Warrior(string name = "Warrior", double health = 0, double attackMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attackMax;
            BlockMax = blockMax;
        }

        Random rn = new Random();

        public virtual double Attack()
        {
            return rn.Next(1,(int)AttackMax);
        }

        public virtual double Block()
        {
            return rn.Next(1, (int)BlockMax);
        }
    }
}
