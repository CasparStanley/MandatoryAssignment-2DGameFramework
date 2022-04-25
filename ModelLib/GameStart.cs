
using ModelLib.Agent.Player;
using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class GameStart : IGameStart
    {
        public IConfig Config
        {
            get { return _config; }
        }

        public World World
        {
            get { return _world; }
        }

        public Player Player
        {
            get { return _player; }
        }

        public bool RunningGame
        {
            get { return _running; }
        }

        protected IConfig _config;
        protected World _world;
        protected Player _player;
        protected bool _running;

        // Singleton Stuff
        private static readonly Lazy<GameStart> _instance = new Lazy<GameStart>(() => new GameStart());
        public static GameStart Instance { get { return _instance.Value; } }

        protected GameStart() { }

        public virtual void StartGame()
        {
            ConfigReader configReader = new ConfigReader();

            Debug.StartTracing();

            // Get the settings for this game
            Debug.Log("Do you want to load settings from the configuration file? (Type 'y' for yes)", ConsoleColor.Blue);
            bool answer = Console.ReadKey().KeyChar == 'y' ? true : false;
            if (answer)
            {
                _config = configReader.ReadConfiguration();
            }
            else
            {
                _config = new Config(InputSystemCaspar.Instance, new Vector2(20, 20), new Vector2(4, 4), 'o');
            }

            // Create the world and player
            _world = new World(_config.BoardSize);
            _player = new Player(new PlayerMove(), 100, 2, "Player 1", _config.PlayerStartPos, _config.PlayerIcon);

            Debug.Log("-------- The world was created --------", onlyTrace: true); // Custom Debug class, which also uses tracing.

            _running = true;
        }

        // TODO: DESIGN PATTERN - POTENTIAL USE OF STRATEGY - To control what goes in which order.
        public virtual void RunGame()
        {
            DrawWorld.Instance.Draw(World.GetObjects());
            Debug.Log("-------- The world drawn for the first time --------", onlyTrace: true);

            while (_running)
            {
                char input = Console.ReadKey().KeyChar;
                if (_config.InputSystem.Inputs.ContainsKey(input))
                {

                }

                switch (input)
                {
                    case 'w':
                        _player.DoMove("Up");
                        break;
                    case 'a':
                        _player.DoMove("Left");
                        break;
                    case 's':
                        _player.DoMove("Down");
                        break;
                    case 'd':
                        _player.DoMove("Right");
                        break;
                    case 'e':
                        _player.PickUpItem();
                        break;
                    case 'q':
                        _player.Attack.OnAttack();
                        break;
                    case (char)ConsoleKey.Escape:
                        StopGame();
                        break;
                }

                Console.Clear();
                DrawWorld.Instance.Draw(World.GetObjects());
                Debug.Log("-------- The world was updated --------", onlyTrace: true);
            }
        }

        public virtual void StopGame()
        {
            _running = false;

            // It is important to hit escape before closing the program, so the code will reach this part to save the tracing file.
            Debug.StopTracing();
        }
    }
}
