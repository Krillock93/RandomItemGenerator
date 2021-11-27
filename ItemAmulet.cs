using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemAmulet : ItemJewellry
    {
        private enum AmuletType { BronzeAmulet, SilverAmulet, GoldAmulet }
        private AmuletType amuletType;
        public ItemAmulet()
        {
            SetJewellryProperties();
        }

        private void SetJewellryProperties()
        {
            amuletType = GetAmuletType();
            ItemName = AmuletDatabase.names[(int)amuletType];
            ItemName = base.CreateItemName();
            BuyValue = AmuletDatabase.buyValues[(int)amuletType];
            CalculateRealBuyValue();
        }

        private AmuletType GetAmuletType()
        {
            return (AmuletType)random.Next(0, Enum.GetNames<AmuletType>().Length);
        }
    }
}
