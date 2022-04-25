using ModelLib.Agent.Enemy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Factories
{
    public class EnemyFactory : GameObjectFactory
    {
        private int _maxHealth;
        private int _interactionDistance;

        public EnemyFactory(int maxHealth, int interactionDist, string name, char creatureShape) : base(name, creatureShape)
        {
            _maxHealth = maxHealth;
            _interactionDistance = interactionDist;
        }

        public EnemyFactory(int maxHealth, int interactionDist, string name, Vector2 position, char creatureShape) : base(name, position, creatureShape)
        {
            _maxHealth = maxHealth;
            _interactionDistance = interactionDist;
        }

        public override GameObject GetGameObjectFixedPosition()
        {
            return new Enemy(new EnemyMove(), _maxHealth, _interactionDistance, "Enemy", _position, _shape);
        }

        public override GameObject GetGameObject(Vector2 position)
        {
            return new Enemy(new EnemyMove(), _maxHealth, _interactionDistance, "Enemy", position, _shape);
        }
    }
}
