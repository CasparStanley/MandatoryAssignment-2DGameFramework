using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Interfaces
{
    public interface IConfig
    {
        Vector2 BoardSize { get; set; }
        Vector2 PlayerStartPos { get; set; }
        char PlayerIcon { get; set; }
    }
}
