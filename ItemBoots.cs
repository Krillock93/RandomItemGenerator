using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemBoots : ItemArmor
    {
        private enum BootsArmorType { LeatherBoots, ChainBoots, PlateBoots }
        private BootsArmorType bootsArmorType;

        public ItemBoots()
        {
            SetArmorProperties();
            if (quality == Quality.Trash)
                CreateTrashArmor();
        }

        private void SetArmorProperties()
        {
            bootsArmorType = GetBootsArmorType();
            ItemName = BootsDatabase.names[(int)bootsArmorType];
            Durability = BootsDatabase.durabilities[(int)bootsArmorType];
            ItemName = base.CreateItemName();
            BuyValue = BootsDatabase.buyValues[(int)bootsArmorType];
            CalculateRealBuyValue();
            CalculateArmor();
        }

        private BootsArmorType GetBootsArmorType()
        {
            return (BootsArmorType)random.Next(0, Enum.GetNames<BootsArmorType>().Length);
        }

        private void CalculateArmor()
        {
            MinArmor = BootsDatabase.minArmor[(int)bootsArmorType];
            MaxArmor = BootsDatabase.maxArmor[(int)bootsArmorType];

            if (prefix?.StatToChange == StatToChange.Armor)
            {
                MinArmor += prefix.MinValue;
                MaxArmor += prefix.MaxValue;
            }

            if (suffix?.StatToChange == StatToChange.Armor)
            {
                MinArmor += suffix.MinValue;
                MaxArmor += suffix.MaxValue;
            }

            Armor = random.Next(MinArmor, MaxArmor + 1);
        }
    }
}
