using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Geometría
{
    public class Rectangulo : Poligono
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double largo, double ancho) 
        {
            Largo = largo;
            Ancho = ancho;
        }
        public override double CalcularPerimetro()
        {
            return ((Largo * 2) + (Ancho * 2));
        }

        public override double CalcularSuperficie()
        {
            return (Largo * Ancho);
        }
    }
}