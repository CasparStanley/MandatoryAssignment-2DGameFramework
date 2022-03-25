using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public static class Debug
    {
        public static void Log(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.Write(message);

            Console.ResetColor();
        }

        public static void LogWarning(string message, ConsoleColor color = ConsoleColor.Black)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Write(message);

            Console.ResetColor();

            Vector2 test1 = new Vector2(1, 1);
            Vector2 test2 = new Vector2(2, 6);

            
        }

        public static void LogError(string message, ConsoleColor color = ConsoleColor.White, bool errorPause = false)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Red;

            Console.Write(message);

            Console.ResetColor();

            if (errorPause) { Console.ReadLine(); }
        }

        // Variants
        #region Variants
        public static void Log(int number)
        {
            Log(number.ToString());
        }
        public static void Log(float number)
        {
            Log(number.ToString());
        }
        public static void Log(bool boolean)
        {
            Log(boolean.ToString());
        }

        public static void LogWarning(int number)
        {
            Log(number.ToString());
        }
        public static void LogWarning(float number)
        {
            Log(number.ToString());
        }
        public static void LogWarning(bool boolean)
        {
            Log(boolean.ToString());
        }

        public static void LogError(int number)
        {
            Log(number.ToString());
        }
        public static void LogError(float number)
        {
            Log(number.ToString());
        }
        public static void LogError(bool boolean)
        {
            Log(boolean.ToString());
        }
        #endregion
    }
}
