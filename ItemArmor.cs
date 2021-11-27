using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemArmor : Item
    {
        protected int MinArmor { get; set; }
        protected int MaxArmor { get; set; }
        protected int Armor { get; set; }

        public ItemArmor()
        {
            itemType = ItemType.Armor;
        }

        protected void CreateTrashArmor()
        {
            Durability = (int)(Durability * 0.5f);
            MinArmor = (int)(MinArmor * 0.75f);
            MaxArmor = (int)(MaxArmor * 0.75f);
            BuyValue = (int)(BuyValue * 0.5f);
            ItemName = "Cracked " + ItemName;
        }

        public override void ShowProps()
        {
            base.ShowProps();
            Console.WriteLine($"Armor: {Armor}");
            ShowItemDurability();
            ShowAffixes();
            ShowGoldValue();
        }
    }
}
