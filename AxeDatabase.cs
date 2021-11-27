using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class AxeDatabase
    {
        public static readonly int[] minDamage = new int[]
        {
            2,
            3,
            5
        };
        public static readonly int[] maxDamage = new int[]
        {
            6,
            8,
            12
        };
        public static readonly string[] names = new string[]
        {
            "Hand Axe",
            "Berserker Axe",
            "War Axe"

        };
        public static readonly int[] durabilities = new int[]
        {
            8,
            10,
            12
        };
        public static readonly float[] attackSpeeds = new float[]
        {
            0.2f,
            0.2f,
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
