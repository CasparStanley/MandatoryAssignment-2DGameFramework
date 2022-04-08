using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class CreatureFactory : GameObjectFactory
    {
        private int _maxHealth;
        private string _name;
        private Vector2 _position;
        private char _shape;

        public CreatureFactory(int maxHealth, string name, Vector2 position, char creatureShape) : base(name, position)
        {
            _maxHealth = maxHealth;
            _name = name;
            _position = position;
            _shape = creatureShape;
        }

        //public override GameObject GetGameObject()
        //{
        //    return new Creature(_maxHealth, _name, _position, _shape);
        //}
    }
}
