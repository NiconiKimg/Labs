int intentos = 0;
bool correcta = false;
string claveCorrecta = "1234";
do
{
    Console.Clear();
    intentos++;
    Console.Write("Ingrese la contraseña: ");
    string clave = Console.ReadLine();
    if(clave == claveCorrecta)
    {
        correcta = true;
        Console.WriteLine("Clave Correcta");
    }
    else
    {
        Console.WriteLine($"Clave incorrecta");
        Console.WriteLine($"Llevas {intentos} de 4 intentos");
        Console.ReadKey();
    }
} while (intentos < 4 && !correcta);