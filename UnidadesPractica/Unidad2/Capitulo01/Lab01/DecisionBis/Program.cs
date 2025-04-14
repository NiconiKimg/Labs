// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un texto: ");
string? inputTexto = Console.ReadLine();

if (inputTexto != "" && inputTexto != null)
{
    Console.WriteLine("1- Mostrar texto en mayúsculas");
    Console.WriteLine("2- Mostrar texto en minúsculas");
    Console.WriteLine("3- Cantidad de caracteres");
    ConsoleKeyInfo opcion = Console.ReadKey();

    switch (opcion.Key)
    {
        case ConsoleKey.D1:
            Console.WriteLine("\n" + inputTexto.ToUpper());
            break;

        case ConsoleKey.D2:
            Console.WriteLine("\n" + inputTexto.ToLower());
            break;

        case ConsoleKey.D3:
            Console.WriteLine("\nLa longitud del texto ingresado es: " + inputTexto.Length);
            break;

        default:
            Console.WriteLine("La opción ingresada no es válida");
            break;
    }
}
else
{
    Console.WriteLine("El texto ingresado está vacío");
}
