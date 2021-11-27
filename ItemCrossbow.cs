using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemCrossbow : ItemWeapon
    {
        private enum CrossbowType { Club, BarbedClub, WarClub }
        private CrossbowType crossbowType;
        public ItemCrossbow()
        {
            SetWeaponProperties();
            if (quality == Quality.Trash)
                CreateTrashWeapon();
        }
        private void SetWeaponProperties()
        {
            crossbowType = GetBowType();
            ItemName = CrossbowDatabase.names[(int)crossbowType];
            Durability = CrossbowDatabase.durabilities[(int)crossbowType];
            ItemName = base.CreateItemName();
            ItemAttackSpeed = CrossbowDatabase.attackSpeeds[(int)crossbowType];
            BuyValue = CrossbowDatabase.buyValues[(int)crossbowType];
            CalculateRealBuyValue();
            CalculateDamage();
        }

        private CrossbowType GetBowType()
        {
            return (CrossbowType)random.Next(0, Enum.GetNames<CrossbowType>().Length);
        }

        private void CalculateDamage()
        {
            MinDamage = CrossbowDatabase.minDamage[(int)crossbowType];
            MaxDamage = CrossbowDatabase.maxDamage[(int)crossbowType];

            if (prefix?.StatToChange == StatToChange.Damage)
            {
                MinDamage += prefix.MinValue;
                MaxDamage += prefix.MaxValue;
            }

            if (suffix?.StatToChange == StatToChange.Damage)
            {
                MinDamage += suffix.MinValue;
                MaxDamage += suffix.MaxValue;
            }
        }
    }
}
