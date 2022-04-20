using System;
using System.Collections.Generic;
using ModelLib;
using ModelLib.Agent;
using ModelLib.Agent.Player;
using ModelLib.Interfaces;

namespace MandatoryAssignment_2DGame
{
    class Program
    {
        static void Main()
        {
            ConfigReader configReader = new ConfigReader();
            IConfig config;

            Debug.StartTracing();

            Debug.Log("Do you want to load settings from the configuration file? (Type 'y' for yes)", ConsoleColor.Blue);
            bool answer = Console.ReadKey().KeyChar == 'y' ? true : false;
            if (answer)
            {
                config = configReader.ReadConfiguration();
            }
            else
            {
                config = new Config(new Vector2(20, 20), new Vector2(4, 4), 'o');
            }
            
            World level1 = new World(config.BoardSize);
            Player player = new Player(new PlayerMove(), 100, "Player 1", config.PlayerStartPos, config.PlayerIcon);
            
            // Place a random box
            GameObject box = new GameObject("Box", new Vector2(5, 7));

            bool runGame = true;

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
