using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class CrossbowDatabase
    {
        public static readonly int[] minDamage = new int[]
        {
            5,
            8,
            6
        };
        public static readonly int[] maxDamage = new int[]
        {
            10,
            15,
            12
        };
        public static readonly string[] names = new string[]
        {
            "Small Crossbow",
            "Crossbow",
            "Repeating Crossbow"
        };
        public static readonly int[] durabilities = new int[]
        {
            12,
            15,
            10
        };
        public static readonly float[] attackSpeeds = new float[]
        {
            0.3f,
            0.5f,
            0.2f
        };
        public static readonly int[] buyValues = new int[]
        {
            5,
            10,
            15
        };
    }
}
