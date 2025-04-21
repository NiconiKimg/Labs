using Clases;

A a = new A("Nombre elaborado");
B b  = new();

a.M1();
a.M2();
a.M3();
Console.WriteLine($"Nombre de la instancia A: {a.MostrarNombre()}");

Console.WriteLine();

b.M1();
b.M2();
b.M3();
b.M4();
Console.WriteLine($"Nombre de la instancia B: {b.MostrarNombre()}");