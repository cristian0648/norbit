using System;
using System.Collections.Generic;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Heroe =====
            Console.WriteLine("===SUPERHEROE ===");

            Console.Write("Ingrese nombre: ");
            string Heroe = Console.ReadLine();

            Console.Write("Ingrese descripcion: ");
            string descripcion = Console.ReadLine();

            Console.Write("Tiene capa? (true/false): ");
            bool capa = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("\nDatos cargados:");
            Console.WriteLine("Nombre: " + Heroe);
            Console.WriteLine("Descripcion: " + descripcion);
            Console.WriteLine("Capa: " + capa);

            Console.ReadKey();
            Console.Clear();

            // ===== Dimensiones =====
            Console.WriteLine("=== DIMENSIONES ===");

            Console.Write("Alto: ");
            double Alto = double.Parse(Console.ReadLine());

            Console.Write("Ancho: ");
            double Ancho = double.Parse(Console.ReadLine());

            Console.Write("Profundidad: ");
            double Profundidad = double.Parse(Console.ReadLine());

            double vol = Alto + Ancho * Profundidad;

            Console.WriteLine("\nVolumen calculado: " + vol);

            Console.ReadKey();
            Console.Clear();

            // ===== FIGURA =====
            Console.WriteLine("=== FIGURA ===");

            Console.Write("ID de figura: ");
            string id = Console.ReadLine();

            Console.Write("Precio base: ");
            double Precio = double.Parse(Console.ReadLine());

            Console.Write("Aumento de precio: ");
            double Extra = double.Parse(Console.ReadLine());

            double Preciofinal = Precio + Extra;

            Console.WriteLine("\nResultado:");
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Precio final: " + Preciofinal);

            Console.ReadKey();
            Console.Clear();

            // ===== COLECCION =====
            Console.WriteLine("=== COLECCION ===");

            List<double> Precios = new List<double>();

            Console.Write("Cantidad de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Ingrese precio #" + (i + 1) + ": ");
                Precios.Add(double.Parse(Console.ReadLine()));
            }

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

            Console.ReadKey();
        }
    }
}