using System;
using System.Collections.Generic;
using ModelLib;
using ModelLib.Agent;
using ModelLib.Agent.Player;

namespace MandatoryAssignment_2DGame
{
    class Program
    {
        static void Main()
        {
            Debug.StartTracing();

            bool runGame = true;

            World level1 = new World(new Vector2(20, 20));
            Player player = new Player(new PlayerMove(), 100, "Player 1", new Vector2(4, 4), 'o');
            GameObject box = new GameObject("Box", new Vector2(5, 7));

            //Item shield = new Item("Shield");
            //Creature player1 = new Creature(100, "Player 1");
            //Creature orc = new Creature(10, "Orc", new Vector2(5, 6));

            //Debug.Log("Objects in the world:", ConsoleColor.Green);
            //foreach (KeyValuePair<int, GameObject> kvp in World.Objects)
            //{
            //    Debug.Log(kvp.Key + ") " + kvp.Value.ToString());
            //}

            while (runGame)
            {
                DrawWorld.Draw(World.GetObjects());
                Debug.Log("-------- The world was updated --------", onlyTrace:true); // Custom Debug class, which also uses tracing.

                char input = Console.ReadKey().KeyChar;

                switch (input)
                {
                    case 'w':
                        player.DoMove(input);
                        break;
                    case 'a':
                        player.DoMove(input);
                        break;
                    case 's':
                        player.DoMove(input);
                        break;
                    case 'd':
                        player.DoMove(input);
                        break;
                    case (char)ConsoleKey.Escape:
                        runGame = false;
                        break;
                }

                Console.Clear();
            }

            // It is important to hit escape before closing the program, so the code will reach this part to save the tracing file.
            Debug.StopTracing();
        }
    }
}
