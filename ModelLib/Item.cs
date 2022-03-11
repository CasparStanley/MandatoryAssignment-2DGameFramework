using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Item : GameObject
    {
        public bool Lootable { get; set; }
        public bool Removable { get; set; }

        public Item(Vector2 position, string name) : base (position, name)
        {

        }
    }
}
