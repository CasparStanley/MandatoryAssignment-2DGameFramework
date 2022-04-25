using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.GameObjects.Weapons
{
    public class Sword : Item_Attack
    {
        public Sword(char _shape, int damage, int range, string name, Vector2 position) : base(damage, range, name, position)
        {
            Shape = _shape;
        }
    }
}
