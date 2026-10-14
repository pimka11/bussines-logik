using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bussines_logik
{
    public class Player
    {
        public string Name;
        public Stat Health;
        public Stat Energy;
        public Inventory Inventory;
        public Stat Mana;
        public Player(string name, int maxHealth, int maxMana, int maxEnergy)
        {
            Inventory = new Inventory(10);
            Name = name;
            Health = new Stat(maxHealth);
            Mana = new Stat(maxMana);
            Energy = new Stat(maxEnergy);
        }
    }
}
