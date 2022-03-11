using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    class Item_Attack : Item
    {
        public int Damage { get; set; }
        public int Range { get; set; }

        public Item_Attack(int damage, int range, string name) : base(name)
        {
            Damage = damage;
            Range = range;
        }
    }
}
