using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Enemy
{
    public class Enemy : Creature
    {
        IMove Movement { get; set; }
        public override AgentAttack Attack { get; set; }

        public Enemy()
        {
            Movement = new EnemyMove();
        }

        public Enemy(IMove movement, int maxHealth, int interactionDist, string name) : base(maxHealth, interactionDist, name)
        {
            Movement = movement;
        }

        public Enemy(IMove movement, int maxHealth, int interactionDist, string name, Vector2 position) : base(maxHealth, interactionDist, name, position)
        {
            Movement = movement;
        }

        public Enemy(IMove movement, int maxHealth, int interactionDist, string name, Vector2 position, char shape) : base(maxHealth, interactionDist, name, position, shape)
        {
            Movement = movement;
        }

        public override void DoMove(string dir)
        {
            Position += Movement.Move(dir);
        }
    }
}
