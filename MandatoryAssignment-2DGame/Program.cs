using System;
using System.Collections.Generic;
using ModelLib;

namespace MandatoryAssignment_2DGame
{
    class Program
    {
        static void Main()
        {
            World level1 = new World();

            //Item shield = new Item("Shield");
            //Creature player1 = new Creature(100, "Player 1");
            //Creature orc = new Creature(10, "Orc", new Vector2(5, 6));

            //Debug.Log("Objects in the world:", ConsoleColor.Green);
            //foreach (KeyValuePair<int, GameObject> kvp in World.Objects)
            //{
            //    Debug.Log(kvp.Key + ") " + kvp.Value.ToString());
            //}

            Vector2 currentPos = new Vector2(4, 4);

            while (true)
            {
                DrawWorld.Draw(currentPos);
                char input = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (char.ToLower(input))
                {
                    case ('w'):
                        {
                            currentPos += new Vector2(0, 1);
                            break;
                        }
                    case ('a'):
                        {
                            currentPos += new Vector2(-1, 0);
                            break;
                        }
                    case ('s'):
                        {
                            currentPos += new Vector2(0, -1);
                            break;
                        }
                    case ('d'):
                        {
                            currentPos += new Vector2(1, 0);
                            break;
                        }
                    default:break;
                }
            }
        }
    }
}
