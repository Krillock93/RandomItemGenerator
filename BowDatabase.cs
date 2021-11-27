using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class BowDatabase
    {
        public static readonly int[] minDamage = new int[]
        {
            2,
            2,
            5
        };
        public static readonly int[] maxDamage = new int[]
        {
            4,
            6,
            10
        };
        public static readonly string[] names = new string[]
        {
            "Short Bow",
            "Hunter Bow",
            "Long Bow"
        };
        public static readonly int[] durabilities = new int[]
        {
            8,
            10,
            12
        };
        public static readonly float[] attackSpeeds = new float[]
        {
            0.15f,
            0.15f,
            0.25f
        };
        public static readonly int[] buyValues = new int[]
        {
            5,
            10,
            15
        };
    }
}
