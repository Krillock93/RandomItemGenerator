using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemGenerator
{
    public class ItemJewellry : Item
    {
        public ItemJewellry()
        {
            itemType = ItemType.Jewellry;
        }

        public override void ShowProps()
        {
            base.ShowProps();
            ShowAffixes();
            ShowGoldValue();
        }
    }
}
