﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperiorHackBase.Core.ProcessInteraction.Memory.Patterns.Processors
{
    public class Substract : ArithmeticProcessor
    {
        protected override Pointer Calculate(Pointer a, Pointer b)
        {
            return a - b;
        }
    }
}
