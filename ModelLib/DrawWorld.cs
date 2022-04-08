using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class DrawWorld
    {
        public static void Draw(GameObject[] objects)
        {
            bool objectDrawn = false;

            for (int y = (int)World.Grid.y - 1; y >= 0; y--)
            {
                for (int x = 0; x < World.Grid.x; x++)
                {
                    objectDrawn = false;

                    // Objects
                    foreach (GameObject obj in objects)
                    {
                        if (x == obj.Position.x && y == obj.Position.y)
                        {
                            objectDrawn = true;
                            Debug.LogWarning($"\u0020{obj.Shape}\u0020", ConsoleColor.Blue);
                        }
                    }

                    if (!objectDrawn)
                    {
                        // Corners
                        if (y == 0 && x == 0 || y == 0 && x == World.Grid.x - 1 || y == World.Grid.y - 1 && x == 0 || y == World.Grid.y - 1 && x == World.Grid.x - 1)
                        {
                            Debug.Log("+", ConsoleColor.White);
                        }
                        // Sides, except for corners
                        else if (x == 0 || x == World.Grid.x - 1)
                        {
                            Debug.Log("|", ConsoleColor.White);
                        }
                        // Top and Bottom, except for corners
                        else if (y == 0 || y == World.Grid.y - 1)
                        {
                            Debug.Log("---", ConsoleColor.White);
                        }
                        else
                        {
                            Debug.LogWarning("\u0020\u0020\u0020");
                        }
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
