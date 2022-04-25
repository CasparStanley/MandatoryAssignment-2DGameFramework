using ModelLib.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class RelativeGameObjectDistance
    {
        private List<RelativeDistanceGameObject> gameObjectsDistance;

        // HACK: LINQ
        /// <summary>
        /// This method uses LINQ Data Transformation to make a new List of game objects in the world, but with a relative distance to an origin point.
        /// This could be used to find the distances to everything from the Player. 
        /// You could look through the list and if a distance to something is withing a certain range you could interact with it.
        /// </summary>
        /// <param name="origin">Where the distance to everything will be calculated from</param>
        /// <returns>A list of all objects in the world, with their ID, name, and the distance to the origin.</returns>
        public List<RelativeDistanceGameObject> GetGameObjectsDistance(Vector2 origin)
        {
            gameObjectsDistance = Transformer.TransformObjects<GameObject, RelativeDistanceGameObject>(
            World.Objects.Values.ToList(), g => new RelativeDistanceGameObject(g.Id, g.Name, g.Position - origin));

            return gameObjectsDistance;
        }
    }
}
