using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Enemy
{
    internal class EnemyMove : AgentMove
    {
        // ToDo: Make this not wasd
        public override Vector2 Move(char input)
        {
            switch (char.ToLower(input))
            {
                case ('w'):
                    {
                        return new Vector2(0, 1);
                    }
                case ('a'):
                    {
                        return new Vector2(-1, 0);
                    }
                case ('s'):
                    {
                        return new Vector2(0, -1);
                    }
                case ('d'):
                    {
                        return new Vector2(1, 0);
                    }
                default: return Vector2.zero;
            }
        }
    }
}
