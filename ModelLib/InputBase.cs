using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public abstract class InputSystemBase<T> where T : InputSystemBase<T>, IInputSystem
    {
        public abstract string InputSystemName { get; set; }
        public abstract Dictionary<char, string> Inputs { get; set; }

        private static readonly Lazy<T> Lazy = new Lazy<T>(() => Activator.CreateInstance(typeof(T), true) as T);

        public static T Instance => Lazy.Value;
    }
}
