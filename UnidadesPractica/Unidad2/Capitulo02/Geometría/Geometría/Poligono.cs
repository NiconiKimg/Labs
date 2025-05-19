using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Geometría
{
    public abstract class Poligono
    {
        public abstract double CalcularPerimetro();

        public abstract double CalcularSuperficie();
    }
}