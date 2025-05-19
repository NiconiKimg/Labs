namespace BibliotecaClase
{
    public class Empleado
    {
        private static int contadorId = 0;
        private int _id;
        private string _nombre;
        private decimal _sueldo;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public decimal Sueldo
        {
            get { return _sueldo; }
            set
            {
                while (value <= 0)
                {
                    Console.Write("El sueldo debe ser mayor a 0");
                    value = decimal.Parse(Console.ReadLine());
                }
                _sueldo = value;
            }    
        }

        public Empleado(string nombre, decimal sueldo)
        {
            Id = ++contadorId;
            Nombre = nombre;
            Sueldo = sueldo;
        }
    }
}
