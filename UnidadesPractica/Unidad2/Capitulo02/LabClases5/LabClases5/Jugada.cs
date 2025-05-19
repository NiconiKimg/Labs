using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases5
{
    public class Jugada
    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);
            _intentos = 0;
            _adivino = false;
        }

        public bool Adivino
        {
            get { return _adivino; }
            set { _adivino = value; }
        }

        public int Intentos
        {
            get { return _intentos; }
            set { _intentos = value; }
        }

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public virtual bool Comparar(int valor)
        {

            if (valor == _numero)
            {
                Adivino = true;
            }

            Intentos = _intentos + 1;
            return Adivino;
        }
    }
}
