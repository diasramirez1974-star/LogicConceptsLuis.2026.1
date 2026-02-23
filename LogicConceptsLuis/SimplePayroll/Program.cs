using Shared;
using System.ComponentModel.Design;
var answer = string.Empty;
var options = new List<string> { "s", "n" };
do
{
    var name = ConsoleExtension.GetString("Ingrese el nombre: ");
    var workHours = ConsoleExtension.GetFloat("Ingrese el número de horas trabajadas: ");
    var hourValue = ConsoleExtension.GetDecimal("Ingrese el valor de la hora: ");
    var minumunSalary = ConsoleExtension.GetDecimal("Ingrese el salario mínimo: ");

    var salary = (decimal)workHours * hourValue;

    if (salary < minumunSalary)
    {
        Console.WriteLine($"Nombre: {name}");
    }
    else
    {
        Console.WriteLine($"Nombre: {name}");
        Console.WriteLine($"Salario Mensual: {salary:C2}");
    }


    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Has salido del programa");