using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fight1v1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior thor = new StrenghtWarrior("Thor", 100, 26, 10);
            Warrior loki = new MagicWarrior("Loki", 75, 20, 10, 75);

            Battle.StartFight(thor, loki);
            Console.ReadLine(); 
        }
    }
}
