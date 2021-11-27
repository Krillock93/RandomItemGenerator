using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class ChestArmorDatabase
    {
        public static readonly int[] minArmor = new int[]
        {
            2,
            3,
            8,
            15
        };
        public static readonly int[] maxArmor = new int[]
        {
            3,
            6,
            12,
            20
        };
        public static readonly string[] names = new string[]
        {
            "Robes",
            "Leather Armor",
            "Chain Mail",
            "Plate Mail"
        };
        public static readonly int[] durabilities = new int[]
        {
            4,
            8,
            20,
            40
        };
        public static readonly int[] buyValues = new int[]
        {
            10,
            20,
            45,
            90
        };
    }
}
