using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.GameObjects
{
    public class RelativeDistanceGameObject
    {
        public int Id { get; }
        public string Name { get; set; }
        public Vector2 Distance { get; set; }

        public RelativeDistanceGameObject(int id, string name, Vector2 distance)
        {
            Id = id;
            Name = name;
            Distance = distance;
        }
    }
}
