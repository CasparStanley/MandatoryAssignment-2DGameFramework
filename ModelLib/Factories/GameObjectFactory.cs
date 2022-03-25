using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class GameObjectFactory : IGameObjectFactory
    {
        private string _name;
        private Vector2 _position;

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
