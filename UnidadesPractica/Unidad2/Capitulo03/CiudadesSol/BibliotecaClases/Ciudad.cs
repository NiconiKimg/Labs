using BibliotecaClases;

namespace BibliotecaClases
{
    public class Ciudad
    {
        private string _codPostal;
        private string _nombre;

        public string CodPostal
        {
            get { return _codPostal; }
            set { _codPostal = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Ciudad(string codPostal, string nombre)
        {
            CodPostal = codPostal;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"Codigo Postal: " + CodPostal + "; Nombre: " + Nombre;
        }
    }
}
