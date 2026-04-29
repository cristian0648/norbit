class Program
{
    static void Main(string[] args)
    {
        // ===== HEROE =====
        Console.WriteLine("=== SUPERHEROE ===");

        Heroe h = new Heroe();
        h.Cargar();
        h.Mostrar();

        Console.ReadKey();
        Console.Clear();

        // ===== DIMENSIONES =====
        Console.WriteLine("=== DIMENSIONES ===");

        Dimensiones d = new Dimensiones();
        d.Cargar();
        Console.WriteLine("\nVolumen calculado: " + d.CalcularVolumen());

        Console.ReadKey();
        Console.Clear();

        // ===== FIGURA =====
        Console.WriteLine("=== FIGURA ===");

        Figura f = new Figura();
        f.Cargar();
        f.Mostrar();

        Console.ReadKey();
        Console.Clear();

        // ===== COLECCION =====
        Console.WriteLine("=== COLECCION ===");

        Coleccion c = new Coleccion();
        c.Cargar();
        c.Resumen();

        Console.ReadKey();
    }
}