using ModelLib.Agent.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    internal class PlayerFactory : GameObjectFactory
    {
        private int _maxHealth;
        private string _name;
        private Vector2 _position;

        public PlayerFactory(int maxHealth, string name, Vector2 position) : base(name, position)
        {
            _maxHealth = maxHealth;
            _name = name;
            _position = position;
        }

        public override GameObject GetGameObject()
        {
            return new Player(new PlayerMove(), _maxHealth, _name, _position);
        }
    }
}
