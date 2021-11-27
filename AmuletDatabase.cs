using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class AmuletDatabase
    {
        public static readonly string[] names = new string[]
        {
            "Bronze Amulet",
            "Silver Amulet",
            "Gold Amulet",
        };
        public static readonly int[] buyValues = new int[]
        {
            200,
            800,
            2000
        };
    }
}
