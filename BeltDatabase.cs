using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class BeltDatabase
    {
        public static readonly int[] minArmor = new int[]
        {
            1,
            2,
            3,

        };
        public static readonly int[] maxArmor = new int[]
        {
            2,
            3,
            5,

        };
        public static readonly string[] names = new string[]
        {
            "Sash",
            "Leather Belt",
            "Plate Belt",
        };
        public static readonly int[] durabilities = new int[]
        {
            4,
            6,
            10,
        };
        public static readonly int[] buyValues = new int[]
        {
            3,
            17,
            50,
        };
    }

}
