using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class GlovesDatabase
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
            "Leather Gloves",
            "Chain Gloves",
            "Plate Gloves",
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
