using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ModelLib
{
    public class ConfigReader : IConfigReader
    {
        public virtual IConfig ReadConfiguration()
        {
            XmlDocument configDoc = new XmlDocument();
            IConfig config = new Config();

            // Load from current path
            configDoc.Load("GameFrameworkConfiguration.xml");

            // Load from Envrironment Variable
            //string path = Environment.GetEnvironmentVariable("GameFrameworkConf");
            //if (path != null)
            //{
            //    configDoc.Load(path);
            //}


            XmlNode inputSystem = configDoc.DocumentElement.SelectSingleNode("InputSystem");
            XmlNode boardSize = configDoc.DocumentElement.SelectSingleNode("BoardSize");
            XmlNode playerStartPos = configDoc.DocumentElement.SelectSingleNode("PlayerStartPos");
            XmlNode playerIcon = configDoc.DocumentElement.SelectSingleNode("PlayerIcon");

            if (inputSystem != null)
            {
                string str = inputSystem.InnerText.Trim();
                if (str.Length > 0)
                {
                    // This is not really loading it from the config file, but let's pretend...
                    config.InputSystem = InputSystemCaspar.Instance;
                    Debug.Log($"Input System: {nameof(config.InputSystem)}");
                }
                else
                {
                    Debug.LogError($"{inputSystem.Name} was not properly loaded from the config file.");
                }
            }

            if (boardSize != null)
            {
                string[] str = boardSize.InnerText.Split(',', '.');
                if (str.Length == 2)
                {
                    config.BoardSize = new Vector2(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
                    Debug.Log($"Board Size: {config.BoardSize}");
                }
                else
                {
                    Debug.LogError($"{boardSize.Name} was not properly loaded from the config file.");
                }
            }

            if (playerStartPos != null)
            {
                string[] str = playerStartPos.InnerText.Split(',', '.');
                
                if (str.Length == 2)
                {
                    config.PlayerStartPos = new Vector2(Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
                    Debug.Log($"Player Start Position: {config.PlayerStartPos}");
                }
                else
                {
                    Debug.LogError($"{playerStartPos.Name} was not properly loaded from the config file.");
                }
            }

            if (playerIcon != null)
            {
                config.PlayerIcon = playerIcon.InnerText.Trim().ToCharArray()[0];
                Console.WriteLine($"Player Icon: {config.PlayerIcon}");
            }

            return config;
        }
    }
}
