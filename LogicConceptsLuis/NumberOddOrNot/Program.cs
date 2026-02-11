do
{
    Console.Write("Ingrese número:");
    var numberString = Console.ReadLine();
    var numberInt = int.Parse(numberString!);
    if (numberInt % 2 == 0)
    {
        Console.WriteLine($"El numero {numberInt}, es par.");
    }
    else
    {
        Console.WriteLine($"El numero {numberInt}, es impar.");
    }
}
while (true);

