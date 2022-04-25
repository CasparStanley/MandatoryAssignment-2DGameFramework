using ModelLib.Agent.Player;
using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class DrawWorld : DrawWorldTemplate<DrawWorld>
    {
        public override string WorldName { get; set; }

        private DrawWorld() { }



        public override void Draw(GameObject[] objects)
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
                        if (obj.Active && x == obj.Position.x && y == obj.Position.y)
                        {
                            objectDrawn = true;
                            DrawCell($"\u0020{obj.Shape}\u0020", ConsoleColor.Blue, ConsoleColor.Yellow);
                            Debug.Log("An object was drawn", onlyTrace:true);
                        }
                    }

                    if (!objectDrawn)
                    {
                        // Corners
                        if (y == 0 && x == 0 || y == 0 && x == World.Grid.x - 1 || y == World.Grid.y - 1 && x == 0 || y == World.Grid.y - 1 && x == World.Grid.x - 1)
                        {
                            DrawCell("+");
                        }
                        // Sides, except for corners
                        else if (x == 0 || x == World.Grid.x - 1)
                        {
                            DrawCell("|");
                        }
                        // Top and Bottom, except for corners
                        else if (y == 0 || y == World.Grid.y - 1)
                        {
                            DrawCell("---");
                        }
                        else
                        {
                            DrawCell("\u0020\u0020\u0020", backgroundColor:ConsoleColor.Yellow);
                        }
                    }
                }
                Console.Write("\n");
            }

            WriteStats();
        }

        public override void DrawCell(string content, ConsoleColor foregroundColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.DarkGray)
        {
            Console.ForegroundColor = foregroundColor;
            Console.BackgroundColor = backgroundColor;

            Console.Write(content);

            Console.ResetColor();
        }

        public override void WriteStats()
        {
            foreach (GameObject obj in World.GetObjects())
            {
                if (obj is Player)
                {
                    Debug.Log(obj.ToString());
                }
            }
        }
    }
}
