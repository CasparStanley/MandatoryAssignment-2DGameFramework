using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    class Item_Defence : Item
    {
        public int ArmorPoints { get; set; }

        public Item_Defence(int armorPoints, string name, Vector2 position) : base(name, position)
        {
            ArmorPoints = armorPoints;
        }
    }
}
