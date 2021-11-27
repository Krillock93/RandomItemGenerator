using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemRing : ItemJewellry
    {
        private enum RingType { BronzeRing, SilverRing, GoldRing }
        private RingType ringType;
        public ItemRing()
        {
            SetJewellryProperties();
        }

        private void SetJewellryProperties()
        {
            ringType = GetRingType();
            ItemName = RingDatabase.names[(int)ringType];
            ItemName = base.CreateItemName();
            BuyValue = RingDatabase.buyValues[(int)ringType];
            CalculateRealBuyValue();

        }

        private RingType GetRingType()
        {
            return (RingType)random.Next(0, Enum.GetNames<RingType>().Length);
        }
    }

}
