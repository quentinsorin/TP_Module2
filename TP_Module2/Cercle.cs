﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Module2
{
    class Cercle : Forme
    {
        public int Rayon { get; set; }

        public override double Aire => Math.PI * Rayon * Rayon;

        public override double Perimetre => 2 * Math.PI * Rayon;

        public override string ToString()
        {
            return $"Cercle de rayon {Rayon}" + "\n" + base.ToString();
        }

    }
}
