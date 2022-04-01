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

        public void DoMove()
        {
            Position += Movement.Move(Console.ReadKey().KeyChar);
        }
    }
}
