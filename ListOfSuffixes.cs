using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class ListOfSuffixes
    {
        public static List<Affix> suffixes = new List<Affix>()
        {
            { new Affix(" of Vigor", -5,5, StatToChange.Health)},
            { new Affix(" of the Wolf", 10,20, StatToChange.Health)},
            { new Affix(" of Rhinos", 20,30, StatToChange.Health)},
            { new Affix(" of Demons", 30,45, StatToChange.Health)},
            { new Affix(" of Gods", 50,101, StatToChange.Health)},

            { new Affix(" of the Whale", -10,0, StatToChange.Mana)},
            { new Affix(" of Light", 5,10, StatToChange.Mana)},
            { new Affix(" of Mana", 10,20, StatToChange.Mana)},
            { new Affix(" of Power", 20,50, StatToChange.Mana)},

            { new Affix(" of the Cheetah", 5,10, StatToChange.Stamina)},

            { new Affix(" of the Jester", -2,2, StatToChange.Damage)},
            { new Affix(" of the Warrior", 5,10, StatToChange.Damage)},
            { new Affix(" of the King", 10,25, StatToChange.Damage)},

            { new Affix("of the Elephant",5,10,StatToChange.Armor)}
        };
    }
}
