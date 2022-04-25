using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class ItemFactory : GameObjectFactory
    {
        public ItemFactory(string name) : base(name)
        {
        }

        public ItemFactory(string name, Vector2 position) : base(name, position)
        {
        }

        public override GameObject GetGameObjectFixedPosition()
        {
            return new Item(_name, _position);
        }

        public override GameObject GetGameObject(Vector2 position)
        {
            return new Item(_name, position);
        }
    }
}
