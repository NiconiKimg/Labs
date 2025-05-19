
using BibliotecaClases;
using System.Collections;

ArrayList ciudades = new ArrayList();
ciudades.Add(new Ciudad("2000", "Rosario"));
ciudades.Add(new Ciudad("2200", "San Lorenzo"));
ciudades.Add(new Ciudad("2152", "Granadero Baigorria"));
ciudades.Add(new Ciudad("2451", "San Jorge"));
ciudades.Add(new Ciudad("6106", "La Asturiana"));
ciudades.Add(new Ciudad("2919", "Villa Constitución"));
ciudades.Add(new Ciudad("3061", "El Nochero"));
ciudades.Add(new Ciudad("3056", "Espin"));
ciudades.Add(new Ciudad("2643", "El Cantor"));
ciudades.Add(new Ciudad("2218", "Carrizales"));

Console.Write("Ingrese descripción parcial: ");
string? busq = Console.ReadLine();
busq = busq.ToUpper();

var ciudadesFiltradas = from c in ciudades.OfType<Ciudad>() //Tenemos que forzar el casteo porque el ejercicio pide usar ArrayList
                        where c.Nombre.ToUpper().Contains(busq)
                        select c;

foreach (object c in ciudadesFiltradas)
{
    Ciudad ciudad = (Ciudad) c;
    Console.WriteLine(ciudad);
}