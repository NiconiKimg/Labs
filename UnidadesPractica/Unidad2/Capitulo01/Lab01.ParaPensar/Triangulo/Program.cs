Console.Write("Ingrese cantidad de filas: ");
int nroFilas = int.Parse(Console.ReadLine());
Console.Clear();

for (int i = 0; i < nroFilas; i++)
{
    for (int j = 0; j < (nroFilas - i - 1); j++) 
    { 
        Console.Write(" "); 
    }
    for (int j = 0; j < ((2*i)+1); j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}