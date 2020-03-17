using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Module2
{
    class Rectangle : Forme
    {
        public  int Largeur { get; set; }
        public int Longueur { get; set; }

        public override double Aire => Largeur * Longueur;

        public override double Perimetre => 2 * Largeur + 2 * Longueur;
        public override string ToString()
        {
            return $"Rectangle de longueur={Longueur} et largeur={Largeur}" + "\n" + base.ToString();
        }

       


    }
}
