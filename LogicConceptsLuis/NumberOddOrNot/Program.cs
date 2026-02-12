var numberString = string.Empty;
do
{
    Console.Write("Ingrese número entero o 'S' para salir:");
    numberString = Console.ReadLine();
    if (numberString == "S")
    {
        continue;
    }
    var numberInt = 0;
    if (int.TryParse(numberString, out numberInt))
    {
        
        if (numberInt % 2 == 0)
        {
            Console.WriteLine($"El numero {numberInt}, es par.");
        }
        else
        {
            Console.WriteLine($"El numero {numberInt}, es impar.");
        }
    }
    else
    {
        Console.WriteLine($"Lo que ingresaste: {numberString}, no es un numero entero.");
    }
} while (numberString != "S");


