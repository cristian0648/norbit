using System;
using System.Collections.Generic;
class Figura
{
    public string Id;
    public double Precio;
    public double Extra;

    public void Cargar()
    {
        Console.Write("ID de figura: ");
        Id = Console.ReadLine();

        Console.Write("Precio base: ");
        Precio = double.Parse(Console.ReadLine());

        Console.Write("Aumento de precio: ");
        Extra = double.Parse(Console.ReadLine());
    }

    public double PrecioFinal()
    {
        return Precio + Extra;
    }

    public void Mostrar()
    {
        Console.WriteLine("\nResultado:");
        Console.WriteLine("ID: " + Id);
        Console.WriteLine("Precio final: " + PrecioFinal());
    }
}