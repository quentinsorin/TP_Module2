﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Module2
{
    class Carre : Forme
    {
        public int Longueur { get; set; }

        public override double Aire => Longueur * Longueur;

        public override double Perimetre => Longueur*4;

        public override string ToString()
        {
            return $"Carré de coté={Longueur}" + "\n" + base.ToString();
        }

    }
}
