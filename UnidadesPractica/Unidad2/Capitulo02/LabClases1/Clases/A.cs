using static System.Console;

namespace Clases

{
    public class A
    {
        string _nombreInstancia;

        public string NombreInstancia
        {
            get { return _nombreInstancia; }
            set { _nombreInstancia = value;  }
        }

        public A()
        {
            _nombreInstancia = "Instancia sin nombre";
        }

        public A(string nombreInstancia)
        {
            _nombreInstancia = nombreInstancia;
        }

        public string MostrarNombre()
        {
            return _nombreInstancia;
        }
        public void M1()
        {
            WriteLine("El método M1 fue invocado");
        }

        public void M2()
        {
            WriteLine("El método M2 fue invocado");
        }

        public void M3()
        {
            WriteLine("El método M3 fue invocado");
        }

    }
}
