using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemBelt : ItemArmor
    {
        private enum BeltArmorType { Sash, LeatherBelt, PlateBelt }
        private BeltArmorType beltArmorType;

        public ItemBelt()
        {
            SetArmorProperties();
            if (quality == Quality.Trash)
                CreateTrashArmor();
        }

        private void SetArmorProperties()
        {
            beltArmorType = GetBootsArmorType();
            ItemName = BeltDatabase.names[(int)beltArmorType];
            Durability = BeltDatabase.durabilities[(int)beltArmorType];
            ItemName = base.CreateItemName();
            BuyValue = BeltDatabase.buyValues[(int)beltArmorType];
            CalculateRealBuyValue();
            CalculateArmor();
        }

        private BeltArmorType GetBootsArmorType()
        {
            return (BeltArmorType)random.Next(0, Enum.GetNames<BeltArmorType>().Length);
        }

        private void CalculateArmor()
        {
            MinArmor = BeltDatabase.minArmor[(int)beltArmorType];
            MaxArmor = BeltDatabase.maxArmor[(int)beltArmorType];

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
