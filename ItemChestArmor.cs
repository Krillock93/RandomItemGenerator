using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemChestArmor : ItemArmor
    {
        private enum ChestArmorType { Robes, LeatherArmor, ChainMail, PlateMail }
        private ChestArmorType chestArmorType;

        public ItemChestArmor()
        {
            SetArmorProperties();
            if (quality == Quality.Trash)
                CreateTrashArmor();
        }

        private void SetArmorProperties()
        {
            chestArmorType = GetChestArmorType();
            ItemName = ChestArmorDatabase.names[(int)chestArmorType];
            Durability = ChestArmorDatabase.durabilities[(int)chestArmorType];
            ItemName = base.CreateItemName();
            BuyValue = ChestArmorDatabase.buyValues[(int)chestArmorType];
            CalculateRealBuyValue();
            CalculateArmor();
        }

        private ChestArmorType GetChestArmorType()
        {
            return (ChestArmorType)random.Next(0, Enum.GetNames<ChestArmorType>().Length);
        }

        private void CalculateArmor()
        {
            MinArmor = ChestArmorDatabase.minArmor[(int)chestArmorType];
            MaxArmor = ChestArmorDatabase.maxArmor[(int)chestArmorType];

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
