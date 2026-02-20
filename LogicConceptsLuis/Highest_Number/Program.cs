using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    Console.WriteLine("Programa para determinar el número mayor entre tres números");
    Console.Write("Ingrese el primer número:");
    var number1String = Console.ReadLine();
    var number1Int = int.Parse(number1String!);
    Console.Write("Ingrese el segundo número:");
    var number2String = Console.ReadLine();
    var number2Int = int.Parse(number2String!);
    Console.Write("Ingrese el tercer número:");
    var number3String = Console.ReadLine();
    var number3Int = int.Parse(number3String!);
    if (number1Int > number2Int && number1Int > number3Int)
    {
        Console.WriteLine($"El número mayor es {number1Int}");
    }
    if (number2Int > number1Int && number2Int > number3Int)
    {
        Console.WriteLine($"El número mayor es {number2Int}");
    }
    if (number3Int > number1Int && number3Int > number2Int)
    {
        Console.WriteLine($"El número mayor es {number3Int}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Deseas continuar [S]í, [N]o?: ", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));


} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));

Console.WriteLine("Game Over.");


