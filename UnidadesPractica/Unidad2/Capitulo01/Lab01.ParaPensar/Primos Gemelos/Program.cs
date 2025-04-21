
Console.WriteLine("Ingrese la cantidad de primos gemelos que quiere ver: ");
int cant = int.Parse(Console.ReadLine());
Console.WriteLine();

int paresEncontrados = 0;
int numeroActual = 2;

while (paresEncontrados < cant)
{
    int cantDivisores = 0;
    for(int i = 1; i <= numeroActual; i++)
    {
        if (numeroActual % i == 0)
        {
            cantDivisores++;
        }
    }

    if (cantDivisores == 2)
    {
        int siguienteNumero = numeroActual + 2;
        int cantDivisoresSiguiente = 0;
        for(int i = 1; i <= siguienteNumero; i++)
        {
            if (siguienteNumero % i == 0)
            {
                cantDivisoresSiguiente++;
            }
        }
        if (cantDivisoresSiguiente == 2)
        {
            Console.WriteLine($"Los primos gemelos son: {numeroActual} y {siguienteNumero}");
            paresEncontrados++;
        }
    }
    numeroActual++;
}