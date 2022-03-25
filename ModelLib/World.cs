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

        public World()
        {
            Grid = new Vector2(10, 10);
            Objects = new Dictionary<int, GameObject>();
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
    }
}
