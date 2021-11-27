using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class BootsDatabase
    {
        public static readonly int[] minArmor = new int[]
        {
            1,
            2,
            4,

        };
        public static readonly int[] maxArmor = new int[]
        {
            2,
            4,
            7,

        };
        public static readonly string[] names = new string[]
        {
            "Leather Boots",
            "Chain Boots",
            "Plate Greaves",
        };
        public static readonly int[] durabilities = new int[]
        {
            4,
            6,
            10,
        };
        public static readonly int[] buyValues = new int[]
        {
            5,
            15,
            30,
        };
    }
}
