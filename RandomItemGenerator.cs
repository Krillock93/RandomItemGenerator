using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public enum ItemType { Weapon, Armor, Jewellry }
    public enum WeaponType { Axe, Sword, Hammer, Bow, Crossbow }
    public enum ArmorType { ChestArmor, Gloves, Boots, Belt, }
    public enum JewellryType { Ring, Amulet }
    public enum Quality { Trash, Common, Uncommon, Rare, Unique }
    public enum StatToChange { Health, Mana, Stamina, Damage, FireResist, LightningResist, ColdResist, Armor }

    public class RandomItemGenerator
    {
        private Random random = new Random();

        public RandomItemGenerator()
        {

        }

        public Item RollNewItem()
        {
            int i = random.Next(0, Enum.GetNames<ItemType>().Length);

            switch (i)
            {
                case 0: return RollNewWeapon();
                case 1: return RollNewArmor();
                case 2: return RollNewJewellry();
                default: throw new Exception("Irgendwas haut ned hin in RollNewItem");
            }
        }

        private ItemWeapon RollNewWeapon()
        {
            //Switch mit WeaponType
            int i = random.Next(0, Enum.GetNames<WeaponType>().Length);

            switch (i)
            {
                case 0: return new ItemAxe();
                case 1: return new ItemSword();
                case 2: return new ItemHammer();
                case 3: return new ItemBow();
                case 4: return new ItemCrossbow();
                default: throw new Exception("Irgendwas haut ned hin in RollNewWeapon");
            }
        }

        private ItemArmor RollNewArmor()
        {
            int i = random.Next(0, Enum.GetNames<ArmorType>().Length);
            switch (i)
            {
                case 0: return new ItemChestArmor();
                case 1: return new ItemGloves();
                case 2: return new ItemBoots();
                case 3: return new ItemBelt();
                default: throw new Exception("Irgendwas haut ned hin in RollNewArmor");
            }
        }

        private ItemJewellry RollNewJewellry()
        {
            int i = random.Next(0, Enum.GetNames<JewellryType>().Length);
            switch (i)
            {
                case 0: return new ItemRing();
                case 1: return new ItemAmulet();
                default: throw new Exception("Irgendwas haut ned hin in RollNewJewellry");
            }
        }
    }
}
