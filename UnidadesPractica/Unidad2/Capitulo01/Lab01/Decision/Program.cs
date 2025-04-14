Console.Write("Ingrese un texto: ");
string? inputTexto = Console.ReadLine();

if (inputTexto != "" && inputTexto != null)
{
    Console.WriteLine("1- Mostrar texto en mayúsculas");
    Console.WriteLine("2- Mostrar texto en minúsculas");
    Console.WriteLine("3- Cantidad de caracteres");
    ConsoleKeyInfo opcion = Console.ReadKey();

    if (opcion.Key == ConsoleKey.D1)
    {
        Console.WriteLine("\n" + inputTexto.ToUpper());
    }
    else if (opcion.Key == ConsoleKey.D2)
    {
        Console.WriteLine("\n" + inputTexto.ToLower());
    }
    else if (opcion.Key == ConsoleKey.D3)
    {
        Console.WriteLine("\nLa longitud del texto ingresado es: " + inputTexto.Length);
    }
}
else
{
    Console.WriteLine("El texto ingresado está vacío");
}