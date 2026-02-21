using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora simple - suma y resta");

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("Elige operación: 1) Sumar   2) Restar   Q) Salir");
            Console.Write("Opción: ");
            var opt = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(opt))
                continue;

            opt = opt.Trim();
            if (opt.Equals("q", StringComparison.OrdinalIgnoreCase))
                break;

            if (opt == "1" || opt.Equals("sumar", StringComparison.OrdinalIgnoreCase))
                EjecutarOperacion((a, b) => a + b, "suma");
            else if (opt == "2" || opt.Equals("restar", StringComparison.OrdinalIgnoreCase))
                EjecutarOperacion((a, b) => a - b, "resta");
            else
                Console.WriteLine("Opción no válida. Intente de nuevo.");
        }

        Console.WriteLine("Saliendo. Presione una tecla para cerrar...");
        Console.ReadKey();
    }

    static void EjecutarOperacion(Func<double, double, double> operacion, string nombre)
    {
        double a = LeerNumero("Ingrese el primer número: ");
        double b = LeerNumero("Ingrese el segundo número: ");
        double resultado = operacion(a, b);
        Console.WriteLine($"Resultado de la {nombre}: {resultado}");
    }

    static double LeerNumero(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            var s = Console.ReadLine();
            if (double.TryParse(s, out var valor))
                return valor;
            Console.WriteLine("Número no válido. Intente de nuevo.");
        }
    }
}
