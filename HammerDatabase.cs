using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class HammerDatabase
    {
        public static readonly int[] minDamage = new int[]
        {
            5,
            8,
            12
        };
        public static readonly int[] maxDamage = new int[]
        {
            10,
            14,
            20
        };
        public static readonly string[] names = new string[]
        {
            "Club",
            "Barbed Club",
            "War Club"
        };
        public static readonly int[] durabilities = new int[]
        {
            15,
            20,
            25
        };
        public static readonly float[] attackSpeeds = new float[]
        {
            0.3f,
            0.3f,
            0.3f
        };
        public static readonly int[] buyValues = new int[]
        {
            5,
            10,
            15
        };
    }
}
