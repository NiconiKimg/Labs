namespace Geometría
{
    public class Circulo
    {
        private double m_radio;

        public double Radio
        {
            get {return m_radio;}
            set {m_radio = value; }
        }

        public double CalcularPerimetro()
        {
            return m_radio * 2 * Math.PI;
        }

        public double CalcularSuperficie()
        {
            return Math.PI * m_radio * m_radio;
        }
    }
}
