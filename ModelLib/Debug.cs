using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    /// <summary>
    /// Custom Console Write class, which can write logs, warnings, and errors, and support console colors.
    /// It will also write each log to a Tracelog.txt file located at: 
    /// \MandatoryAssignment-2DGameFramework\MandatoryAssignment-2DGame\bin\Debug\net5.0\Tracelog.txt
    /// </summary>
    public static class Debug
    {
        // HACK: Tracing/Logging

        private static TraceSource ts = new TraceSource("Trace Source");
        // Tracelog.txt is located at: MandatoryAssignment-2DGameFramework\MandatoryAssignment-2DGame\bin\Debug\net5.0\Tracelog.txt
        private static TraceListener textTraceListener = new TextWriterTraceListener(new StreamWriter("TraceLog.txt"));

        public static void StartTracing()
        {
            ts.Listeners.Add(textTraceListener);
            ts.Switch = new SourceSwitch("Log All", "All");
        }

        public static void StopTracing()
        {
            ts.Close();
        }

        public static void Log(string message, ConsoleColor color = ConsoleColor.White, bool onlyTrace = false)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Black;

            if (!onlyTrace)
            { Console.Write(message); }
            ts.TraceEvent(TraceEventType.Verbose, 0, message);

            Console.ResetColor();
        }

        public static void LogWarning(string message, ConsoleColor color = ConsoleColor.Black, bool onlyTrace = false)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Yellow;

            if (!onlyTrace)
            { Console.Write(message); }
            ts.TraceEvent(TraceEventType.Warning, 1, message);

            Console.ResetColor();
        }

        public static void LogError(string message, ConsoleColor color = ConsoleColor.White, bool onlyTrace = false, bool errorPause = false)
        {
            Console.ForegroundColor = color;
            Console.BackgroundColor = ConsoleColor.Red;

            if (!onlyTrace)
            { Console.Write(message); }
            ts.TraceEvent(TraceEventType.Error, 3, message);

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
