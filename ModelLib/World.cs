using ModelLib.Factories;
using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ModelLib
{
    public class World
    {
        public static int NextGameObjectId
        {
            get {
                return nextGameObjectId++; 
            }
        }

        private static int nextGameObjectId;

        public static Dictionary<int, GameObject> Objects { get; set; }
        public static List<Creature> Creatures { get; set; }

        public static Vector2 Grid { get; set; }

        public World(Vector2 worldSize)
        {
            Grid = worldSize;
            Objects = new Dictionary<int, GameObject>();
            Creatures = new List<Creature>();
        }

        // Factories
        

        public static async void Destroy(GameObject gameObject, float delay = 0)
        {
            await DoDestroy(gameObject, delay);
        }

        private static async Task DoDestroy(GameObject gObj, float t)
        {
            int del = (int)MathF.Round(t * 1000, 0);
            await Task.Delay(del);
            Objects.Remove(gObj.Id);
        }

        public static GameObject[] GetObjects()
        {
            List<GameObject> objects = new List<GameObject>();
            foreach (GameObject obj in Objects.Values)
            {
                objects.Add(obj);
            }
            return objects.ToArray();
        }

        public static Vector2[] GetObjectPositions()
        {
            List<Vector2> positions = new List<Vector2>();
            foreach(GameObject obj in Objects.Values)
            {
                positions.Add(obj.Position);
            }
            return positions.ToArray();
        }
    }
}
