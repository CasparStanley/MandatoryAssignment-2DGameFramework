using System;
using System.Collections.Generic;
using ModelLib;
using ModelLib.Agent;
using ModelLib.Agent.Player;
using ModelLib.Factories;
using ModelLib.Interfaces;

namespace MandatoryAssignment_2DGame
{
    class Program
    {
        static void Main()
        {
            IGameStart gameStart = GameStart.Instance;
            gameStart.StartGame();

            // Place some random boxes
            IGameObjectFactory randomBoxFactory = new RandomBoxFactory(new Vector2(1, MathF.Min(World.Grid.x, World.Grid.y) - 1), "Box");
            for (int i = 0; i < 3; i++)
            {
                GameObject box = randomBoxFactory.GetGameObject();
            }

            gameStart.RunGame();

            //Item shield = new Item("Shield");
            //Creature player1 = new Creature(100, "Player 1");
            //Creature orc = new Creature(10, "Orc", new Vector2(5, 6));

            //Debug.Log("Objects in the world:", ConsoleColor.Green);
            //foreach (KeyValuePair<int, GameObject> kvp in World.Objects)
            //{
            //    Debug.Log(kvp.Key + ") " + kvp.Value.ToString());
            //}
        }
    }
}
