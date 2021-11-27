using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemHammer : ItemWeapon
    {
        private enum HammerType { Club, BarbedClub, WarClub }
        private HammerType hammerType;
        public ItemHammer()
        {
            SetWeaponProperties();
            if (quality == Quality.Trash)
                CreateTrashWeapon();
        }
        private void SetWeaponProperties()
        {
            hammerType = GetHammerType();
            ItemName = HammerDatabase.names[(int)hammerType];
            Durability = HammerDatabase.durabilities[(int)hammerType];
            ItemName = base.CreateItemName();
            ItemAttackSpeed = HammerDatabase.attackSpeeds[(int)hammerType];
            BuyValue = HammerDatabase.buyValues[(int)hammerType];
            CalculateRealBuyValue();
            CalculateDamage();
        }

        private HammerType GetHammerType()
        {
            return (HammerType)random.Next(0, Enum.GetNames<HammerType>().Length);
        }

        private void CalculateDamage()
        {
            MinDamage = HammerDatabase.minDamage[(int)hammerType];
            MaxDamage = HammerDatabase.maxDamage[(int)hammerType];

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
