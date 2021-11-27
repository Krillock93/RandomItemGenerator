using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class ListOfPrefixes
    {
        public static List<Affix> prefixes = new List<Affix>()
        {
            { new Affix("Light ", -5,5, StatToChange.Health)},
            { new Affix("Healthy ", 10,20, StatToChange.Health)},
            { new Affix("Bolstering ", 20,30, StatToChange.Health)},
            { new Affix("Bloody ", 30,45, StatToChange.Health)},
            { new Affix("Godly ", 50,101, StatToChange.Health)},

            { new Affix("Moron's ", -10,0, StatToChange.Mana)},
            { new Affix("Glowing ", 5,10, StatToChange.Mana)},
            { new Affix("Bright ", 10,20, StatToChange.Mana)},
            { new Affix("Holy ", 20,50, StatToChange.Mana)},

            { new Affix("Invigoring ", 5,10, StatToChange.Stamina)},

            { new Affix("Dull ", -5,2, StatToChange.Damage)},
            { new Affix("Sharp ", 5,10, StatToChange.Damage)},
            { new Affix("Knight's ", 10,25, StatToChange.Damage)},

            { new Affix("Warrior's ",5,10,StatToChange.Armor)}
        };
    }
}
