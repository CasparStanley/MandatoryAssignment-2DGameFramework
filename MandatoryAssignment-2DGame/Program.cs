using System;
using System.Collections.Generic;
using ModelLib;
using ModelLib.Agent;
using ModelLib.Agent.Player;
using ModelLib.Agent.Enemy;
using ModelLib.Factories;
using ModelLib.Interfaces;
using ModelLib.GameObjects;
using ModelLib.GameObjects.Armor;
using ModelLib.GameObjects.Weapons;

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
                GameObject box = randomBoxFactory.GetGameObjectFixedPosition();
            }

            // Place a weapon
            IGameObjectFactory swordFactory = new SwordFactory(10, 2, "Sword");
            Sword sword = (Sword)swordFactory.GetGameObject(new Vector2(4, 2));

            // Place some enemies
            IGameObjectFactory enemyFactory = new EnemyFactory(4, 2, "Enemy", 'E');
            Enemy enemy1 = (Enemy)enemyFactory.GetGameObject(new Vector2(2, 2));
            Enemy enemy2 = (Enemy)enemyFactory.GetGameObject(new Vector2(6, 6));

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
