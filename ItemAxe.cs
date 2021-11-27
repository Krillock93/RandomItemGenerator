using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemAxe : ItemWeapon
    {
        private enum AxeType { Handaxe, BerserkerAxe, WarAxe }
        private AxeType axeType;
        public ItemAxe()
        {
            SetWeaponProperties();
            if (quality == Quality.Trash)
                CreateTrashWeapon();
        }

        private void SetWeaponProperties()
        {
            axeType = GetAxeType();
            ItemName = AxeDatabase.names[(int)axeType];
            Durability = AxeDatabase.durabilities[(int)axeType];
            ItemName = base.CreateItemName();
            ItemAttackSpeed = AxeDatabase.attackSpeeds[(int)axeType];
            BuyValue = AxeDatabase.buyValues[(int)axeType];
            CalculateRealBuyValue();
            CalculateDamage();
        }

        private AxeType GetAxeType()
        {
            return (AxeType)random.Next(0, Enum.GetNames<AxeType>().Length);
        }

        private void CalculateDamage()
        {
            MinDamage = AxeDatabase.minDamage[(int)axeType];
            MaxDamage = AxeDatabase.maxDamage[(int)axeType];

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
