using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Enemy
{
    internal class Enemy : Creature
    {
        AgentMove Movement { get; set; }
        public override AgentAttack Attack { get; set; }

        public Enemy()
        {
            Movement = new EnemyMove();
        }

        public Enemy(AgentMove movement, int maxHealth, string name) : base(maxHealth, name)
        {
            Movement = movement;
        }

        public Enemy(AgentMove movement, int maxHealth, string name, Vector2 position) : base(maxHealth, name, position)
        {
            Movement = movement;
        }

        public Enemy(AgentMove movement, int maxHealth, string name, Vector2 position, char shape) : base(maxHealth, name, position, shape)
        {
            Movement = movement;
        }

        public override void DoMove(char dir)
        {
            Position += Movement.Move(dir);
        }
    }
}
