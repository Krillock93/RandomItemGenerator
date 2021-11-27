using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class Item
    {
        public Random random = new Random();
        //ItemLevel über MonsterLevel das Loot droppt definieren
        //und so die Affixes in den Listen auswürfeln 
        //mit random.next(Itemlevel-3,Itemlevel+3) oder so
        public int ItemLevel { get; set; }
        public int Durability { get; set; }

        protected ItemType itemType;
        protected Quality quality;
        protected Affix suffix = null;
        protected Affix prefix = null;

        protected int BuyValue { get; set; }
        protected int SellValue { get => BuyValue / 2; }
        protected int RepairValue { get => BuyValue / 4; }
        public string ItemName { get; set; }

        public Item()
        {
            quality = GetQuality();

            if (quality == Quality.Uncommon)
            {
                if (random.Next(0, 100) < 50)
                    prefix = GetPrefix();
                else suffix = GetSuffix();
            }
            else if (quality == Quality.Rare)
            {
                prefix = GetPrefix();
                suffix = GetSuffix();
            }
            else if (quality == Quality.Unique)
            {
                Console.WriteLine("Noch keine Uniques vorhanden!");
            }
        }

        protected void CalculateRealBuyValue()
        {
            if ((int)quality < 2)
                return;

            if (prefix?.Value < 0 || suffix?.Value < 0)
            {
                BuyValue = 2;
                return;
            }

            int prefixVal, suffixVal;
            prefixVal = 0;
            suffixVal = 0;

            if (prefix != null)
                prefixVal = prefix.Value * 10;
            if (suffix != null)
                suffixVal = suffix.Value * 10;

            //Irgend a weirde Formel -> anpassungsfähig
            BuyValue += ((BuyValue + prefixVal + suffixVal) * (int)quality) * (int)quality;
            BuyValue += CalculateRandomNumber();
        }

        private int CalculateRandomNumber()
        {
            switch (BuyValue)
            {
                case < 10: return random.Next(0, 10);
                case < 100: return random.Next(10, 100);
                case < 1000: return random.Next(10, 1000);
                case < 10000: return random.Next(10, 10000);
                case < 100000: BuyValue = 25000; return 0;
                default:
                    Console.WriteLine("Something went wrong in CalculateRandomNumber()");
                    return 0;
            }
        }

        protected string CreateItemName()
        {
            return prefix?.Name + ItemName + suffix?.Name;
        }

        protected virtual Quality GetQuality()
        {
            int selector = random.Next(0, 10000);
            switch (selector)
            {
                case < 100: return Quality.Unique;
                case < 2000: return Quality.Rare;
                case < 6000: return Quality.Uncommon;
                case < 9000: return Quality.Common;
                default: return Quality.Trash;
            }
        }

        protected virtual Affix GetPrefix()
        {
            return ListOfPrefixes.prefixes[random.Next(0, ListOfPrefixes.prefixes.Count)];
        }
        protected virtual Affix GetSuffix()
        {
            return ListOfSuffixes.suffixes[random.Next(0, ListOfSuffixes.suffixes.Count)];
        }

        public virtual void ShowProps()
        {
            ShowItemName();
        }

        protected void ShowGoldValue()
        {
            Console.WriteLine($"SellValue: {SellValue} Gold");
        }

        protected void ShowItemName()
        {
            Console.WriteLine(ItemName);
        }
        protected void ShowItemDurability()
        {
            if (itemType != ItemType.Jewellry)
                Console.WriteLine("Durability: " + Durability);
        }
        protected void ShowAffixes()
        {
            prefix?.ShowProps();
            suffix?.ShowProps();
        }
    }
}
