using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent.Player
{
    public class PlayerDo
    {
        public void ParseInput (string input)
        {
            switch (input)
            {
                case ("Up"):
                    {
                        _player.DoMove(input);
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
