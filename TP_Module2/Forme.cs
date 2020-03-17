﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Module2
{
    public abstract class Forme
    {
        public abstract double Aire { get; }
        public abstract double Perimetre { get; }
        public override string ToString()
        {
            return $"Aire = {Aire}" + "\n" + $"Périmètre = {Perimetre}" + "\n";
        }


    }
}
