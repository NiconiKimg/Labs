Console.Write("Ingrese el año a comprobar: ");
int anio = int.Parse(Console.ReadLine());

if (anio % 4 == 0)
{
    if (anio % 100 == 0)
    {
        if (anio % 400 == 0)
        {
            Console.WriteLine("El año es bisiesto");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto");
        }
    }
    else
    {
        Console.WriteLine("El año es bisiesto");
    }
    
}
else
{
    Console.WriteLine("El año no es bisiesto");
}