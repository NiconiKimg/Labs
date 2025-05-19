using BibliotecaClase;

List<Empleado> empleados = new List<Empleado>();

Console.WriteLine("1- Dar de alta nuevos empleados");
Console.WriteLine("2- Ordenar empleados de forma ASCENDENTE");
Console.WriteLine("3- Ordenar empleados de forma DESCENDETE");
Console.WriteLine("0- Salir");

ConsoleKeyInfo opcion = Console.ReadKey();

while(opcion.Key != ConsoleKey.D0)
{
    switch (opcion.Key)
    {
        case ConsoleKey.D1:
            Console.Write("Ingrese el nombre del nuevo empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el sueldo del nuevo empleado: ");
            decimal sueldo = decimal.Parse(Console.ReadLine());

            empleados.Add(new Empleado(nombre, sueldo));

            break;

        case ConsoleKey.D2:
            var empleadosAscendentes = from e in empleados
                                       orderby e.Sueldo ascending
                                       select e;
            foreach (var e in empleadosAscendentes)
            {
                Console.WriteLine($"Id: {e.Id} | Nombre: {e.Nombre} | Sueldo : {e.Sueldo}");
            }
            break;

        case ConsoleKey.D3:
            var empleadosDescendentes = from e in empleados
                                        orderby e.Sueldo descending
                                        select e;
            foreach (var e in empleadosDescendentes)
            {
                Console.WriteLine($"Id: {e.Id} | Nombre: {e.Nombre} | Sueldo : {e.Sueldo}");
            }
            break;

        default:
            Console.WriteLine("La opción ingresada no es válida");
            break;
    }

    Console.WriteLine("1- Dar de alta nuevos empleados");
    Console.WriteLine("2- Ordenar empleados de forma ASCENDENTE");
    Console.WriteLine("3- Ordenar empleados de forma DESCENDETE");
    Console.WriteLine("0- Salir");

    opcion = Console.ReadKey();
}
