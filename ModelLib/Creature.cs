using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Creature
    {
        public Vector2 Position { get; set; }

        public Creature(Vector2 position)
        {
            Position = position;
        }

        public void UpdatePosition(Vector2 newPosition)
        {
            throw new NotImplementedException();
        }
    }
}
