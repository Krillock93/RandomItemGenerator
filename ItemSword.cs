using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemSword : ItemWeapon
    {
        private enum SwordType { ShortSword, Sabre, Scimitar }
        private SwordType swordType;
        public ItemSword()
        {
            SetWeaponProperties();
            if (quality == Quality.Trash)
                CreateTrashWeapon();
        }

        private void SetWeaponProperties()
        {
            swordType = GetSwordType();
            ItemName = SwordDatabase.names[(int)swordType];
            Durability = SwordDatabase.durabilities[(int)swordType];
            ItemName = base.CreateItemName();
            ItemAttackSpeed = SwordDatabase.attackSpeeds[(int)swordType];
            BuyValue = SwordDatabase.buyValues[(int)swordType];
            CalculateRealBuyValue();
            CalculateDamage();
        }

        private SwordType GetSwordType()
        {
            return (SwordType)random.Next(0, Enum.GetNames<SwordType>().Length);
        }

        private void CalculateDamage()
        {
            MinDamage = SwordDatabase.minDamage[(int)swordType];
            MaxDamage = SwordDatabase.maxDamage[(int)swordType];

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
