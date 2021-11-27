using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemWeapon : Item
    {
        protected int MinDamage { get; set; }
        protected int MaxDamage { get; set; }
        protected float ItemAttackSpeed { get; set; }

        public ItemWeapon()
        {
            itemType = ItemType.Weapon;
        }

        protected void CreateTrashWeapon()
        {
            Durability = (int)(Durability * 0.5f);
            MinDamage = (int)(MinDamage * 0.75f);
            MaxDamage = (int)(MaxDamage * 0.75f);
            BuyValue = (int)(BuyValue * 0.5f);
            ItemName = "Cracked " + ItemName;
        }

        public override void ShowProps()
        {
            base.ShowProps();
            Console.WriteLine($"Damage: {MinDamage} - {MaxDamage}");
            ShowItemDurability();
            Console.WriteLine($"{ConvertAttackSpeedToString(ItemAttackSpeed)} Attack speed");
            ShowAffixes();
            ShowGoldValue();
        }

        protected string ConvertAttackSpeedToString(float attackSpeed)
        {
            switch (attackSpeed)
            {
                case <= 0.15f: return "Very Fast";
                case <= 0.25f: return "Fast";
                case <= 0.35f: return "Normal";
                case <= 0.45f: return "Slow";
                default: return "Very Slow";
            }
        }
    }
}
