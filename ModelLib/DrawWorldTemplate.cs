using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public abstract class DrawWorldTemplate<T> where T : DrawWorldTemplate<T>
    {
        public abstract string WorldName { get; set; }

        private static readonly Lazy<T> Lazy = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);

        public static T Instance => Lazy.Value;


        public abstract void Draw(GameObject[] objects);
        public abstract void DrawCell(string content, ConsoleColor foregroundColor = ConsoleColor.White, ConsoleColor backgroundColor = ConsoleColor.DarkGray);
        public abstract void WriteStats();
    }
}
