using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class Affix
    {
        private Random random = new Random();
        public string Name { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Value { get; set; }
        public StatToChange StatToChange { get; set; }

        public Affix(string name, int minVal, int maxVal, StatToChange statToChange)
        {
            Name = name;
            MinValue = minVal;
            MaxValue = maxVal;
            Value = random.Next(minVal, maxVal + 1);
            StatToChange = statToChange;
        }

        public void ShowProps()
        {
            Console.WriteLine($"{StatToChange} {Value}");
        }
    }

}
