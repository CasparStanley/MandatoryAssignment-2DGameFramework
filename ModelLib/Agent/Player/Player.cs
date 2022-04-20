using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Player
{
    public class Player : Creature
    {
        AgentMove Movement { get; set; }
        public override AgentAttack Attack { get; set; }

        public Player()
        {
            Movement = new PlayerMove();
        }

        public Player(AgentMove movement, int maxHealth, string name) : base(maxHealth, name)
        {
            Movement = movement;
        }

        public Player(AgentMove movement, int maxHealth, string name, Vector2 position) : base(maxHealth, name, position)
        {
            Movement = movement;
        }

        public Player(AgentMove movement, int maxHealth, string name, Vector2 position, char shape) : base(maxHealth, name, position, shape)
        {
            Movement = movement;
        }

        public override void DoMove(string dir)
        {
            Position += Movement.Move(dir);
        }
    }
}
