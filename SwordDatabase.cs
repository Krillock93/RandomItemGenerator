using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public static class SwordDatabase
    {
        public static readonly int[] minDamage = new int[]
        {
            3,
            5,
            8
        };
        public static readonly int[] maxDamage = new int[]
        {
            6,
            10,
            15
        };
        public static readonly string[] names = new string[]
        {
            "Short Sword",
            "Sabre",
            "Scimitar"
        };
        public static readonly int[] durabilities = new int[]
        {
            12,
            10,
            15
        };
        public static readonly float[] attackSpeeds = new float[]
        {
            0.15f,
            0.15f,
            0.15f
        };
        public static readonly int[] buyValues = new int[]
        {
            5,
            10,
            15
        };
    }
}
