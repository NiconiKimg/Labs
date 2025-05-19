
List<string> provincias =  new List<string>();

provincias.Add("Buenos Aires");
provincias.Add("Catamarca");
provincias.Add("Chaco");
provincias.Add("Chubut");
provincias.Add("CABA");
provincias.Add("Córdoba");
provincias.Add("Corrientes");
provincias.Add("Entre Rios");
provincias.Add("Formosa");
provincias.Add("Jujuy");
provincias.Add("La Pampa");
provincias.Add("La Rioja");
provincias.Add("Mendoza");
provincias.Add("Misiones");
provincias.Add("Neuquén");
provincias.Add("Rio Negro");
provincias.Add("Salta");
provincias.Add("San Juan");
provincias.Add("San Luis");
provincias.Add("Santa Cruz");
provincias.Add("Santa Fe");
provincias.Add("Santiago del Estero");
provincias.Add("Tierra del Fuego");
provincias.Add("Tucumán");

var provinciasFiltradas = from p in provincias
                          where p.StartsWith("S") || p.StartsWith("T")
                          select p;

foreach (var p in provinciasFiltradas)
{
    Console.WriteLine(p);
}