using Shared;
using System.ComponentModel.Design;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    Console.WriteLine("Ingrese dos números para ver si uno es multiplo del otro");
    var a = ConsoleExtension.GetInt("Ingrese el primer número: ");
    var b = ConsoleExtension.GetInt("Ingrese el segundo número: ");
    if (a % b == 0)
    {
        Console.WriteLine($"El número {a}, es multiplo de {b}");
    }
    else
    {
        Console.WriteLine($"El número {a}, No es multiplo de {b}");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Has salido del programa");


