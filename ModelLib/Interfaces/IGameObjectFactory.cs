using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Interfaces
{
    public interface IGameObjectFactory
    {
        GameObject GetGameObjectFixedPosition();
        GameObject GetGameObject(Vector2 position);
    }
}
