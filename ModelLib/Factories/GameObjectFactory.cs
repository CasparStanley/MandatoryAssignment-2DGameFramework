using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class GameObjectFactory : IGameObjectFactory
    {
        // HACK: DESIGN PATTERN - FACTORY

        protected string _name;
        protected Vector2 _position;
        protected char _shape;

        public GameObjectFactory(string name)
        {
            _name = name;
            _position = Vector2.zero;
        }

        public GameObjectFactory(string name, Vector2 position)
        {
            _name = name;
            _position = position;
        }

        public GameObjectFactory(string name, char shape)
        {
            _name = name;
            _shape = shape;
        }

        public GameObjectFactory(string name, Vector2 position, char shape)
        {
            _name = name;
            _position = position;
            _shape = shape;
        }

        public virtual GameObject GetGameObjectFixedPosition()
        {
            return new GameObject(_name, _position, _shape);
        }

        public virtual GameObject GetGameObject(Vector2 position)
        {
            return new GameObject(_name, position, _shape);
        }
    }
}
