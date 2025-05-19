namespace LabClases4
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _dni;

        public Persona(string nombre, string apellido, int edad, string dni)
        {
            _nombre = nombre;
            _apellido = apellido;
            Edad = edad;
            _dni = dni;

            Console.WriteLine("La persona fue creada exitosamente");
        }

        ~Persona()
        {
            Console.WriteLine("La persona fue eliminada exitosamente");
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public int Edad
        {
            get { return _edad; }
            set {
                if (value < 0)
                    throw new ArgumentException("La edad debe ser mayor o igual a 0");
                _edad = value;
            }
        }

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string GetFullName()
        {
            return $"{_nombre} {_apellido}";
        }

        public int GetAge()
        {
            return _edad;
        }
    }
}
