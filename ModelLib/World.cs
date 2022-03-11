using System;
using System.Collections.Generic;

namespace ModelLib
{
    public class World
    {
        public Vector2 Grid { get; set; }
        public List<Creature> Creatures { get; set; }
        public List<GameObject> Objects { get; set; }

        public World(int gridWidth, int gridHeight)
        {
            Grid = new Vector2(gridWidth, gridHeight);
        }
    }
}
