using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometría
{
    public class Triangulo
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public double Lado1
        {
            get { return lado1; }
            set { lado1 = value; }
        }

        public double Lado2
        {
            get { return lado2; }
            set { lado2 = value; }
        }

        public double Lado3
        {
            get { return lado3; }
            set { lado3 = value; }
        }

        public double CalcularPerimetro()
        {
            return lado1 + lado2 + lado3;
        }

        public double CalcularSuperficie()
        {
            double perim = CalcularPerimetro();
            return Math.Sqrt(perim * (perim - lado1) * (perim - lado2) * (perim - lado3));
        }
    }
}