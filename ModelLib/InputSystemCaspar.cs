using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class InputSystemCaspar : InputSystemBase<InputSystemCaspar>, IInputSystem
    {
        public override string InputSystemName { get; set; }

        private InputSystemCaspar() { }

        public override Dictionary<char, string> Inputs { get; set; } = new Dictionary<char, string>
        {
            {'w', "Up"},
            {'a', "Left" },
            {'s', "Down"},
            {'d', "Right"},
            {(char)ConsoleKey.UpArrow, "Up"},
            {(char)ConsoleKey.LeftArrow, "Left"},
            {(char)ConsoleKey.DownArrow, "Down"},
            {(char)ConsoleKey.RightArrow, "Right"},
            {(char)ConsoleKey.Escape, "Stop"},
            {(char)ConsoleKey.End, "Stop"},
            {'e', "Interact"},
            {'q', "Attack"},
            {(char)ConsoleKey.Spacebar, "Attack"},
        };
    }
}
