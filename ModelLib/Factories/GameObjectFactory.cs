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
        protected string _name;
        protected Vector2 _position;

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

        public virtual GameObject GetGameObject()
        {
            return new GameObject(_name, _position);
        }
    }
}
