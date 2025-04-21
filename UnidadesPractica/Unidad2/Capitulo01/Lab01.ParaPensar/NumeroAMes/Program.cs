
string[] meses = new string[] {"enero", "febrero", "marzo", "abril", "mayo", "junio",
                                "julio", "agosto", "septiembre", "octubre", "noviembre",
                                "diciembre"};

Console.Write("Ingrese un mes a buscar: ");
string mesBusq = Console.ReadLine();

for (int i = 0; i < meses.Length; i++)
{
    if(mesBusq.ToLower() == meses[i])
    {
        Console.Write($"{mesBusq} es el mes número {i + 1}");
    }
}
