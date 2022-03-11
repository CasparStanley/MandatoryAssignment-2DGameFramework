using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class GameObject
    {
        public Vector2 Position { get; private set; }
        public bool Active { get; private set; }

        public GameObject(Vector2 position)
        {
            Position = position;
        }

        public void SetActive(bool state)
        {
            Active = state;
        }
    }
}
