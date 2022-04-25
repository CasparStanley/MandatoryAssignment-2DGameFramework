using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.GameObjects.Armor
{
    internal class Helmet : Item_Defence
    {
        public Helmet(int armorPoints, string name, Vector2 position) : base(armorPoints, name, position)
        {
        }
    }
}
