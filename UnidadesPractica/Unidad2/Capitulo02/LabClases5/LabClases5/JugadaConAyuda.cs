using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabClases5
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int max) : base(max){}

        public override bool Comparar(int valor)
        {

            if (valor == Numero)
            {
                Adivino = true;
            }
            else
            {
                int diferencia = Math.Abs(valor - Numero);
                if (Numero > valor && diferencia > 100)
                {
                    Console.WriteLine("El número buscado es mayor. Está muy lejos");
                }
                if (diferencia < 5)
                {
                    Console.WriteLine("Está cerca");
                }
            }

                Intentos = Intentos + 1;
            return Adivino;
        }
    }
}
