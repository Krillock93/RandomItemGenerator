using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemGloves : ItemArmor
    {
        private enum GlovesArmorType { LeatherGloves, ChainGloves, PlateGloves }
        private GlovesArmorType glovesArmorType;

        public ItemGloves()
        {
            SetArmorProperties();
            if (quality == Quality.Trash)
                CreateTrashArmor();
        }

        private void SetArmorProperties()
        {
            glovesArmorType = GetGlovesArmorType();
            ItemName = GlovesDatabase.names[(int)glovesArmorType];
            Durability = GlovesDatabase.durabilities[(int)glovesArmorType];
            ItemName = base.CreateItemName();
            BuyValue = GlovesDatabase.buyValues[(int)glovesArmorType];
            CalculateRealBuyValue();
            CalculateArmor();
        }

        private GlovesArmorType GetGlovesArmorType()
        {
            return (GlovesArmorType)random.Next(0, Enum.GetNames<GlovesArmorType>().Length);
        }

        private void CalculateArmor()
        {
            MinArmor = GlovesDatabase.minArmor[(int)glovesArmorType];
            MaxArmor = GlovesDatabase.maxArmor[(int)glovesArmorType];

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
