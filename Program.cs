using System;
using System.Collections.Generic;

namespace ItemGenerator
{
    
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                RandomItemGenerator rig = new RandomItemGenerator();
                Item item = rig.RollNewItem();
                item.ShowProps();

                
                Console.WriteLine("Roll new Item? (y/n)");
                if (Console.ReadLine() == "n")
                    break;
            }

            Console.ReadKey();
        }
    }
}
