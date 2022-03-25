using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class ItemFactory : GameObjectFactory
    {
        private string _name;
        private Vector2 _position;

        public ItemFactory(string name, Vector2 position) : base(name, position)
        {
            _name = name;
            _position = position;
        }

        public override GameObject GetGameObject()
        {
            return new Item(_name, _position);
        }
    }
}
