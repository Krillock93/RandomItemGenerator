using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemBow : ItemWeapon
    {
        private enum BowType { Club, BarbedClub, WarClub }
        private BowType bowType;
        public ItemBow()
        {
            SetWeaponProperties();
            if (quality == Quality.Trash)
                CreateTrashWeapon();
        }
        private void SetWeaponProperties()
        {
            bowType = GetBowType();
            ItemName = BowDatabase.names[(int)bowType];
            Durability = BowDatabase.durabilities[(int)bowType];
            ItemName = base.CreateItemName();
            ItemAttackSpeed = BowDatabase.attackSpeeds[(int)bowType];
            BuyValue = BowDatabase.buyValues[(int)bowType];
            CalculateRealBuyValue();
            CalculateDamage();
        }

        private BowType GetBowType()
        {
            return (BowType)random.Next(0, Enum.GetNames<BowType>().Length);
        }

        private void CalculateDamage()
        {
            MinDamage = BowDatabase.minDamage[(int)bowType];
            MaxDamage = BowDatabase.maxDamage[(int)bowType];

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
