using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Player
{
    public class Player : Creature
    {
        IMove Movement { get; set; }
        public override AgentAttack Attack { get; set; }

        public Player()
        {
            Movement = new PlayerMove();
            Attack = new PlayerAttack(this, 1, 1);
        }

        public Player(IMove movement, int maxHealth, int interactionDist, string name) : base(maxHealth, interactionDist, name)
        {
            Movement = movement;
            Attack = new PlayerAttack(this, 1, 1);
        }

        public Player(IMove movement, int maxHealth, int interactionDist, string name, Vector2 position) : base(maxHealth, interactionDist, name, position)
        {
            Movement = movement;
            Attack = new PlayerAttack(this, 1, 1);
        }

        public Player(IMove movement, int maxHealth, int interactionDist, string name, Vector2 position, char shape) : base(maxHealth, interactionDist, name, position, shape)
        {
            Movement = movement;
            Attack = new PlayerAttack(this, 1, 1);
        }

        public override void DoMove(string dir)
        {
            Position += Movement.Move(dir);
        }
    }
}
