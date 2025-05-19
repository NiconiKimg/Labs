
List<int> numeros = new List<int>();

int cantidad = 100;
Random rand = new Random();

for  (int i = 0; i < cantidad; i++)
{
    numeros.Add(rand.Next(0,101));
}

var mayoresVeinte = from n in numeros
                    where n > 20
                    select n;

foreach (int i in mayoresVeinte)
{
    Console.WriteLine(i);
}