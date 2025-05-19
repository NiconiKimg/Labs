namespace LabClases5
{
    public class Juego
    {
        private int _record;

        public Juego()
        {
            _record = 99999;
        }

        public void ComenzarJuego()
        {

            bool continua = true;
            do
            {
                int max = PreguntarMaximo();

                JugadaConAyuda jugada = new(max);

                int numero;
                bool resultado = false;

                do
                {
                    numero = PreguntarNumero();
                    resultado = jugada.Comparar(numero);

                } while (!resultado);

                CompararRecord(jugada.Intentos);

                Console.Write("Presione ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

                continua = Continuar();
            } while (continua);
        }

        private void CompararRecord(int intentos)
        {
            if (intentos < _record)
            {
                _record = intentos;
                Console.WriteLine($"Felicidades, haz logrado un nuevo record. {_record} intentos");
            }
            else
            {
                Console.WriteLine($"Felicidades, adivinaste el número en {intentos} intentos.");
            }
        }

        private bool Continuar()
        {
            Console.Write("Quieres jugar una nueva partida? S/N: ");
            string opc = (Console.ReadLine()).ToUpper();
            if (opc == "S")
            {
                return true;
            }
            return false;
        }

        private int PreguntarMaximo()
        {
            int max = 0;
            do
            {
                try { 
                    Console.Write("Ingrese el número máximo: ");
                    max = int.Parse(Console.ReadLine());
                }
                catch (FormatException) {
                    Console.Clear();
                    Console.WriteLine("El valor ingresado debe ser un numero entero");
                    max = -1;
                }
            } while (max < 0);

            return max;
        }

        private int PreguntarNumero()
        {
            int num;
            do
            {
                try { 
                    Console.Write("Ingrese su elección: ");
                    num = int.Parse(Console.ReadLine());
                    
                }
                catch (Exception) 
                {
                    Console.Clear();
                    Console.WriteLine("El valor ingresado debe ser un numero entero mayor o igual 0");
                    num = -1;
                }
            } while (num < 0);
            
            return num;

        }
    }
}
