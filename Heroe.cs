using System;
using System.Collections.Generic;
class Heroe
{
    public string Nombre;
    public string Descripcion;
    public bool Capa;
    
    public void Cargar()
    {
        Console.Write("Ingrese nombre: ");
        Nombre = Console.ReadLine();

        Console.Write("Ingrese descripcion: ");
        Descripcion = Console.ReadLine();

        Console.Write("Tiene capa? (true/false): ");
        Capa = Convert.ToBoolean(Console.ReadLine());
    }

    public void Mostrar()
    {
        Console.WriteLine("\nDatos cargados:");
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Descripcion: " + Descripcion);
        Console.WriteLine("Capa: " + Capa);
    }
}