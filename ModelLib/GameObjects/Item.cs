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

        public Item() { }

        public Item(string name) : base(name)
        {

        }

        public Item(string name, Vector2 position) : base (name, position)
        {

        }
    }
}
