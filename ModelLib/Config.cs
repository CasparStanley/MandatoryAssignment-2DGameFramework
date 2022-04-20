using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Config : IConfig
    {
        public Vector2 BoardSize { get; set; }
        public Vector2 PlayerStartPos { get; set; }
        public char PlayerIcon { get; set; }

        public Config() { }

        public Config(Vector2 boardSize, Vector2 playerStartPos, char playerIcon)
        {
            BoardSize = boardSize;
            PlayerStartPos = playerStartPos;
            PlayerIcon = playerIcon;
        }

        public override string ToString()
        {
            return $"{{{nameof(BoardSize)}={BoardSize.ToString()}, {nameof(PlayerStartPos)}={PlayerStartPos.ToString()}, {nameof(PlayerIcon)}={PlayerIcon.ToString()}}}";
        }
    }
}
