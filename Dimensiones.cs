using System;
using System.Collections.Generic;
class Dimensiones
{
    public double Alto;
    public double Ancho;
    public double Profundidad;

    public void Cargar()
    {
        Console.Write("Alto: ");
        Alto = double.Parse(Console.ReadLine());

        Console.Write("Ancho: ");
        Ancho = double.Parse(Console.ReadLine());

        Console.Write("Profundidad: ");
        Profundidad = double.Parse(Console.ReadLine());
    }

    public double CalcularVolumen()
    {
        return Alto + Ancho * Profundidad;
    }
}