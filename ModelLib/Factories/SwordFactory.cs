using ModelLib.GameObjects.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class SwordFactory : GameObjectFactory
    {
        int _damage;
        int _range;

        public SwordFactory(int damage, int range, string name) : base(name)
        {
            _damage = damage;
            _range = range;
        }

        public SwordFactory(int damage, int range, string name, Vector2 position) : base(name, position)
        {
            _damage = damage;
            _range = range;
        }

        public override GameObject GetGameObject(Vector2 position)
        {
            return new Sword('\u2628', _damage, _range, _name, position);
        }
    }
}
