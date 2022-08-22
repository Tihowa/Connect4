﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4.Interfaces
{
    public interface IPlayer<T>
    {
        string Id { get; set; }
        string Nickname { get; set; }
        T MakeStepChip();
    }
}
