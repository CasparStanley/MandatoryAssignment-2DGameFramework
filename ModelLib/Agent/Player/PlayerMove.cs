using ModelLib.Agent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Player
{
    public class PlayerMove : AgentMove
    {
        // HACK: SOLID - Single Responsibility
        public override Vector2 Move(string input)
        {
            switch (input)
            {
                case ("Up"):
                    {
                        return new Vector2(0, 1);
                    }
                case ("Left"):
                    {
                        return new Vector2(-1, 0);
                    }
                case ("Down"):
                    {
                        return new Vector2(0, -1);
                    }
                case ("Right"):
                    {
                        return new Vector2(1, 0);
                    }
                default: return Vector2.zero;
            }
        }
    }
}
