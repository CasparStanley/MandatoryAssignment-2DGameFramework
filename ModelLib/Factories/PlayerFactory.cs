﻿using ModelLib.Agent.Player;
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
        private int _interactionDistance;

        public PlayerFactory(int maxHealth, int interactionDist, string name, Vector2 position) : base(name, position)
        {
            _maxHealth = maxHealth;
            _interactionDistance = interactionDist;
        }

        public PlayerFactory(int maxHealth, int interactionDist, string name) : base(name)
        {
            _maxHealth = maxHealth;
            _interactionDistance = interactionDist;
        }

        public override GameObject GetGameObjectFixedPosition()
        {
            return new Player(new PlayerMove(), _maxHealth, _interactionDistance, _name, _position);
        }

        public override GameObject GetGameObject(Vector2 position)
        {
            return new Player(new PlayerMove(), _maxHealth, _interactionDistance, _name, position);
        }
    }
}
