using System;
using System.Collections.Generic;
class Coleccion
{
    public List<double> Precios = new List<double>();

    public void Cargar()
    {
        Console.Write("Cantidad de figuras: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese precio #" + (i + 1) + ": ");
            Precios.Add(double.Parse(Console.ReadLine()));
        }
    }

    public void Resumen()
    {
        double suma = 0;
        double max = Precios.Count > 0 ? Precios[0] : 0;

        foreach (double valor in Precios)
        {
            suma += valor;

            if (valor > max)
            {
                max = valor;
            }
        }

        Console.WriteLine("\nResumen:");
        Console.WriteLine("Total: " + suma);
        Console.WriteLine("Mayor precio: " + max);
    }
}