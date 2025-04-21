// Inicializamos un diccionario. Se podría hacer con dos arrays, pero queriamos probar de esta maenra.
Dictionary<string, int> valores =
    new Dictionary<string, int>();

valores.Add("M", 1000);
valores.Add("CM", 900);
valores.Add("D", 500);
valores.Add("CD", 400);
valores.Add("C", 100);
valores.Add("XC", 90);
valores.Add("L", 50);
valores.Add("XL", 40);
valores.Add("X", 10);
valores.Add("IX", 9);
valores.Add("V", 5);
valores.Add("IV", 4);
valores.Add("I", 1);

// Try-Catch para manejar errores de formato y excepciones generales. Raro que surja una excepción != a FormatException, pero por las dudas.
try
{
  Console.Write("Ingrese un númwero de 1 al 3999: ");
  int numero = int.Parse(Console.ReadLine());
  int numeroAux = numero;

  while (numero >= 1 && numero <= 3999)
  {
    string numeroRomano = "";

    foreach( KeyValuePair<string, int> kvp in valores)
    {
      while (numero >= kvp.Value)
      {
        numeroRomano += kvp.Key;
        numero -= kvp.Value;
      }
    }

    Console.WriteLine($"{numeroAux} en números romanos es {numeroRomano}");

    Console.Write("Ingrese otro númwero de 1 al 3999(o fuera de rango para salir): ");
    numero = int.Parse(Console.ReadLine());
    numeroAux = numero;
  }
}
catch (FormatException)
{
  Console.WriteLine("Error. Debes ingresar un número entero válido");
}
catch (Exception e)
{
  Console.WriteLine(e.Message);
}


Console.WriteLine("Programa terminado.");

