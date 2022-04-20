using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Interfaces
{
    public interface IInputSystem
    {
        string InputSystemName { get; set; }
        Dictionary<char, string> Inputs { get; set; }
    }
}
