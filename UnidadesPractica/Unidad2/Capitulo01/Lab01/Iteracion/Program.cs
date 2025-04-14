int cantIteraciones = 5;
string[] arreglo = new string[cantIteraciones];

for (int i = 0; i < cantIteraciones; i++)
{
    Console.WriteLine("Ingrese la posición " + i);
    arreglo[i] = Console.ReadLine();
}

for (int i = cantIteraciones - 1; i >= 0; i--)
{
    Console.WriteLine("\n" + arreglo[i]);
}