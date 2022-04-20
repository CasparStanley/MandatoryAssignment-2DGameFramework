using ModelLib.Agent.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Interfaces
{
    public interface IGameStart
    {
        IConfig Config { get; }
        Player Player { get; }
        bool RunningGame { get; }

        void StartGame();
        void RunGame();
        void StopGame();
    }
}
