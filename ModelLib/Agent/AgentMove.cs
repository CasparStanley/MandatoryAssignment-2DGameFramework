﻿using ModelLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Agent
{
    public abstract class AgentMove : IMove
    {
        //public Vector2 currentPos { get; set; } = Vector2.zero;

        
        public abstract Vector2 Move(string input);
    }
}
